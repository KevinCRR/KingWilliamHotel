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
    public partial class frmCreateCustomer : Form
    {
        public frmCreateCustomer()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Address newAddress = new Address(txtAddress1.Text.Trim(), txtAddress2.Text.Trim(), txtCity.Text.Trim(), (int)cbxProvince.SelectedValue, txtCountry.Text.Trim(), txtPostalCode.Text.Trim());
                Customer newCustomer = new Customer(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtPhone.Text.Trim(), newAddress.InsertAddress());
                newCustomer.InsertCustomer();

                frmCreateReservation formCreateReservation = new frmCreateReservation(newCustomer.CustomerID);
                formCreateReservation.ShowDialog();
            }
            catch (ArgumentNullException ex)
            {
                lblMessage.Text = ex.ParamName;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMessage.Text = ex.ParamName;
            }
            catch (ArgumentException ex)
            {
                lblMessage.Text = ex.ParamName;
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

        private void btnExistingCustomer_Click(object sender, EventArgs e)
        {
            frmViewReservations.OpenFormAsDialog(new frmFindCustomer());
            this.Close();
        }

        private void frmCreateCustomer_Load(object sender, EventArgs e)
        {
            cbxProvince.ValueMember = "provinceCode";
            cbxProvince.DataSource = Address.GetProvinces();
        }
    }
}
