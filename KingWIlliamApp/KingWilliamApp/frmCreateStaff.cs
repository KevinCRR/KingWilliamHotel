using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingWilliamApp
{
    public partial class frmCreateStaff : Form
    {
        public frmCreateStaff()
        {
            InitializeComponent();
        }

        private void frmCreateStaff_Load(object sender, EventArgs e)
        {
            DataTable dtAddresses = Address.GetProvinces();
            cbxProvince.DataSource = dtAddresses;
            cbxProvince.ValueMember = "provinceName";

            DataTable dtPositions = Staff.GetPositions();
            cbxPosition.ValueMember = "positionID";
            cbxPosition.DisplayMember = "positionTitle";
            cbxPosition.DataSource = dtPositions;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                Address newAddress = new Address(txtAddress1.Text.Trim(), txtAddress2.Text.Trim(), txtCity.Text.Trim(), cbxProvince.SelectedValue.ToString(), txtCountry.Text.Trim(), txtPostalCode.Text.Trim());
                Staff newStaff = new Staff(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), txtPhone.Text.Trim(), txtSalary.Text.Trim(), dateStart.Value, DateTime.Today.AddYears(-100), cbxPosition.SelectedValue.ToString(), newAddress.InsertAddress());
                newStaff.InsertStaff();

                MessageBox.Show("Staff created successfully!", "Success");
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

        private void cbxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtPositions = Staff.GetPositions();

            string search = "positionID = \'" + cbxPosition.SelectedValue + "\'";

            DataRow[] rows = dtPositions.Select(search);
            foreach (DataRow row in rows)
            {
                txtSalary.Text = Convert.ToDecimal(row[4]).ToString("#0.00");
            }
        }
    }
}
