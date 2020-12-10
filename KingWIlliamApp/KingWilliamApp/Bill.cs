using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    public class Bill
    {
        #region "Variable declarations"

        int billID;
        double billAmount;
        string paymentType;
        double amountOwing;

        #endregion

        #region "Constructors"

        protected internal Bill(int billIDValue, string billAmountValue, string paymentTypeValue, string amountOwingValue)
        {
            this.BillID = billIDValue;
            this.BillAmount = billAmountValue;
            this.PaymentType = paymentTypeValue;
            this.AmountOwing = amountOwingValue;
        }

        protected internal Bill()
        {
            this.BillAmount = "0";
            this.PaymentType = "Undefined";
            this.AmountOwing = "0";
        }

        #endregion

        #region "Class methods"

        protected internal void InsertBill(decimal price)
        {
            this.BillID = DBL.InsertNewBill(this,price);
        }

        protected internal static Bill GetBill(int billIDValue)
        {
            return DBL.SelectBill(billIDValue);
        }

        protected internal void UpdateBill()
        {
            DBL.UpdateBill(this);
        }

        #endregion

        #region "Property Procedures"

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

        protected internal string BillAmount
        {
            get
            {
                return billAmount.ToString();
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!double.TryParse(value, out billAmount))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Bill amoount must be a number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Bill amount is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string PaymentType
        {
            get
            {
                return paymentType;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    paymentType = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Payment type is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string BillDate
        {
            get
            {
                return paymentType;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    paymentType = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Payment type is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string AmountOwing
        {
            get
            {
                return amountOwing.ToString();
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!double.TryParse(value, out amountOwing))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Amount owing must be a number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Amount owing is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        #endregion
    }
}
