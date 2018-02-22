using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class VehicleControl
    {
        #region Private Members
        private Message message;
        private Communicator connection;
        private string sentMessage = "";
        private string receivedMessage = "";

        private int forwardCmd  = 0;
        private int reverseCmd  = 1;
        private int brakeCmd    = 2;
        private int leftCmd     = 3;
        private int rightCmd    = 4;
        private int speedCmd    = 5;
        private int pingCmd     = 6;
        private int pingData    = 7;
        #endregion

        #region Public Properties
        public string SentMessage { get { return sentMessage; } }

        public string ReceivedMessage { get { return receivedMessage; } }
        #endregion
        public VehicleControl(string COM)
        {
            if (message == null)
            {
                message = new Message();
            }
            
            if (connection == null)
            {
                connection = new Communicator(COM);
            }
        }
        
        /// <summary>
        /// Bundles a message up and sends it to the communicator.
        /// </summary>
        /// <param name="command">Command to send (between 0 and 16).</param>
        /// <param name="data">Optional data to send with the command.</param>
        /// <returns></returns>
        public bool SendMessage(int command, int data = 0)
        {
            string msg;
            bool success;
            msg = message.PackageMessage(command, data);
            sentMessage = msg;

            connection.Open();
            
            if (!connection.Timeout)    // Check the internal flag to see if the connection was actually opened.
            {
                connection.Send(msg);
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }


        /// <summary>
        /// Bundles a string up and sends it to the communicator.
        /// </summary>
        /// <param name="data">Data to be sent.</param>
        /// <returns></returns>
        public bool SendMessage(string data)
        {
            string msg = message.PackageMessage(data);
            bool success;
            sentMessage = msg;

            connection.Open();

            if (!connection.Timeout)    // Check the internal flag to see if the connection was actually opened.
            {
                connection.Send(msg);
                success = true;
            }
            else
            {
                success = false;
            }

            return success;
        }

        /// <summary>
        /// Tries to receive a message then passes it to the message class to parse data.
        /// </summary>
        public void ReceiveMessage()
        {
            receivedMessage = connection.Receive();

            if (receivedMessage == "")  // No data received, try again;
            {
                receivedMessage = connection.Receive();
            }
            else
                message.ParseMessage(receivedMessage);
        }

        /// <summary>
        /// Opens the Communication channel.
        /// </summary>
        public void Open()
        {
            connection.Open();
        }

        /// <summary>
        /// Closes the Communication channel.
        /// </summary>
        public void Close()
        {
            connection.Close();
        }

        public bool Forward()
        {
            if (SendMessage(forwardCmd))
            {
                ReceiveMessage();
                if (message.GetCommand == forwardCmd)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Reverse()
        {
            if (SendMessage(reverseCmd))
            {
                ReceiveMessage();
                if (message.GetCommand == reverseCmd)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Brake()
        {
            if (SendMessage(brakeCmd))
            {
                ReceiveMessage();
                if (message.GetCommand == brakeCmd)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Left()
        {
            if (SendMessage(leftCmd))
            {
                ReceiveMessage();
                if (message.GetCommand == leftCmd)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Right()
        {
            if (SendMessage(rightCmd))
            {
                ReceiveMessage();
                if (message.GetCommand == rightCmd)
                {
                    return true;
                }
            }
            return false;
        }

        public bool SetSpeed(int speed)
        {
            if (SendMessage(speedCmd, speed))
            {
                ReceiveMessage();
                if ((message.GetCommand == speedCmd) && (message.GetData == speed))
                {
                    return true; // Check that we have the right speed returned.
                }
            }
            return false;
        }

        public bool Ping()
        {
            if (SendMessage(pingCmd, pingData))
            {
                ReceiveMessage();
                if ((message.GetCommand == pingCmd) && (message.GetData == pingData))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
