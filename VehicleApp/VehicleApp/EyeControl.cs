using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EyeXFramework;

namespace VehicleApp
{
    public partial class EyeControl : Form
    {
        private VehicleControl controller;
        private Button selectedButton;

        private System.Timers.Timer timer;
        private Stopwatch stopwatch;
        private int dwellTime = 1500;
        private int brakeTime;
        private int elapsedTime;

        private bool demoMode;

        /// <summary>
        /// Full featured mode constructor
        /// </summary>
        /// <param name="com_port"></param>
        public EyeControl(string com_port)
        {
            InitializeComponent();

            brakeTime = dwellTime / 2;

            controller = new VehicleControl(com_port);
            controller.Open();

            demoMode = false;
            lblDemoMode.Text = "";
            btnExitDemo.Enabled = false;
            btnExitDemo.Hide();

            // Add eye-gaze interaction behaviors to the buttons on the form.
            // The buttons should change colour when the user's gaze are on them.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(btnForward, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnReverse, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnLeft, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnRight, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnBrake, new GazeAwareBehavior(OnGaze));
        }

        /// <summary>
        /// Demo Mode Constructor
        /// </summary>
        public EyeControl()
        {
            InitializeComponent();

            brakeTime = dwellTime / 2;

            demoMode = true;
            developerToolStripMenuItem.Enabled = false;
            connectionSettingsToolStripMenuItem.Enabled = false;
            lblDemoMode.Text = "Demo Mode Active - Communications will be limited.";
            btnExitDemo.Enabled = true;
            btnExitDemo.Show();

            // Add eye-gaze interaction behaviors to the buttons on the form.
            // The buttons should change colour when the user's gaze are on them.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(btnForward, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnReverse, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnLeft, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnRight, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnBrake, new GazeAwareBehavior(OnGaze));
        }

        #region Timers
        private void TimerSetup(Button btn)
        {
            if (btn.Equals(btnBrake))
                timer = new System.Timers.Timer(brakeTime);
            else
                timer = new System.Timers.Timer(dwellTime);

            stopwatch = new Stopwatch();
            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;
        }

        private void StartTimer()
        {
            timer.Enabled = true;
            stopwatch.Start();
        }

        private void PauseTimer()
        {
            DisposeTimer();
            elapsedTime = (int)stopwatch.ElapsedMilliseconds;
            stopwatch.Stop();
        }

        private void ResumeTimer()
        {
            timer = new System.Timers.Timer(dwellTime - elapsedTime)
            {
                AutoReset = false
            };
            timer.Elapsed += OnTimedEvent;
        }

        private void StopTimer()
        {
            DisposeTimer();
            stopwatch.Stop();
            stopwatch.Reset();
        }

        private void DisposeTimer()
        {
            if (timer != null)
                timer.Dispose();
        }
        #endregion

        #region Eye Tracking
        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var button = sender as Button;

            DisposeTimer(); // Remove any previous instances of the timer to keep resources free.
            TimerSetup(button);   // Recalculate the timer as dwellTime could have changed.

            if (button != null)
            {
                if (e.HasGaze)
                {
                    button.FlatAppearance.BorderColor = Color.Red;
                    selectedButton = button;
                    timer.Enabled = true;
                }
                else
                {
                    button.FlatAppearance.BorderColor = Color.Black;
                    timer.Enabled = false;
                }
            }
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (!demoMode)
            {
                if (selectedButton.Equals(btnForward))
                {
                    controller.Forward();
                }
                else if (selectedButton.Equals(btnReverse))
                {
                    controller.Reverse();
                }
                else if (selectedButton.Equals(btnLeft))
                {
                    controller.Left();
                }
                else if (selectedButton.Equals(btnRight))
                {
                    controller.Right();
                }
                else if (selectedButton.Equals(btnBrake))
                {
                    controller.Brake();
                }
            }

            selectedButton.FlatAppearance.BorderColor = Color.Green;
        }
        #endregion

        #region Menu Controls
        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordDialog password = new PasswordDialog();
            if (password.ShowDialog() == DialogResult.OK)
            {
                DataLog devScreen = new DataLog(controller.COM_Port);
                controller.Close();
                devScreen.ShowDialog();
                controller.Open();
            }
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionSettings connectionSettings = new ConnectionSettings(controller.COM_Port);
            controller.Close();
            if (connectionSettings.ShowDialog(this) == DialogResult.OK)
            {
                controller.ChangeConnection(connectionSettings.Com_Port);
            }
        }

        private void applicationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiSettings settingsScreen = new TobiiSettings(dwellTime);
            if (settingsScreen.ShowDialog(this) == DialogResult.OK)
            {
                dwellTime = settingsScreen.DwellTime;
            }

        }
        #endregion

        #region Button Design
        private void btnForward_MouseEnter(object sender, EventArgs e)
        {
            btnForward.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnForward_MouseLeave(object sender, EventArgs e)
        {
            btnForward.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            btnForward.FlatAppearance.BorderColor = Color.Green;
            if (!demoMode)
                controller.Forward();
        }

        private void btnRight_MouseEnter(object sender, EventArgs e)
        {
            btnRight.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnRight_MouseLeave(object sender, EventArgs e)
        {
            btnRight.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            btnRight.FlatAppearance.BorderColor = Color.Green;
            if (!demoMode)
                controller.Right();
        }

        private void btnReverse_MouseEnter(object sender, EventArgs e)
        {
            btnReverse.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnReverse_MouseLeave(object sender, EventArgs e)
        {
            btnReverse.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            btnReverse.FlatAppearance.BorderColor = Color.Green;
            if(!demoMode)
                controller.Reverse();
        }

        private void btnLeft_MouseEnter(object sender, EventArgs e)
        {
            btnLeft.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnLeft_MouseLeave(object sender, EventArgs e)
        {
            btnLeft.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            btnLeft.FlatAppearance.BorderColor = Color.Green;
            if (!demoMode)
                controller.Left();
        }

        private void btnBrake_MouseEnter(object sender, EventArgs e)
        {
            btnBrake.FlatAppearance.BorderColor = Color.Red;
        }

        private void btnBrake_MouseLeave(object sender, EventArgs e)
        {
            btnBrake.FlatAppearance.BorderColor = Color.Black;
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            btnBrake.FlatAppearance.BorderColor = Color.Green;
            if(!demoMode)
                controller.Brake();
        }
        #endregion

        private void btnExitDemo_Click(object sender, EventArgs e)
        {
            Application.Restart();  //Restarts the app, reduces resources used to keep forms open.
        }
    }
}
