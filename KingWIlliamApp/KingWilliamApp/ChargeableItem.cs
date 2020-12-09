using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class ChargeableItem
    {
        #region "Variable declarations"

        int itemID;
        string itemName;
        string itemDescription;
        decimal itemPrice;

        #endregion

        #region "Constructors"

        protected internal ChargeableItem(int itemIDValue, string itemNameValue, string itemDescriptionValue, decimal itemPriceValue)
        {
            this.ItemID = itemIDValue;
            this.ItemName = itemNameValue;
            this.ItemDescription = itemDescriptionValue;
            this.ItemPrice = itemPriceValue;
        }

        protected internal ChargeableItem()
        {

        }

        #endregion

        #region "Class methods"



        #endregion

        #region "Property Procedures"

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

        protected internal string ItemName
        {
            get
            {
                return itemName;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    itemName = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Item name is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    itemDescription = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Item description is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal decimal ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }

        #endregion
    }
}
