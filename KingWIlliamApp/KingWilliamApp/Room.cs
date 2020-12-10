using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class Room
    {
        #region "Variable declarations"

        int roomNumber;
        string roomID;
        double pricePerNight;
        string statusID;
        string notes;

        #endregion

        #region "Constructors"

        protected internal Room(string roomNumberValue, string roomIDValue, string pricePerNightValue, 
            string statusIDValue, string notesValue)
        {
            this.RoomNumber = roomNumberValue;
            this.RoomID = roomIDValue;
            this.PricePerNight = pricePerNightValue;
            this.StatusID = statusIDValue;
            this.Notes = notesValue;
        }

        protected internal Room()
        {

        }

        #endregion

        #region "Class methods"

        protected internal static DataTable GetAllRooms()
        {
            return DBL.SelectAllRooms();
        }

        protected internal static decimal GetRoomPrice(int roomNumber)
        {
            return DBL.SelectRoomPrice(roomNumber);
        }

        protected internal static void UpdateStatus(int roomNumber, string status)
        {
            DBL.UpdateRoomStatus(roomNumber, status);
        }

        #endregion

        #region "Property Procedures"

        protected internal string RoomNumber
        {
            get
            {
                return roomNumber.ToString();
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!int.TryParse(value, out roomNumber))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Room number must be a whole number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Room number is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string RoomID
        {
            get
            {
                return roomID;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    roomID = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Room ID is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string PricePerNight
        {
            get
            {
                return pricePerNight.ToString();
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!double.TryParse(value, out pricePerNight))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Price per night must be a number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Price per night is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string StatusID
        {
            get
            {
                return statusID;
            }
            set
            {
                statusID = value;
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
