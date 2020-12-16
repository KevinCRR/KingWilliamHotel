﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Threading;

namespace KingWilliamApp
{
    public partial class frmCreateReservation : Form
    {
        private Customer UseCustomer;

        public frmCreateReservation(Customer useCustomer)
        {
            InitializeComponent();
            UseCustomer = useCustomer;
        }

        private void frmCreateReservation_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = UseCustomer.FirstName + " " + UseCustomer.LastName;

            //dateStart.Value = DateTime.Today;
            //dateEnd.Value = DateTime.Today.AddDays(1);

            try
            {
                string pastRoomsMessage = "";
                List<String> pastRooms = UseCustomer.GetPastRooms();

                if (pastRooms.Count > 1)
                {
                    pastRoomsMessage = "This customer previously stayed in rooms:  ";

                    foreach (string p in pastRooms)
                    {
                        pastRoomsMessage = pastRoomsMessage + p + "  ";
                    }
                }

                lblPastRooms.Text = pastRoomsMessage;
            }
            catch (Exception)
            {
                lblPastRooms.Text = "";
            }

            cbxRoom.ValueMember = "roomNumber";
            cbxRoom.DataSource = Room.GetAllRooms();

            ShowRoomPrice();
        }

        private void cbxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowRoomPrice();
        }
        private void RecommendedPrice(String startDate)
        {

            int roomsLeft;
            double recommendedPrice;
            //String DS = dateStart.Text;
            DateTime dateS = DateTime.ParseExact(startDate, "dddd, MMMM d, yyyy", CultureInfo.InvariantCulture);
            var newDate = dateS.AddYears(-1);
            //var currentDate = dateS.AddYears(1);
            Reservation reservationRecommendation = new Reservation(newDate, dateEnd.Value, int.Parse(cbxRoom.SelectedValue.ToString()), int.Parse(nudGuests.Value.ToString()), txtNotes.Text.Trim(), UseCustomer.CustomerID);
            int countedRooms = reservationRecommendation.reservationCount(newDate);
            int selectedRoom = int.Parse(cbxRoom.SelectedValue.ToString());
            double roomPrice = Double.Parse(Room.GetRoomPrice(selectedRoom).ToString());
            roomsLeft = 41 - countedRooms;
            recommendedPrice = (roomPrice - ((roomPrice / 10.0) * ((roomsLeft) / 41) * (250.00 / 41)) + (roomPrice * (41 / 100.00)));
            //reservationRecommendation = null;
            //roomsLeft.Equals(null);
            //countedRooms.Equals(null);
            //selectedRoom.Equals(null);
            lblRP.Text = recommendedPrice.ToString("#,0.00");
        }

        private void ShowRoomPrice()
        {
            RecommendedPrice(dateStart.Text);
            int selectedRoom = int.Parse(cbxRoom.SelectedValue.ToString());
            try
            {
                txtCost.Text = Room.GetRoomPrice(selectedRoom).ToString("#,0.00");
                if (selectedRoom == 201 | selectedRoom == 202 | selectedRoom == 203 | selectedRoom == 204 | selectedRoom == 205 | selectedRoom == 206 | selectedRoom == 207 | selectedRoom == 208 | selectedRoom == 209 | selectedRoom == 210 | selectedRoom == 211 | selectedRoom == 212 | selectedRoom == 213 | selectedRoom == 301 | selectedRoom == 302)
                {
                    nudGuests.Maximum = 2;
                }else if (selectedRoom == 303 | selectedRoom == 304 | selectedRoom == 305 | selectedRoom == 306 | selectedRoom == 307 | selectedRoom == 308 | selectedRoom == 309 | selectedRoom == 310 | selectedRoom == 311 | selectedRoom == 312 | selectedRoom == 313 | selectedRoom == 401 | selectedRoom == 402 | selectedRoom == 403 | selectedRoom == 404 | selectedRoom == 405 | selectedRoom == 406 | selectedRoom == 407 | selectedRoom == 408 | selectedRoom == 409 | selectedRoom == 410 | selectedRoom == 411)
                {
                    nudGuests.Maximum = 4;
                }else if(selectedRoom == 501)
                {
                    nudGuests.Maximum = 4;
                }
                else if (selectedRoom == 502)
                {
                    nudGuests.Maximum = 4;
                }
                else if (selectedRoom == 503)
                {
                    nudGuests.Maximum = 4;
                }
                else if (selectedRoom == 504)
                {
                    nudGuests.Maximum = 4;
                }
            }
            catch (Exception)
            {
                txtCost.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            decimal number;
            try
            {
                lblMessage.Text = "";


                if (Decimal.TryParse(txtCost.Text, out number))
                {
                    Reservation newReservation = new Reservation(dateStart.Value, dateEnd.Value, int.Parse(cbxRoom.SelectedValue.ToString()), int.Parse(nudGuests.Value.ToString()), txtNotes.Text.Trim(), UseCustomer.CustomerID);
                    newReservation.InsertReservation(number);

                    MessageBox.Show("Reservation created successfully!", "Success");
                    this.Close();
                }
                else
                {
                    throw new System.ArgumentException("Room Price must be a number!");
                }
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

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateStart_ValueChanged(object sender, EventArgs e)
        {
            RecommendedPrice(dateStart.Text);
        }
    }
}
