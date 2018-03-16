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
        }

        #region Timers
        private void TimerSetup()
        {
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

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            DisposeTimer(); // Remove any previous instances of the timer to keep resources free.
            TimerSetup();   // Recalculate the timer as gazeTime could have changed.
            var button = sender as Button;

            if (button != null)
            {
                if (e.HasGaze)
                {
                    button.BackColor = Color.Green;
                    selectedButton = button;
                    timer.Enabled = true;
                }
                else
                {
                    button.BackColor = Color.Transparent;
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

            selectedButton.BackColor = Color.Transparent;
        }

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

        }
        #endregion


    }
}
