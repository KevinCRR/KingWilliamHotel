using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    public class Reservation
    {

        #region "Variable declarations"

        int reservationID;
        DateTime startDate;
        DateTime endDate;
        int roomNumber;
        int numberOfGuests;
        string notes;
        int customerID;
        int billID;

        #endregion

        #region "Constructors"

        protected internal Reservation(DateTime startDateValue, DateTime endDateValue, 
            int roomNumberValue, int numberOfGuestsValue, string notesValue, int customerIDValue)
        {
            this.StartDate = startDateValue;
            this.EndDate = endDateValue;
            this.RoomNumber = roomNumberValue;
            this.NumberOfGuests = numberOfGuestsValue;
            this.Notes = notesValue;
            this.CustomerID = customerIDValue;
        }

        protected internal Reservation(int reservationIDValue, DateTime startDateValue, DateTime endDateValue,
            int roomNumberValue, int numberOfGuestsValue, string notesValue, int customerIDValue, int billIDValue)
        {
            this.ReservationID = reservationIDValue;
            this.StartDate = startDateValue;
            this.EndDate = endDateValue;
            this.RoomNumber = roomNumberValue;
            this.NumberOfGuests = numberOfGuestsValue;
            this.Notes = notesValue;
            this.CustomerID = customerIDValue;
            this.BillID = billIDValue;
        }

        protected internal Reservation()
        {
            
        }

        #endregion

        #region "Class methods"

        
        public static List<Reservation> GetAll(DateTime fromDate)
        {
            return DBL.SelectAllReservations(fromDate);
        }

        protected internal void InsertReservation()
        {
            if (this.BillID == 0)
            {
                Bill newBill = new Bill();
                newBill.InsertBill();
                this.BillID = newBill.BillID;
            }

            this.ReservationID = DBL.InsertNewReservation(this);
        }

        protected internal bool DeleteReservation()
        {
            return DBL.DeleteReservation(this.ReservationID);
        }

        #endregion

        #region "Property Procedures"

        protected internal int ReservationID
        {
            get
            {
                return reservationID;
            }
            set
            {
                reservationID = value;
            }
        }

        protected internal DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                startDate = value;
            }
        }

        protected internal DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;

                //if (value > startDate)
                //{
                //    endDate = value;
                //}
                //else
                //{
                //    ArgumentException ex = new ArgumentException("Reservation 'End Date' must be later than the start date!", "reservation");
                //    throw ex;
                //}
            }
        }

        protected internal int RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }

        protected internal int NumberOfGuests
        {
            get
            {
                return numberOfGuests;
            }
            set
            {
                if (value >= 1)
                {
                    numberOfGuests = value;
                }
                else
                {
                    ArgumentException ex = new ArgumentException("Reservation 'Number of Guests' must be at least 1!", "reservation");
                    throw ex;
                }
            }
        }

        protected internal int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        protected internal int BillID
        {
            get
            {
                return billID;
            }
            set
            {
                billID = value;
            }
        }

        protected internal string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }

        #endregion

    }
}
