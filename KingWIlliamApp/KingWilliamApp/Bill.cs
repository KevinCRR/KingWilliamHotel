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
            billAmount = 0;
            paymentType = "Undefined";
            amountOwing = 0;

            billID = DBL.InsertNewBill(this);
        }

        #endregion

        #region "Class methods"



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
