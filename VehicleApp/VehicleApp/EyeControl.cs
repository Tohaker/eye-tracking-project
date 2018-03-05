using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleApp
{
    public partial class EyeControl : Form
    {
        private VehicleControl controller;

        public EyeControl(string com_port)
        {
            InitializeComponent();
            controller = new VehicleControl(com_port);
        }
    }
}
