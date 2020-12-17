using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmCreateUsers : Form
    {
        public frmCreateUsers()
        {
            InitializeComponent();
        }

        private void frmCreateUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = User.GetRoles();
            cbxRoles.ValueMember = "roleID";
            cbxRoles.DisplayMember = "roleTitle";
            cbxRoles.DataSource = dt;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                User newUser = new User(txtUsername.Text.Trim(), txtPassword.Text.Trim(), cbxRoles.SelectedValue.ToString(), txtStaffID.Text.Trim());
                newUser.InsertUser();

                MessageBox.Show("User created successfully!", "Success");
                this.Close();
            }
            catch (ArgumentNullException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMessage.Text = ex.Message;
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = ex.Message;
            }
            // Respond to DataExceptions referencing the database and the inner exception thrown during the database operation
            catch (DataException ex)
            {
                lblMessage.Text = "Database error! " + ex.Message + "\n\n" +
                    ex.InnerException.Message + "\n\n" + ex.Source + "\n\n" + ex.Message +
                    "\n\n" + ex.StackTrace;
            }
            // Catch other unanticipated exceptions and provide as much debugging info as possible.
            catch (Exception ex)
            {
                lblMessage.Text = "An unknown error has occurred in " + ex.Source + "! Please contact your IT department and provide the following details:\n\n" + ex.Message + "\n\n" + ex.StackTrace + "\n\nUnknown Error!";
            }
        }
    }
}
