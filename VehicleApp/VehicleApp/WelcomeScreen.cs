using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EyeXFramework;
using EyeXFramework.Forms;
using Tobii.EyeX.Framework;

namespace VehicleApp
{
    public partial class WelcomeScreen : Form
    {
        private VehicleControl controller;
        private readonly FormsEyeXHost _eyeXHost;

        public WelcomeScreen()
        {
            InitializeComponent();
            btnAppStart.Enabled = false;

            // Get the EyeX host.
            _eyeXHost = Program.EyeXHost;
        }

        #region Eye Tracking
        protected override void OnLoad(EventArgs e)
        {
            // Register an status-changed event listener for user presence.
            // NOTE that the event listener must be unregistered too. This is taken care of in the Dispose(bool) method.
            _eyeXHost.UserPresenceChanged += EyeXHost_UserPresenceChanged;

            // Start the EyeX host.
            _eyeXHost.Start();

            // Wait until we're connected.
            if (_eyeXHost.WaitUntilConnected(TimeSpan.FromSeconds(5)))
            {
                // Make sure the EyeX Engine version is equal to or greater than 1.4.
                var engineVersion = _eyeXHost.GetEngineVersion().Result;
                if (engineVersion.Major != 1 || engineVersion.Major == 1 && engineVersion.Minor < 4)
                {
                    MessageBox.Show("Requires EyeX Engine 1.4 - Please update.");
                }
            }
            else
            {
                MessageBox.Show("Could not connect to EyeX engine.");
            }
        }

        private void EyeXHost_UserPresenceChanged(object sender, EngineStateValue<UserPresence> e)
        {
            // State-changed events are received on a background thread.
            // But operations that affect the GUI must be executed on the main thread.
            // We use BeginInvoke to marshal the call to the main thread.

            if (Created)
            {
                BeginInvoke(new Action(() => UpdateUserPresence(e)));
            }
        }

        private void UpdateUserPresence(EngineStateValue<UserPresence> value)
        {
            if (value.IsValid &&
                value.Value == UserPresence.Present)
            {
                chkTobiiUserPresent.Checked = true;
            }
            else
                chkTobiiUserPresent.Checked = false;
        }
        #endregion

        private void cmbComSelect_DropDown(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            cmbComSelect.Items.Clear();
            foreach (var portName in portNames)
            {
                cmbComSelect.Items.Add(portName);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbComSelect.Items.Count > 0)
            {
                string selectedPort = cmbComSelect.SelectedItem.ToString();

                if (controller == null)     // Check if the controller object exists already
                {
                    controller = new VehicleControl(selectedPort);
                }

                if (btnConnect.Text == "Connect")
                {
                    controller.Open();
                    if (controller.Ping())      // Test the connection by Pinging the device.
                    {
                        btnConnect.Text = "Disconnect";

                        //if (chkTobiiUserPresent.Checked)  // [Optional] Check if the user is in front of the screen
                        btnAppStart.Enabled = true;
                    }
                }
                else if (btnConnect.Text == "Disconnect")
                {
                    controller.Close();
                    btnConnect.Text = "Connect";
                    btnAppStart.Enabled = false;
                }
            }
        }

        private void btnAppStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            string selectedPort = cmbComSelect.SelectedItem.ToString();
            controller.Close();
            EyeControl eyeControl = new EyeControl(selectedPort);
            eyeControl.Closed += (s, args) => this.Close();
            eyeControl.Show();
        }
    }
}
