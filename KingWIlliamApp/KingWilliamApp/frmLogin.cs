using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KingWilliamApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsLoggedIn { get; set; }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                User.CurrentUser = User.GetUser(username, password);

                if (User.CurrentUser.Username != null)
                {
                    this.Close();
                    IsLoggedIn = true;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password! Try again or contact an administrator.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password.");
            }
        }
    }
}
