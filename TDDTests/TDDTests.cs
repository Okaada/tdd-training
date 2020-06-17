using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTests
{
    [TestClass]
    public class TDDTests
    {
        [DataTestMethod]
        [DataRow("Ravel Okada", "ravel.okada@email.com.br")]
        public void Should_Validate_If_Email_Follow_Company_Patterns_When_User_Insert_Sucess(string name, string email)
        {
            TDDMethods methods = new TDDMethods();
            User user = new User();

            user.Name = name;
            user.Email = methods.ValidateEmail(name, email);

            Assert.AreEqual(user.Email, email);
        }

        [DataTestMethod]
        [DataRow("Ravel Okada", "okada.ravel@email.com.br")]
        public void Should_Validate_If_Email_Follow_Company_Patterns_When_User_Insert_Fail(string name, string email)
        {
            TDDMethods methods = new TDDMethods();
            User user = new User();

            user.Name = name;
            user.Email = methods.ValidateEmail(name, email);

            Assert.AreNotEqual(user.Email, email);
        }
    }
}
