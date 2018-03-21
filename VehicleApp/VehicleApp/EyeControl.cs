using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private System.Timers.Timer timer;
        private Button selectedButton;
        private int gazeTime = 1500;
        private int brakeTime = 750;

        public EyeControl(string com_port)
        {
            InitializeComponent();

            controller = new VehicleControl(com_port);
            controller.Open();

            // Add eye-gaze interaction behaviors to the buttons on the form.
            // The buttons should change colour when the user's gaze are on them.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(btnForward, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnReverse, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnLeft, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnRight, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnBrake, new GazeAwareBehavior(OnGaze));

            btnForward.FlatAppearance.BorderSize = 2;
            btnReverse.FlatAppearance.BorderSize = 2;
            btnRight.FlatAppearance.BorderSize = 2;
            btnLeft.FlatAppearance.BorderSize = 2;
            btnBrake.FlatAppearance.BorderSize = 2;
        }

        #region Timers
        private void TimerSetup(Button btn)
        {
            if (btn.Equals(btnBrake))
                timer = new System.Timers.Timer(brakeTime);
            else
                timer = new System.Timers.Timer(gazeTime);

            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;
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
            TimerSetup(button);   // Recalculate the timer as gazeTime could have changed.

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

            selectedButton.FlatAppearance.BorderColor = Color.Green;
        }
        #endregion

        #region Menu Controls
        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Add password protect
            DataLog devScreen = new DataLog();
            devScreen.Show();
        }

        private void connectionSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void applicationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TobiiSettings settingsScreen = new TobiiSettings(gazeTime);
            if (settingsScreen.ShowDialog(this) == DialogResult.OK)
            {
                gazeTime = settingsScreen.GazeTime;
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
            controller.Brake();
        }
        #endregion
    }
}
