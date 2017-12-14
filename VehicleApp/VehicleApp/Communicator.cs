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
        #endregion

        #region Public Properties

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
        /// Open the serial connection and check connection has been made with a test message.
        /// </summary>
        private void Open()
        {
            serialPort.Open();
            try
            {
                byte[] buffer = new byte[2];
                buffer[0] = 0xff;               // Ping command
                serialPort.Write(buffer, 0, 1);
                serialPort.Read(buffer, 1, 1);
            }
            catch (TimeoutException) { };       // If the port did not open, a read/write will timeout.
        } 
    }
}
