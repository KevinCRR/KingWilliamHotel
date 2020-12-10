using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User currentUser = null;
            lblMessage.Text = "";

            try
            {
                currentUser = User.GetUser(txtCurrentUsername.Text.Trim(), txtCurrentPassword.Text.Trim());
            }
            catch (ArgumentNullException ex)
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
            finally
            {
                if (lblMessage.Text == "" && currentUser != null)
                {
                    // Current User Exists
                    if (currentUser.RoleID == "Admin")
                    {
                        try
                        {
                            lblMessage.Text = "";

                            if (User.DeleteUser(txtUsername.Text.Trim(), txtStaffID.Text.Trim()))
                                lblMessage.Text = "User deleted successfully!";
                        }
                        catch (ArgumentNullException ex)
                        {
                            lblMessage.Text = "No entry! " + ex.Message;
                        }
                        catch (ArgumentOutOfRangeException ex)
                        {
                            lblMessage.Text = "Entry out-of-range! " + ex.Message;
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
                    else
                    {
                        lblMessage.Text = "You are not permitted to permorm this action!";
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
