using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class Staff
    {
        #region "Variable declarations"

        int staffID = 0;
        string firstName;
        string lastName;
        string phoneNumber;
        double salary;
        DateTime hiredDate;
        DateTime terminationDate;
        string image;
        int positionID = 0;
        int addressID = 0;

        #endregion

        #region "Constructors"

        protected internal Staff(int staffIDValue, string firstNameValue, string lastNameValue, string phoneNumberValue,
            double salaryValue, DateTime hiredDateValue, DateTime terminationDateValue, string imageValue,
            int positionIDValue, int addressIDValue)
        {
            this.FirstName = firstNameValue;
            this.LastName = lastNameValue;
            this.PhoneNumber = phoneNumberValue;
        }

        protected internal Staff()
        {

        }

        #endregion

        #region "Class methods"

        protected internal static Staff GetStaff(int staffIDValue)
        {
            return DBL.SelectStaff(staffIDValue);
        }

        #endregion

        #region "Property Procedures"

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

        protected internal int AddressID
        {
            get
            {
                return addressID;
            }
            set
            {
                addressID = value;
            }
        }

        #endregion
    }
}
