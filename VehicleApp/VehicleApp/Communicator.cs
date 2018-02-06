using System;
using System.Collections.Generic;
using System.Linq;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Communicator
    {
        #region Private Members
        SerialPort serialPort;
        string receivedMessage = "";
        bool timeout = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// The Message received by the Communicator.
        /// </summary>
        public string Message { get { return receivedMessage; } }

        /// <summary>
        /// Flag set if a timeout occured.
        /// </summary>
        public bool Timeout { get { return timeout; } }
        #endregion

        /// <summary>
        /// Creates a Communicator object for a serial COM port, which must be defined. 
        /// </summary>
        /// <param name="COM">COM Port to be used by this object.</param>
        /// <param name="baudRate">Baud Rate: Defaults to 9600.</param>
        /// <param name="parity">Parity: Defaults to 8.</param>
        public Communicator (string COM, int baudRate = 9600, int parity = 8)
        {
            if (serialPort == null)             // Make a new port, if one already exists we are simply overwriting values.
                serialPort = new SerialPort();

            serialPort.PortName = COM;
            serialPort.BaudRate = baudRate;
            serialPort.Parity = (Parity)parity;

            serialPort.ReadTimeout = 500;       // Set the timeouts to 500ms each.
            serialPort.WriteTimeout = 500;

            // TODO: Error Checking
            //       Determine required settings
        }

        /// <summary>
        /// Open the serial connection.
        /// </summary>
        private void Open()
        {
            timeout = false;
            if (!serialPort.IsOpen)
            {
                try
                {
                    serialPort.Open();
                }
                catch (TimeoutException) { timeout = true; };       // If the port did not open, a read/write will timeout.
            }            
        }

        /// <summary>
        /// Closes the serial connection.
        /// </summary>
        private void Close()
        {
            timeout = false;
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }           
        }

        /// <summary>
        /// Sends a message to the serial port, using the options set at object construction.
        /// </summary>
        /// <param name="message">The string to send.</param>
        private void Send(string message)
        {
            timeout = false;
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(message);
                }
                catch (TimeoutException) { timeout = true; };
            }
                
        }

        /// <summary>
        /// Checks the serial buffer for data to read.
        /// </summary>
        private void Receive()
        {
            timeout = false;
            if (serialPort.IsOpen)
            {
                try
                {
                    receivedMessage = serialPort.ReadLine();
                }
                catch (TimeoutException) { timeout = true; };
            }
        }
    }
}
