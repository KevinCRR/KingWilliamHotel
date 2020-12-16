using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    public class Staff
    {
        #region "Variable declarations"

        int staffID = 0;
        string firstName;
        string lastName;
        string phoneNumber;
        decimal salary;
        DateTime hiredDate;
        DateTime terminationDate;
        //string image;
        string positionID;
        int addressID = 0;

        #endregion

        #region "Constructors"

        protected internal Staff(int staffIDValue, string firstNameValue, string lastNameValue, string phoneNumberValue,
            decimal salaryValue, DateTime hiredDateValue, DateTime terminationDateValue,
            string positionIDValue, int addressIDValue)
        {
            this.StaffID = staffIDValue;
            this.FirstName = firstNameValue;
            this.LastName = lastNameValue;
            this.PhoneNumber = phoneNumberValue;
            this.Salary = salaryValue.ToString();
            this.HiredDate = hiredDateValue;
            this.TerminationDate = terminationDateValue;
            this.PositionID = positionIDValue;
            this.AddressID = addressIDValue;
        }

        protected internal Staff(string firstNameValue, string lastNameValue, string phoneNumberValue,
            string salaryValue, DateTime hiredDateValue, DateTime terminationDateValue,
            string positionIDValue, int addressIDValue)
        {
            this.FirstName = firstNameValue;
            this.LastName = lastNameValue;
            this.PhoneNumber = phoneNumberValue;
            this.Salary = salaryValue;
            this.HiredDate = hiredDateValue;
            this.TerminationDate = terminationDateValue;
            this.PositionID = positionIDValue;
            this.AddressID = addressIDValue;
        }

        protected internal Staff()
        {

        }

        #endregion

        #region "Class methods"

        protected internal static List<Staff> GetAll()
        {
            return DBL.SelectAllStaff();
        }

        protected internal void InsertStaff()
        {
            this.StaffID = DBL.InsertNewStaff(this);
        }

        protected internal void UpdateStaff()
        {
            DBL.UpdateStaff(this);
        }

        protected internal bool DeleteStaff()
        {
            return DBL.DeleteStaff(this.StaffID);
        }

        protected internal static DataTable GetPositions()
        {
            return DBL.SelectAllPositions();
        }

        #endregion

        #region "Property Procedures"

        protected internal int StaffID
        {
            get
            {
                return staffID;
            }
            set
            {
                staffID = value;
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

        protected internal string PositionID
        {
            get
            {
                return positionID;
            }
            set
            {
                positionID = value;
            }
        }

        protected internal string Salary
        {
            get
            {
                return salary.ToString("#,0.00");
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!decimal.TryParse(value, out salary))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Salary must be a number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Salary is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal DateTime HiredDate
        {
            get
            {
                return hiredDate;
            }
            set
            {
                hiredDate = value;
            }
        }

        protected internal DateTime TerminationDate
        {
            get
            {
                return terminationDate;
            }
            set
            {
                terminationDate = value;
            }
        }

        #endregion
    }
}
