using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KingWilliamApp
{
    public class User
    {
        #region "Variable declarations"

        private string username;
        private string password;
        private int staffID = 0;
        private string roleID;
        private string roleName;
        public string roleNamePublic;

        #endregion

        #region "Constructors"

        protected internal User(string usernameValue, string passwordValue, string roleIDValue, string staffIDValue)
        {
            this.Username = usernameValue;
            this.Password = passwordValue;
            this.RoleID = roleIDValue;
            this.StaffID = staffIDValue;
        }

        protected internal User()
        {

        }

        #endregion
         
        #region "Class methods"

        protected internal static User GetUser(string usernameValue, string passwordValue)
        {
            bool passed = true;
            User returnUser = null;

            if (usernameValue == string.Empty)
            {
                passed = false;
                // If it is blank, declare and throw an exception
                ArgumentNullException ex = new ArgumentNullException("Username is required", "Missing Fields");
                throw ex;
            }
            if (passwordValue == string.Empty)
            {
                passed = false;
                // If it is blank, declare and throw an exception
                ArgumentNullException ex = new ArgumentNullException("Password is required", "Missing Fields");
                throw ex;
            }

            if (passed == true)
                returnUser = DBL.SelectUser(usernameValue, passwordValue);

            return returnUser;
        }

        protected internal static bool DeleteUser(string usernameValue, string staffIDValue)
        {
            bool passed = true;
            bool returnValue = false;
            int valStaffID;

            if (usernameValue == string.Empty)
            {
                passed = false;
                // If it is blank, declare and throw an exception
                ArgumentNullException ex = new ArgumentNullException("Username is required", "Missing Fields");
                throw ex;
            }
            if (!(staffIDValue == string.Empty))
            {
                if (!int.TryParse(staffIDValue, out valStaffID))
                {
                    passed = false;
                    ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Staff ID must be a whole number", "Incorrect Format");
                    throw ex;
                }
            }
            else
            {
                passed = false;
                // If it is blank, declare and throw an exception
                ArgumentNullException ex = new ArgumentNullException("Staff ID is required", "Missing Fields");
                throw ex;
            }

            if (passed == true)
                returnValue = DBL.DeleteUser(usernameValue, valStaffID);

            return returnValue;
        }


        protected internal static string GetRole(string roleIDValue)
        {
            return DBL.SelectRoleTitle(roleIDValue);
        }

        protected internal void InsertUser()
        {
            DBL.InsertNewUser(this);
        }


        #endregion

        #region "Property Procedures"

        public static User CurrentUser { get; set; }

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
                    ArgumentNullException ex = new ArgumentNullException("Username is required", "Missing Fields");
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
                    ArgumentNullException ex = new ArgumentNullException("Password is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string StaffID
        {
            get
            {
                return staffID.ToString();
            }
            set
            {
                if (!(value == string.Empty))
                {
                    if (!int.TryParse(value, out staffID))
                    {
                        ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException("Staff ID must be a whole number", "Incorrect Format");
                        throw ex;
                    }
                }
                else
                {
                    // If it is blank, declare and throw an exception
                    ArgumentNullException ex = new ArgumentNullException("Staff ID is required", "Missing Fields");
                    throw ex;
                }
            }
        }

        protected internal string RoleID
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
        public User(string roleIDValue) { 
            this.roleNamePublic = GetRole(roleIDValue);
        }
        public override string ToString()
        {
            return RoleID.ToString();
        }
    }
}
