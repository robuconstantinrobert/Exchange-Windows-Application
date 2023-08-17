using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW3
{
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
        }


        

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string username = tbUserName.Text;
            //string password = tbPassword.Text;

            if ((tbPassword != null) && (tbUserName != null))
            {
                Main form = new Main(this);
                form.Show();
            }

            //this.Hide();
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbUserName_Validating(object sender, CancelEventArgs e)
        {
            if (tbUserName.Text.Length < 3)
            {
                errorProviderLogin.SetError((Control)sender, "The username must be a string");
                e.Cancel = true;
            }
        }
        

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (tbPassword.Text.Length < 3)
            {
                errorProviderLogin.SetError((Control)sender, "The password must be a string");
                e.Cancel = true;
            }
        }

        private void tbUserName_Validated(object sender, EventArgs e)
        {
            errorProviderLogin.SetError((Control)sender, string.Empty);
        }

        private void tbPassword_Validated(object sender, EventArgs e)
        {
            errorProviderLogin.SetError((Control)sender, string.Empty);
        }

        private void checkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPassword.Checked)
            {
                tbPassword.UseSystemPasswordChar = true;
            }
            else 
            {
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void checkPassword_Enter(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
