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
    public partial class frmEditReservation : Form
    {
        public frmEditReservation()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if 
                (
                    (dateStart.Value != null) &&
                    (dateEnd.Value != null) &&
                    (cbxRoom.SelectedValue != null) &&
                    (nudGuests.Value >= 1) &&
                    (txtFirstName.Text.Trim() != "") &&
                    (txtLastName.Text.Trim() != "") &&
                    (txtPhone.Text.Trim() != "") &&
                    (txtPostalCode.Text.Trim() != "") &&
                    (txtAddress1.Text.Trim() != "") &&
                    (txtAddress2.Text.Trim() != "") &&
                    (txtCity.Text.Trim() != "") &&
                    (cbxProvince.SelectedValue != null) &&
                    (txtCountry.Text.Trim() != "")
                )
                {
                    Reservation newReservation = new Reservation(dateStart.Value, dateEnd.Value, (int)cbxRoom.SelectedValue,
                        (int)nudGuests.Value, txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtAddress1.Text,
                        txtAddress2.Text, txtCity.Text, (int)cbxProvince.SelectedValue, txtCountry.Text, 
                        txtPostalCode.Text, txtNotes.Text);

                    MessageBox.Show(newReservation.ReservationID.ToString());

                    if (newReservation.ReservationID != 0)
                    {
                        MessageBox.Show("Success - Reservation ID #" + newReservation.ReservationID.ToString());
                    }
                    else
                    {
                        MessageBox.Show("There was an error creating the reservation");
                    }    
                }
                else
                {
                    MessageBox.Show("Please fill in all fields!");
                }
            }
            catch (Exception) { }
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.connectionString);

            try
            {
                sqlcon.Open();

                SqlCommand sqlProvinces = new SqlCommand("SELECT (provinceCode) FROM tblProvinces", sqlcon);
                SqlDataReader readerProvinces;
                readerProvinces = sqlProvinces.ExecuteReader();
                DataTable dtProvinces = new DataTable();
                dtProvinces.Columns.Add("provinceCode", typeof(string));
                dtProvinces.Load(readerProvinces);
                cbxProvince.ValueMember = "provinceCode";
                cbxProvince.DataSource = dtProvinces;

                SqlCommand sqlRooms = new SqlCommand("SELECT (roomNumber) FROM tblRooms", sqlcon);
                SqlDataReader readerRooms;
                readerRooms = sqlRooms.ExecuteReader();
                DataTable dtRooms = new DataTable();
                dtRooms.Columns.Add("roomNumber", typeof(string));
                dtRooms.Load(readerRooms);
                cbxRoom.ValueMember = "roomNumber";
                cbxRoom.DataSource = dtRooms;

                sqlcon.Close();
            }
            catch (Exception) {}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
