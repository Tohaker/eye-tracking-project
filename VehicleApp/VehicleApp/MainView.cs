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
    public partial class MainView : Form
    {
        #region Private Members
        private VehicleControl controller;
        #endregion
        public MainView()
        {
            InitializeComponent();

            EnableButtons(false);
        }

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
            string selectedPort = cmbComSelect.SelectedItem.ToString();

            if (controller == null)     // Check if the controller object exists already
            {
                controller = new VehicleControl(selectedPort);
            }

            if (btnConnect.Text == "Connect")
            {
                controller.Open();
                btnConnect.Text = "Disconnect";

                EnableButtons(true);
            }
            else if (btnConnect.Text == "Disconnect")
            {
                controller.Close();
                btnConnect.Text = "Connect";

                EnableButtons(false);
            }
            
        }

        private void EnableButtons(bool state)
        {
            btnCmd1.Enabled = state;
            btnCmd2.Enabled = state;
            btnCmd3.Enabled = state;
            btnCmd4.Enabled = state;
            btnCmd5.Enabled = state;
            btnCmd6.Enabled = state;

            btnSend.Enabled = state;
        }

        private void btnCmd1_Click(object sender, EventArgs e)
        {
            SendMsg(0);
        }

        private void btnCmd2_Click(object sender, EventArgs e)
        {
            SendMsg(1);
        }

        private void btnCmd3_Click(object sender, EventArgs e)
        {
            SendMsg(2);
        }

        private void btnCmd4_Click(object sender, EventArgs e)
        {
            SendMsg(3);
        }

        private void btnCmd5_Click(object sender, EventArgs e)
        {
            SendMsg(4);
        }

        private void btnCmd6_Click(object sender, EventArgs e)
        {
            SendMsg(5);
        }

        private void SendMsg(int cmd, int data = 0)
        {
            controller.SendMessage(cmd, data);
            rtbConsole.AppendText("Sent: " + controller.SentMessage.ToString() + "\n");
            controller.ReceiveMessage();
            rtbConsole.AppendText("Received: " + controller.ReceivedMessage.ToString() + "\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessageBox.Text != "")
            {
                controller.SendMessage(txtMessageBox.Text);
                rtbConsole.AppendText("Sent: " + controller.SentMessage.ToString() + "\n");
                controller.ReceiveMessage();
                rtbConsole.AppendText("Received: " + controller.ReceivedMessage.ToString() + "\n");
            }            
        }
    }
}
