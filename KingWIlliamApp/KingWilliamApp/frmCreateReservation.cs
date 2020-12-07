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
    public partial class frmCreateReservation : Form
    {
        int customerID;

        public frmCreateReservation(int useCustomer)
        {
            InitializeComponent();
            customerID = useCustomer;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Error = null;
            DateTime thisDay = DateTime.Today;
            bool Booked = false;

            try
            {
                if (dateStart.Value < thisDay)
                {
                    Error = string.Concat("Start date cannot be before today's date!\n");
                }

                if (dateEnd.Value < dateStart.Value)
                {
                    Error = string.Concat("The end-date cannot be before start date!\n");
                }

                //if (txtFirstName.Text.Trim() != "")
                //{
                //    Error = string.Concat("First Name field Cannot be empty!\n");
                //}
                //else if (txtFirstName.Text.Trim().Any(char.IsDigit))
                //{
                //    Error = string.Concat("First Name field Cannot contain a number!\n");
                //}

                //if (txtLastName.Text.Trim() != "")
                //{
                //    Error = string.Concat("Last Name field Cannot be empty!\n");
                //}
                //else if (txtLastName.Text.Trim().Any(char.IsDigit))
                //{
                //    Error = string.Concat("Last Name field Cannot contain a number!\n");
                //}

                //if (txtPhone.Text.Trim() != "")
                //{
                //    Error = string.Concat("Last Name field Cannot contain a number!\n");
                //}

                if (Error == null)
                {
                    SqlConnection sqlcon = new SqlConnection(Properties.Settings.Default.connectionString);

                    sqlcon.Open();


                    string oString = "SELECT * FROM reservations WHERE roomNumber = " + cbxRoom.SelectedValue
                        + " AND dateEnd.Value < \'" + dateStart.Value + "\';";
                    SqlCommand sqlDA = new SqlCommand(oString, sqlcon);
                    SqlDataReader dr = sqlDA.ExecuteReader();

                    if (dr.Read())
                    {
                        Error = string.Concat("Booking Cannot be made for this date, Select another room or date!\n");
                        Booked = true;
                    }
                }



                // SELECT * FROM RESERVATION WHERE roomNumber = this.roomNumber AND endDate < this.startDate.Value;
                // if return 0 then room won't be occupied but if return > 0 then room will be occupied. 
                if (dateStart.Value < dateStart.Value)
                {
                    Error = string.Concat("The end-date cannot be before start date!\n");
                }



                if
                (
                    (dateStart.Value != null) &&
                    (dateEnd.Value != null) &&
                    (cbxRoom.SelectedValue != null) &&
                    (nudGuests.Value >= 1)
                )
                {
                    Reservation newReservation = null;
                    //Reservation newReservation = new Reservation(1,dateStart.Value, dateEnd.Value, (int)cbxRoom.SelectedValue,
                    //    (int)nudGuests.Value, txtNotes.Text);

                    //txtFirstName.Text, txtLastName.Text, txtPhone.Text, txtAddress1.Text,
                    //    txtAddress2.Text, txtCity.Text, (int)cbxProvince.SelectedValue, txtCountry.Text,
                    //    txtPostalCode.Text,

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

                SqlCommand sqlProvinces = new SqlCommand("SELECT (provinceCode) FROM provinces", sqlcon);
                SqlDataReader readerProvinces;
                readerProvinces = sqlProvinces.ExecuteReader();
                DataTable dtProvinces = new DataTable();
                dtProvinces.Columns.Add("provinceCode", typeof(string));
                dtProvinces.Load(readerProvinces);
                //cbxProvince.ValueMember = "provinceCode";
                //cbxProvince.DataSource = dtProvinces;

                SqlCommand sqlRooms = new SqlCommand("SELECT (roomNumber) FROM rooms", sqlcon);
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
