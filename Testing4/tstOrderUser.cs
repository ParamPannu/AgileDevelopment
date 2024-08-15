using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void UserIdPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "Param";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "Param";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }
        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            string TestData = "IT";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }
        [TestMethod]
        public void FindUserMethodOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            string UserName = "Param";
            string Password = "Param123";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "Param";
            string Password = "Param123";
            Found = AnUser.FindUser(Username, Password);
            if (AnUser.UserName != Username && AnUser.Password != Password)
            {
                OK = false;

            }
            Assert.IsTrue(OK);

        }
    }
}
