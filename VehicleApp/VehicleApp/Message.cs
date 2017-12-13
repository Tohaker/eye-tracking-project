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
        string outMessage = "";         // Create an empty string if Message is not created to be an output.
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

        /// <summary>
        /// The message to send out. Will not return anything if the Object was created with a missing command.
        /// </summary>
        public string OutputMessage
        { get { return outMessage; } }
        #endregion

        /// <summary>
        /// Create a message with optional data.
        /// </summary>
        /// <param name="command">Command identification</param>
        /// <param name="data">Payload data. Defaults to all 0s if unitialised.</param>
        public Message (int command, int data = defaultData)
        {
            if ((command >= 0) && (command < 16))       // Simple check to make sure the command is between 0000 and 1111
            {
                this.command = command;

                if ((data >= 0) && (data < 2048))       // Similar check to make sure the data is 11 bits or fewer
                    this.data = data;

                this.outMessage = PackageMessage();     // Package the message up ready to be sent.
            }

            //  TODO: Error Messages
        }

        /// <summary>
        /// Overload of Message Class. Used to split a received message into its constituent parts.
        /// </summary>
        /// <param name="received">The string received that you wish to parse.</param>
        public Message (string received)
        {
            int msg = Convert.ToInt16(received);
            int direction = msg >> 15;              // Strip back all the trailing bits from the MSb.

            if (direction == 0)                     // If the direction bit is 0, we know it has come from elsewhere.
            {
                this.command = msg & 15;            // AND with 15 to only take the first 4 bits.
                this.data = (msg >> 4) & 2047;      // Shift 4 to bring to the LSB, then AND with 2047 to take the first 11 bits.
            }

            //  TODO: Error Messages
        }

        ~Message() { }

        /// <summary>
        /// Shifts the command and data into a 16-bit, string formatted message ready for sending.
        /// </summary>
        /// <returns></returns>
        private string PackageMessage ()
        {
            string output = "";
            int temp;

            UInt16 msg = (ushort) command;  // Place command in LSB;
            temp = (data << 4);             // Shift the data by 4 to place after the 4 bit command.
            msg |= (ushort) temp;           // OR temp with the msg to move it into the right position.
            temp = (1 << 15);               // Shift the 1 to the end of the 16 bit message, to show we sent it.
            msg |= (ushort) temp;

            output = msg.ToString();
            return output;
        }

    }
}
