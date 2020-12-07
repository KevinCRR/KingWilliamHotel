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

        protected internal Bill()
        {
            this.BillAmount = 0;
            this.PaymentType = "Undefined";
            this.AmountOwing = 0;
        }

        #endregion

        #region "Class methods"

        protected internal void InsertBill()
        {
            this.BillID = DBL.InsertNewBill(this);
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

        protected internal double BillAmount
        {
            get
            {
                return billAmount;
            }
            set
            {
                billAmount = value;
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
                paymentType = value;
            }
        }

        protected internal double AmountOwing
        {
            get
            {
                return amountOwing;
            }
            set
            {
                amountOwing = value;
            }
        }

        #endregion
    }
}
