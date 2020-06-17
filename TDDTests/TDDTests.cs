using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTests
{
    [TestClass]
    public class TDDTests
    {
        [TestMethod]
        public void Should_Register_Name_And_Email_When_User_Insert()
        {
            TDDMethods methods = new TDDMethods();

            var name = "Ravel Okada";
            var email = "ravel.okada@email.com.br";

            User user = new User();

            user.Name = name;
            user.Email = methods.ValidateEmail(name, email);

            Assert.AreEqual(user.Email, email);

        }
    }
}
