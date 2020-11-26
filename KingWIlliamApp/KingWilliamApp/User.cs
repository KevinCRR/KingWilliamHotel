using System;
using System.Collections.Generic;
using System.Linq;
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
        private int roleID = 0;
        private string roleName;
        public string roleNamePublic;

        #endregion

        #region "Constructors"

        protected internal User(string usernameValue, string passwordValue, int roleIDValue, int staffIDValue)
        {
            this.Username = usernameValue;
            this.Password = passwordValue;
            this.RoleID = roleIDValue;
            this.StaffID = staffIDValue;
            this.roleName = GetRole(roleIDValue);
            
        }

        protected internal User()
        {

        }

        #endregion
         
        #region "Class methods"

        protected internal static User GetUser(string usernameValue, string passwordValue)
        {
            return DBL.SelectUser(usernameValue, passwordValue);
        }


        protected internal static String GetRole(int roleIDValue)
        {
            return DBL.SelectRoleTitle(roleIDValue);
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
        public User(int roleIDValue) { 
            this.roleNamePublic = GetRole(roleIDValue);
        }
        public override string ToString()
        {
            return RoleID.ToString();
        }
    }
}
