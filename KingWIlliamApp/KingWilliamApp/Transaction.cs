using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class Transaction
    {
        #region "Variable declarations"

        int transactionID;
        int billID;
        int itemID;
        int amountOfItems;
        DateTime date;

        ChargeableItem chargeableItem;

        #endregion

        #region "Constructors"

        protected internal Transaction(int transactionIDValue, int billIDValue, int itemIDValue, 
            int amountOfItemsValue, DateTime dateValue)
        {
            this.TransactionID = transactionIDValue;
            this.BillID = billIDValue;
            this.ItemID = itemIDValue;
            this.AmountOfItems = amountOfItemsValue;
            this.Date = dateValue;
        }

        protected internal Transaction()
        {
            
        }

        #endregion

        #region "Class methods"

        protected internal static List<Transaction> GetAllTransactions(int billID)
        {
            return DBL.SelectAllTransactions(billID);
        }

        protected internal bool DeleteTransaction()
        {
            return DBL.DeleteTransaction(this.TransactionID);
        }

        #endregion

        #region "Property Procedures"

        protected internal int TransactionID
        {
            get
            {
                return transactionID;
            }
            set
            {
                transactionID = value;
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

        protected internal int ItemID
        {
            get
            {
                return itemID;
            }
            set
            {
                itemID = value;
            }
        }

        protected internal int AmountOfItems
        {
            get
            {
                return amountOfItems;
            }
            set
            {
                if (value >= 1)
                {
                    amountOfItems = value;
                }
                else
                {
                    ArgumentException ex = new ArgumentException("Transaction 'Amount Of Items' must be at least 1!", "Value Not Allowed");
                    throw ex;
                }
            }
        }

        protected internal DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

        protected internal ChargeableItem ChargeableItem
        {
            get
            {
                return chargeableItem;
            }
            set
            {
                chargeableItem = value;
            }
        }

        #endregion
    }
}
