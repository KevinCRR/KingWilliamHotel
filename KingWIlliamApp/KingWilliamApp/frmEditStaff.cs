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
    public partial class frmEditStaff : Form
    {
        private Staff CurrentStaff;
        private Address CurrentAddress;

        public frmEditStaff(Staff editStaff)
        {
            InitializeComponent();
            CurrentStaff = editStaff;
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            // Try to get staff from database
            try
            {
                CurrentAddress = Address.GetAddress(CurrentStaff.AddressID);

                DataTable dtAddresses = Address.GetProvinces();
                cbxProvince.DataSource = dtAddresses;
                cbxProvince.ValueMember = "provinceName";

                DataTable dtPositions = Staff.GetPositions();
                cbxPosition.ValueMember = "positionID";
                cbxPosition.DisplayMember = "positionTitle";
                cbxPosition.DataSource = dtPositions;

                int index = -1;
                string search = "positionID = \'" + CurrentStaff.PositionID + "\'";

                DataRow[] rows = dtPositions.Select(search);
                if (rows.Count() > 0)
                    index = dtPositions.Rows.IndexOf(rows[0]);

                cbxPosition.SelectedIndex = index;


                txtFirstName.Text = CurrentStaff.FirstName;
                txtLastName.Text = CurrentStaff.LastName;
                txtPhone.Text = CurrentStaff.PhoneNumber;
                txtSalary.Text = CurrentStaff.Salary;
                dateStart.Value = CurrentStaff.HiredDate;

                dateTermination.Value = CurrentStaff.TerminationDate;
                if (CurrentStaff.TerminationDate < CurrentStaff.HiredDate)
                {
                    dateTermination.Checked = false;
                }
                
                

                txtAddress1.Text = CurrentAddress.Address1;
                txtAddress2.Text = CurrentAddress.Address2;
                txtCity.Text = CurrentAddress.City;
                txtPostalCode.Text = CurrentAddress.PostalCode;
                txtCountry.Text = CurrentAddress.Country;
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occured! Could not open \"Edit Staff\".", "Error");
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                lblMessage.Text = "";

                CurrentStaff.FirstName = txtFirstName.Text.Trim();
                CurrentStaff.LastName = txtLastName.Text.Trim();
                CurrentStaff.PhoneNumber = txtPhone.Text.Trim();
                CurrentStaff.PositionID = cbxPosition.SelectedValue.ToString();
                CurrentStaff.Salary = txtSalary.Text.Trim();
                CurrentStaff.HiredDate = dateStart.Value;

                if (dateTermination.Checked == true)
                    CurrentStaff.TerminationDate = dateTermination.Value;

                CurrentStaff.UpdateStaff();

                CurrentAddress.Address1 = txtAddress1.Text.Trim();
                CurrentAddress.Address2 = txtAddress2.Text.Trim();
                CurrentAddress.City = txtCity.Text.Trim();
                CurrentAddress.Province = cbxProvince.SelectedValue.ToString();
                CurrentAddress.Country = txtCountry.Text.Trim();
                CurrentAddress.PostalCode = txtPostalCode.Text.Trim();
                CurrentAddress.UpdateAddress();

                MessageBox.Show("Staff updated successfully!", "Success");
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
