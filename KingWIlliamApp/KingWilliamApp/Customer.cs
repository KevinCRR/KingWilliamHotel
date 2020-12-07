﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    public class Customer
    {

        #region "Variable declarations"

        int customerID = 0;
        string firstName;
        string lastName;
        string phoneNumber;
        int addressID;

        #endregion

        #region "Constructors"

        protected internal Customer(string firstNameValue, string lastNameValue, string phoneNumberValue, int addressIDValue)
        {
            this.FirstName = firstNameValue;
            this.LastName = lastNameValue;
            this.PhoneNumber = phoneNumberValue;
            this.AddressID = addressIDValue;
        }

        protected internal Customer()
        {

        }

        #endregion

        #region "Class methods"

        protected internal void InsertCustomer()
        {
            this.CustomerID = DBL.InsertNewCustomer(this);
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

        #endregion

    }
}
