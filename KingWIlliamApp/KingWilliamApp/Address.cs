using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class Address
    {

        #region "Variable declarations"

        int addressID = 0;
        string address1;
        string address2;
        string city;
        int province;
        string country;
        string postalCode;

        #endregion

        #region "Constructors"

        protected internal Address(string address1Value, string address2Value, string cityValue, 
            int provinceValue, string countryValue, string postalCodeValue)
        {
            this.Address1 = address1Value;
            this.Address2 = address2Value;
            this.City = cityValue;
            this.PostalCode = postalCodeValue;
            this.Country = countryValue;
            this.PostalCode = postalCodeValue;

            addressID = DBL.InsertNewAddress(this);
        }

        protected internal Address()
        {

        }

        #endregion

        #region "Class methods"



        #endregion

        #region "Property Procedures"

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

        protected internal int AddressID
        {
            get
            {
                return addressID;
            }
        }

        #endregion
    }
}
