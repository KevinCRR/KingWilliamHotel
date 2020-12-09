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
    public partial class frmEditCustomer : Form
    {
        private Customer currentCustomer;
        private Address currentAddress;
        private int customerIDValue;

        public frmEditCustomer(int customerID)
        {
            InitializeComponent();

            customerIDValue = customerID;
        }

        private void frmEditCustomer_Load(object sender, EventArgs e)
        {
            // Try to get customer from database
            try
            {
                currentCustomer = Customer.GetCustomer(customerIDValue);
                currentAddress = Address.GetAddress(currentCustomer.AddressID);
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occured! Could not open \"Edit Customer\".", "Error");
                this.Close();
            }


            DataTable dt = Address.GetProvinces();

            cbxProvince.DataSource = dt;
            cbxProvince.ValueMember = "provinceName";

            int index = -1;
            string search = "provinceName = \'" + currentAddress.Province + "\'";

            DataRow[] rows = dt.Select(search);
            if (rows.Count() > 0)
                index = dt.Rows.IndexOf(rows[0]);

            cbxProvince.SelectedIndex = index;


            txtFirstName.Text = currentCustomer.FirstName;
            txtLastName.Text = currentCustomer.LastName;
            txtPhone.Text = currentCustomer.PhoneNumber;

            txtAddress1.Text = currentAddress.Address1;
            txtAddress2.Text = currentAddress.Address2;
            txtCity.Text = currentAddress.City;
            txtPostalCode.Text = currentAddress.PostalCode;
            txtCountry.Text = currentAddress.Country;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Customer updateCustomer = new Customer(currentCustomer.CustomerID, txtFirstName.Text.Trim(), txtLastName.Text.Trim(),
                    txtPhone.Text.Trim(), currentCustomer.AddressID);
                updateCustomer.UpdateCustomer();

                Address updateAddress = new Address(currentAddress.AddressID, txtAddress1.Text.Trim(), txtAddress2.Text.Trim(),
                    txtCity.Text.Trim(), cbxProvince.SelectedValue.ToString(), txtCountry.Text.Trim(), txtPostalCode.Text.Trim());
                updateAddress.UpdateAddress();

                MessageBox.Show("Customer updated successfully!", "Success");
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
