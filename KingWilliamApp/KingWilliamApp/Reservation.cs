using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class Reservation
    {

        #region "Variable declarations"

        DateTime startDate;
        DateTime endDate;
        int roomNumber;
        int numberOfGuests;
        string firstName;
        string lastName;
        string phoneNumber;
        string address1;
        string address2;
        string city;
        int province;
        string country;
        string postalCode;
        string notes;

        #endregion

        #region "Constructors"

        protected internal Reservation(DateTime startDateValue, DateTime endDateValue, int roomNumberValue, 
            int numberOfGuestsValue, string firstNameValue, string lastNameValue, string phoneNumberValue, 
            string address1Value, string address2Value, string cityValue, int provinceValue, string countryValue, 
            string postalCodeValue, string notesValue)
        {
            this.StartDate = startDateValue;
            this.EndDate = endDateValue;
            this.RoomNumber = roomNumberValue;
            this.NumberOfGuests = numberOfGuestsValue;
            this.FirstName = firstNameValue;
            this.LastName = lastNameValue;
            this.PhoneNumber = phoneNumberValue;
            this.Address1 = address1Value;
            this.Address2 = address2Value;
            this.City = cityValue;
            this.PostalCode = postalCodeValue;
            this.Country = countryValue;
            this.PostalCode = postalCodeValue;
            this.Notes = notesValue;

            DBL.InsertNewReservation(this);
        }

        protected internal Reservation()
        {
            
        }

        #endregion

        #region "Class methods"



        #endregion

        #region "Property Procedures"

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
                if (value > startDate)
                {
                    endDate = value;
                }
                else
                {
                    ArgumentException ex = new ArgumentException("Reservation 'End Date' must be later than the start date!", "reservation");
                    throw ex;
                }
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

        protected internal string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    firstName = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("First name is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    lastName = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Last name is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    phoneNumber = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Phone number is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal string Address1
        {
            get
            {
                return address1;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    address1 = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Address Line 1 is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }

        protected internal string City
        {
            get
            {
                return city;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    city = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("City is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal int Province
        {
            get
            {
                return province;
            }
            set
            {
                province = value;
            }
        }

        protected internal string Country
        {
            get
            {
                return country;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    country = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Country is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    postalCode = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Postal code is required", "reservation");
                    throw ex;
                }
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
