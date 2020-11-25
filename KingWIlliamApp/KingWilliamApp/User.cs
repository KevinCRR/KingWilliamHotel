using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    class User
    {
        #region "Variable declarations"

        int userID = 0;
        string username;
        string password;
        int staffID = 0;
        int roleID = 0;

        #endregion

        #region "Constructors"

        protected internal User(int userIDValue, string usernameValue, string passwordValue, int staffIDValue, int roleIDValue)
        {
            this.UserID = userIDValue;
            this.Username = usernameValue;
            this.Password = passwordValue;
            this.StaffID = staffIDValue;
            this.RoleID = roleIDValue;

            //DBL.InsertNewUser(this);
        }

        protected internal User()
        {

        }

        #endregion
         
        #region "Class methods"

        protected internal static User GetUser(string usernameValue, string passwordValue)
        {
            User returnUser = new User();
            returnUser = DBL.SelectUser(usernameValue, passwordValue);

            return returnUser;
        }

        #endregion

        #region "Property Procedures"

        protected internal string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    username = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Username is required", "user");
                    throw ex;
                }
            }
        }

        protected internal string Password
        {
            get
            {
                return password;
            }
            set
            {
                if (!(value == string.Empty))
                {
                    password = value;
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentException ex = new ArgumentException("Password is required", "reservation");
                    throw ex;
                }
            }
        }

        protected internal int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

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

        protected internal int RoleID
        {
            get
            {
                return roleID;
            }
            set
            {
                roleID = value;
            }
        }

        #endregion

    }
}
