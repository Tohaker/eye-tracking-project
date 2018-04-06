using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework;
using EyeXFramework.Forms;
using Tobii.EyeX.Framework;

namespace VehicleApp
{
    public partial class TobiiSettings : Form
    {
        private readonly FormsEyeXHost _eyeXHost;
        private int dwellTime;

        public int DwellTime { get { return dwellTime; } }

        public TobiiSettings(int dt)
        {
            InitializeComponent();

            // Get the EyeX host.
            _eyeXHost = Program.EyeXHost;

            dwellTime = dt;

            numDwellTime.Value = dwellTime;
            sliderDwellTime.Value = dwellTime;
        }

        #region Eye Tracking
        protected override void OnLoad(EventArgs e)
        {
            // Register an status-changed event listener for user presence.
            // NOTE that the event listener must be unregistered too. This is taken care of in the Dispose(bool) method.
            _eyeXHost.UserPresenceChanged += EyeXHost_UserPresenceChanged;

            // Start the EyeX host.
            if (!_eyeXHost.IsStarted)
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
                chkUserPresent.Checked = true;
            }
            else
                chkUserPresent.Checked = false;
        }
        #endregion

        #region Gaze Time
        private void numDwellTime_ValueChanged(object sender, EventArgs e)
        {
            if (numDwellTime.Value > sliderDwellTime.Maximum)
                sliderDwellTime.Maximum = (int)numDwellTime.Value;

            sliderDwellTime.Value = (int)numDwellTime.Value;
            dwellTime = (int)numDwellTime.Value;
        }

        private void sliderDwellTime_ValueChanged(object sender, EventArgs e)
        {
            numDwellTime.Value = sliderDwellTime.Value;
            dwellTime = sliderDwellTime.Value;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            EyeControl eyeControl = this.Owner as EyeControl;
            if (eyeControl != null)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
