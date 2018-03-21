using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class ConnectionSettings : Form
    {
        private VehicleControl vehicleControl;
        private string ComPort;

        public string Com_Port { get { return ComPort; } }

        public ConnectionSettings(string COM)
        {
            InitializeComponent();
            btnTestConnection.Enabled = false;
            lblCurrentConnection.Text = "Currently connected to: " + COM;
        }

        #region Connection Change
        private void cmbComPort_DropDown(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            cmbComPort.Items.Clear();
            foreach (var portName in portNames)
            {
                cmbComPort.Items.Add(portName);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbComPort.Items.Count > 0)
            {
                string selectedPort = cmbComPort.SelectedItem.ToString();

                if (btnConnect.Text == "Connect")
                {
                    if (vehicleControl == null)
                    {
                        vehicleControl = new VehicleControl(selectedPort);
                    }
                    vehicleControl.Open();
                    ComPort = selectedPort;
                    btnTestConnection.Enabled = true;
                }
                else if (btnConnect.Text == "Disconnect")
                {
                    vehicleControl.Close();
                    btnTestConnection.Enabled = false;
                }
            }
        }
        #endregion

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (vehicleControl.Ping())
            {
                chkTestResult.Checked = true;
                chkTestResult.Text = "Successful";
            }
            else
            {
                chkTestResult.Checked = false;
                chkTestResult.Text = "Unsuccessful";
            }
        }

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
