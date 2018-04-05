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
    public partial class DataLog : Form
    {
        #region Private Members
        private VehicleControl controller;
        #endregion

        public DataLog(string com)
        {
            InitializeComponent();
            if ((controller == null) && (com != ""))     // Check if the controller object exists already
                controller = new VehicleControl(com);
            label1.Text = "Connected to" + com;
            EnableButtons(true);
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

            if (btnConnect.Text == "Connect")
            {
                controller.ChangeConnection(selectedPort);
                label1.Text = "Connected to" + selectedPort;
                btnConnect.Text = "Disconnect";

                EnableButtons(true);
            }
            else if (btnConnect.Text == "Disconnect")
            {
                controller.Close();
                btnConnect.Text = "Connect";
                label1.Text = "Disconnected";

                EnableButtons(false);
            }
            
        }

        private void ClearButtonColours()
        {
            btnCmd1.BackColor = Color.Transparent;
            btnCmd2.BackColor = Color.Transparent;
            btnCmd3.BackColor = Color.Transparent;
            btnCmd4.BackColor = Color.Transparent;
            btnCmd5.BackColor = Color.Transparent;
            btnCmd6.BackColor = Color.Transparent;
            btnCmd7.BackColor = Color.Transparent;
        }

        private void EnableButtons(bool state)
        {
            btnCmd1.Enabled = state;
            btnCmd2.Enabled = state;
            btnCmd3.Enabled = state;
            btnCmd4.Enabled = state;
            btnCmd5.Enabled = state;
            btnCmd6.Enabled = state;
            btnCmd7.Enabled = state;

            btnSend.Enabled = state;
        }

        private void btnCmd1_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Forward())
                btnCmd1.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd2_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Reverse())
                btnCmd2.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd3_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Brake())
                btnCmd3.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd4_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Left())
                btnCmd4.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd5_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Right())
                btnCmd5.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd6_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.SetSpeed((int)numSpeed.Value))
                btnCmd6.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnCmd7_Click(object sender, EventArgs e)
        {
            ClearButtonColours();
            if (controller.Ping())
                btnCmd7.BackColor = Color.Green;

            rtbConsole.AppendText("Sent: " + controller.BinarySentMessage + "\n");
            rtbConsole.AppendText("Received: " + controller.BinaryReceivedMessage + "\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessageBox.Text != "")
            {
                controller.SendMessage(txtMessageBox.Text);
                rtbConsole.AppendText("Sent: " + controller.SentMessage + "\n");
                controller.ReceiveMessage();
                rtbConsole.AppendText("Received: " + controller.ReceivedMessage + "\n");
            }            
        }
    }
}
