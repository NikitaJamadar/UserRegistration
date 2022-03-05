using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
       
       
       // test case for First Name
        [TestMethod]
        public void GivenWrongFirstName_ShouldReturnFalse()
        {
            string firstName = "nikita";
            bool expected = false;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateFirstName(firstName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectFirstName_ShouldReturnTrue()
        {
            string firstName = "Nikita";
            bool expected = true;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateFirstName(firstName);
            Assert.AreEqual(expected, actual);
        }

        // test case for last name
        [TestMethod]
        public void GivenWrongLastName_ShouldReturnFalse()
        {
            string lastName = "jamadar";
            bool expected = false;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateLastName(lastName);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectLastName_ShouldReturnTrue()
        {
            string lastName = "Jamadar";
            bool expected = true;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateLastName(lastName);
            Assert.AreEqual(expected, actual);
        }
        //Test case for Email
        [TestMethod]
        public void GivenWrongEmail_ShouldReturnFalse()
        {
            string Email = "nikitagmail.com";
            bool expected = false;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateEmail(Email);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GivenCorrectEmail_ShouldReturnTrue()
        {
            string Email = "nikita@gmail.com";
            bool expected = true;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidateEmail(Email);
            Assert.AreEqual(expected, actual);
        }
        //Test case for Phone Number
        [TestMethod]
        public void GivenWrongPhoneNumber_ShouldReturnFalse()
        {
            string phoneNumber = "7214566677788";
            bool expected = false;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidatePhoneNumber(phoneNumber);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCorrectPhoneNumber_ShouldReturnTrue()
        {
            string phoneNumber = "91 9527754593";
            bool expected = true;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidatePhoneNumber(phoneNumber);
            Assert.AreEqual(expected, actual);
        }
        // Test case for Password
        [TestMethod]
        public void GivenWrongPassword_ShouldReturnFalse()
        {
            string Password = "Pass345";
            bool expected = false;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidatePassword(Password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenCorrectPassword_ShouldReturnTrue()
        {
            string Password = "Pass@12345";
            bool expected = true;
            UserRegistration userRegistration = new UserRegistration();
            var actual = userRegistration.ValidatePassword(Password);
            Assert.AreEqual(expected, actual);
        }
    }
}
