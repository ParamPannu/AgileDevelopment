using System;
using ClassLibrary;
using System.IO;
namespace ClassLibrary
{
    public class clsOrderUser
    {
        private Int32 mUserId;
        private string mUserName;
        private string mPassword;
        private string mDepartment;
        public int UserID
        {
            get
            {
                return mUserId;

            }
            set
            {
                mUserId = value;
            }
        }
        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }
        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }
        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }

        public bool FindUser(string userName, string password)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            DB.Execute("sproc_UserTable_FindUserNamePW");
            if (DB.Count == 1)
            {
                mUserId = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                return true;
            }
            else
            {
                return false;
            }





        }
    }
}