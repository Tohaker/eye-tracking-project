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

namespace GazeAwareLED
{
    public partial class GazeAwareForm : Form
    {
        private static System.Timers.Timer timer;
        private string selectedButton;

        public GazeAwareForm()
        {
            InitializeComponent();

            // Add eye-gaze interaction behaviors to the buttons on the form.
            // The buttons should change colour when the user's gaze are on them.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(btnON, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnOFF, new GazeAwareBehavior(OnGaze));

            TimerSetup();
        }

        private void TimerSetup()
        {
            timer = new System.Timers.Timer(2000);
            timer.AutoReset = false;
            timer.Elapsed += OnTimedEvent;
        }

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                if (e.HasGaze)
                {
                    button.BackColor = Color.Green;
                    selectedButton = sender.ToString();
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
            if (selectedButton.Contains("Turn LED On"))
                LEDon();
            else if (selectedButton.Contains("Turn LED Off"))
                LEDoff();
        }

        private void LEDon()
        {
            if (stateBox.InvokeRequired)
                stateBox.Invoke((MethodInvoker)delegate { stateBox.Checked = true; });
            else
                stateBox.Checked = true;
        }

        private void LEDoff()
        {
            if (stateBox.InvokeRequired)
                stateBox.Invoke((MethodInvoker)delegate { stateBox.Checked = false; });
            else
                stateBox.Checked = false;
        }
    }
}
