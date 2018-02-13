using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleApp
{
    
    #region Private Variables
    private Message message;
    private Communicator connection;
    #endregion
    
    #region Public Declarations
    #endregion
    
    class VehicleControl
    {
        public VehicleControl(string COM)
        {
            if (message == null)
            {
                message = new Message();
            }
            
            if (connection == null)
            {
                connection = new Communicator(COM); // Needs connection info - collect from construction of Vehicle Control?
            }
        }
        
        public SendMessage(int command, int data = 0)
        {
            string msg;
            
            if (data == 0)
                msg = message.PackageMessage(command);
            else
                msg = message.PackageMessage(command, data);
            
            // TODO: Create "IsOpen" checked for communicator class
        }
    }
}
