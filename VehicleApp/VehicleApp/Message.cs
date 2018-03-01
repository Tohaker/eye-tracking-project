using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    class Message
    {
        #region Private Members
        const int defaultData = 0;      // If no data is supplied, all zeros are filled instead.
        int data;
        int command;
        int direction = 1;
        #endregion

        #region Public Properties
        /// <summary>
        /// Payload data for message.
        /// </summary>
        public int Data { get { return data; } }

        /// <summary>
        /// Command identifier.
        /// </summary>
        public int Command { get { return command; } }
        #endregion

        /// <summary>
        /// Create a message object to parse and create messages.
        /// </summary>
        public Message ()
        {

        }

        ~Message() { }

        /// <summary>
        /// Shifts the command and data into an 8-bit, string formatted message ready for sending.
        /// </summary>
        /// <returns></returns>
        public string PackageMessage (int command, int data = defaultData)
        {
            string output = "";
            int msg;

            if ((command >= 0) && (command <= 16))       // Simple check to make sure the command is between 0000 and 1111
            {
                this.command = command;

                if ((data >= 0) && (data <= 7))          // Similar check to make sure the data is 3 bits or fewer
                    this.data = data;

                msg = command | (data << 4) | (direction << 7);
                output = Convert.ToString(msg);
            }
            else
            {
                throw new Exception("Invalid command entered.");
            }
           
            return output;
        }

        /// <summary>
        /// Packages up a string to send to the serial connection.
        /// </summary>
        /// <param name="command">The string to send.</param>
        /// <returns></returns>
        public string PackageMessage (string command)
        {
            return command;     // Simple now, but may become more complex later so the method can be used elsewhere.
        }

        /// <summary>
        /// Determines whether a message was meant for the program and collects data from it. 
        /// </summary>
        /// <param name="received">The string received from the serial connection.</param>
        public void ParseMessage (string received)
        {
            int rec;

            rec = Convert.ToInt16(received);
            
            int MSB = rec >> 7;     // Assuming an 8 bit value is received the MSByte will be all 0s.
            if (MSB == 0)           // Check that the message has come from the Arduino.
            {
                this.command = rec & 0x0F;  // Mask first 4 bits to retrieve them.
                this.data = (rec & 0x70) >> 4;     // Mask bits 4 - 6 to retrieve them. 
            }
        }

    }
}
