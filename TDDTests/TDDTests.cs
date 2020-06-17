using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TDDTests
{
    [TestClass]
    public class TDDTests
    {

        private readonly User user;
        private readonly TDDMethods methods;
        public TDDTests()
        {
            user = new User();
            methods = new TDDMethods();
        }


        [DataTestMethod]
        [DataRow("Ravel Okada", "ravel.okada@email.com.br")]
        [DataRow("John Doe", "john.doe@email.com.br")]
        [DataRow("Joana Doe", "joana.doe@email.com.br")]
        public void Should_Validate_If_Email_Follow_Company_Patterns_When_User_Insert_Sucess(string name, string email)
        {

            user.Name = name;
            user.Email = methods.ValidateEmail(name, email);

            Assert.AreEqual(user.Email, email);
        }

        [DataTestMethod]
        [DataRow("Ravel Okada", "okada.ravel@email.com.br")]
        [DataRow("John Doe", "doe.john@email.com.br")]
        [DataRow("Joana Doe", "doe.joana@email.com.br")]
        public void Should_Validate_If_Email_Follow_Company_Patterns_When_User_Insert_Fail(string name, string email)
        {

            user.Name = name;
            user.Email = methods.ValidateEmail(name, email);

            Assert.AreNotEqual(user.Email, email);
        }
    }
}
