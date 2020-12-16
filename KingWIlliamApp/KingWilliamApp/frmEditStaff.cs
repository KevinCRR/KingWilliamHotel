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
                dateStart.Value = CurrentStaff.HiredDate;
                dateTermination.Value = CurrentStaff.TerminationDate;
                txtSalary.Text = CurrentStaff.Salary.ToString();

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

        }
    }
}
