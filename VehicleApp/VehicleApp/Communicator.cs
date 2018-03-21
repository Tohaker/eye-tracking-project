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
        bool timeout = false;
        #endregion

        #region Public Properties
        /// <summary>
        /// Flag set if a timeout occured.
        /// </summary>
        public bool Timeout { get { return timeout; } }
        
        /// <summary>
        /// Name of currently connected port.
        /// </summary>
        public string COM_Port { get { return serialPort.PortName; } }
        #endregion

        /// <summary>
        /// Creates a Communicator object for a serial COM port, which must be defined. 
        /// </summary>
        /// <param name="COM">COM Port to be used by this object.</param>
        /// <param name="baudRate">Baud Rate: Defaults to 9600.</param>
        /// <param name="parity">Parity: Defaults to 8.</param>
        public Communicator (string COM, int baudRate = 9600)
        {
            if (serialPort == null)             // Make a new port, if one already exists we are simply overwriting values.
                serialPort = new SerialPort();

            serialPort.PortName = COM;
            serialPort.BaudRate = baudRate;

            serialPort.ReadTimeout = 500;       // Set the timeouts to 500ms each.
            serialPort.WriteTimeout = 500;

            serialPort.NewLine = "\r\n";         // The Arduino sends both \r\n at a new line, so we must look for this when perfoming .ReadLine()

            // TODO: Error Checking
            //       Determine required settings
        }

        ~Communicator() { }

        /// <summary>
        /// Open the serial connection.
        /// </summary>
        public void Open()
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
        /// Wraps the IsOpen method from the Serial Connection into the Communicator.
        /// </summary>
        /// <returns>Returns whether it is open or not.</returns>
        public bool IsOpen()
        {
            if (serialPort.IsOpen)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Closes the serial connection.
        /// </summary>
        public void Close()
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
        public void Send(string message)
        {
            timeout = false;
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.WriteLine(message);
                }
                catch (TimeoutException) { timeout = true; };
            }
                
        }

        /// <summary>
        /// Checks the serial buffer for data to read.
        /// </summary>
        public string Receive()
        {
            timeout = false;
            string received = "";
            if (serialPort.IsOpen)
            {
                try
                {
                    received = serialPort.ReadLine();
                }
                catch (TimeoutException) { timeout = true; }
            }
            return received;
        }
    }
}
