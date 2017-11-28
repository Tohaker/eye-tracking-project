using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
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
        private static SerialPort arduinoPort;

        private Button selectedButton;
        private int gazeTime = 2000;

        private bool btnOnSelected = false;
        private bool btnOffSelected = false;

        public GazeAwareForm()
        {
            InitializeComponent();

            // Add eye-gaze interaction behaviors to the buttons on the form.
            // The buttons should change colour when the user's gaze are on them.
            Program.EyeXHost.Connect(behaviorMap1);
            behaviorMap1.Add(btnON, new GazeAwareBehavior(OnGaze));
            behaviorMap1.Add(btnOFF, new GazeAwareBehavior(OnGaze));

            if ((gazeTime <= slideFixLength.Maximum) && (gazeTime >= slideFixLength.Minimum))       // In case someone makes a mistake in the hard coding of the starting value!!
                slideFixLength.Value = gazeTime;
        }

        private void OpenArduinoConnection(string portName)
        {
            if (arduinoPort == null)
            {
                arduinoPort = new SerialPort();
                arduinoPort.PortName = portName;      // Hard coding in COM port - could also use 'login screen' solution at a later date
                arduinoPort.BaudRate = 9600;        // Default for arduino, may allow user/dev to set at runtime at a later date
                arduinoPort.DataBits = 8;
                arduinoPort.Handshake = Handshake.None;

                arduinoPort.ReadTimeout = 500;      // Set timouts
                arduinoPort.WriteTimeout = 500;

                arduinoPort.Open();                    
            }            
        }

        private void CloseArduinoConnection()
        {
            if ((arduinoPort != null) && (arduinoPort.IsOpen))
                arduinoPort.Close();
        }

        private void SendToArduino(string command)
        {
            if ((arduinoPort != null) && (arduinoPort.IsOpen))
            {
                arduinoPort.Write(command);
            }
            else
                MessageBox.Show("Cannot Write to Arduino, check the connection", "Communication Error Occured");
        }

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

        private void OnGaze(object sender, GazeAwareEventArgs e)
        {
            DisposeTimer(); // Remove any previous instances of the timer to keep resources free.
            TimerSetup();   // Recalculate the timer as gazeTime could have changed.
            var button = sender as Button;
            if (button != null)
            {
                if (e.HasGaze)
                {
                    if (!btnOnSelected || !btnOffSelected)
                    {
                        button.BackColor = Color.Green;
                        selectedButton = button;
                        timer.Enabled = true;
                    }
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
            if (selectedButton.ToString().Contains("Turn LED On"))
            {
                LEDon();
                btnOnSelected = true;
                btnOffSelected = false;
            }
            else if (selectedButton.ToString().Contains("Turn LED Off"))
            {
                LEDoff();
                btnOnSelected = false;
                btnOffSelected = true;
            }
            selectedButton.BackColor = Color.Transparent;
        }

        private void LEDon()
        {
            if (stateBox.InvokeRequired)
                stateBox.Invoke((MethodInvoker)delegate { stateBox.Checked = true; });
            else
                stateBox.Checked = true;
            SendToArduino("1");
        }

        private void LEDoff()
        {
            if (stateBox.InvokeRequired)
                stateBox.Invoke((MethodInvoker)delegate { stateBox.Checked = false; });
            else
                stateBox.Checked = false;

            SendToArduino("0");
        }

        private void cmbComPort_DropDown(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            cmbComPort.Items.Clear();
            foreach ( var portName in portNames)
            {
                cmbComPort.Items.Add(portName);
            }
        }

        private void cmbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPort = cmbComPort.SelectedItem.ToString();
            OpenArduinoConnection(selectedPort);
        }

        // Both of these methods alter the other - slider and numeric up-down are in sync
        private void slideFixLength_ValueChanged(object sender, EventArgs e)
        {
            gazeTime = slideFixLength.Value;

            if (numFixLength.InvokeRequired)
                numFixLength.Invoke((MethodInvoker)delegate { numFixLength.Value = gazeTime; });
            else
                numFixLength.Value = gazeTime;
        }

        private void numFixLength_ValueChanged(object sender, EventArgs e)
        {
            gazeTime = (int)numFixLength.Value;

            if (slideFixLength.InvokeRequired)
                slideFixLength.Invoke((MethodInvoker)delegate { slideFixLength.Value = gazeTime; });
            else
                slideFixLength.Value = gazeTime;
        }
    }
}
