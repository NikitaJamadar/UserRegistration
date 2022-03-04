using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly UserRegistration userRegistration;
        public UnitTest1()
        {
            userRegistration = new UserRegistration();
        }

        // UC-1
        [TestMethod]
        public void UserFirstName()
        {
            var result = userRegistration.ValidateFirstName("Nikita");
            Assert.AreEqual(true, result);
        }
       

        // UC-2
        [TestMethod]
        public void UserLastName()
        {
            var result = userRegistration.ValidateLastName("Jamadar");
            Assert.AreEqual(true, result);
        }
        

        // UC-3
        [TestMethod]
        public void UserEmail()
        {
            var result = userRegistration.ValidateEmail("nikitajamadar98@gmail.com");
            Assert.AreEqual(true, result);
        }
        

        // UC-4
        [TestMethod]
        public void UserPhoneNumber()
        {
            var result = userRegistration.ValidatePhoneNumber("91 9527754593");
            Assert.AreEqual(true, result);
        }
        

       // UC-5
        [TestMethod]
        public void UserPassword()
        {
            var result = userRegistration.ValidatePassword("Pass@1234");
            Assert.AreEqual(true, result);
        }
        
    }
}
