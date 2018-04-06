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
    public partial class PasswordDialog : Form
    {
        public PasswordDialog()
        {
            InitializeComponent();
            txtPassword.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "uondev")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Invalid Password.");
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnOK_Click(this, new EventArgs());
        }
    }
}
