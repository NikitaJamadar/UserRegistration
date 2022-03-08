using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationMSTest
{
   public  class UserRegistration
    {
        public static string Regex_FirstName = "^[A-Z][a-z]{2,}$";
        public static string Regex_LastName = "^[A-Z][a-z]{2,}$";
        public static string Regex_EmailId = "^[A-Z0-9a-z]{1,}([.#$^][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public static string Regex_PhoneNumber = "^[9][1][ ][6-9][0-9]{9}$";

        public static string Regex_Password = "^((?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*-_.])(?=.{8,}))";

        public static string Regex_SampleEmails = "^[A-Za-z]+([-.+#^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$";

        // Validation for first name
        public bool ValidateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, Regex_FirstName);
        }

        // validation for last name
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        //validation for Email
        public bool ValidateEmail(string Emailid)
        {
            return Regex.IsMatch(Emailid, Regex_EmailId);
        }

        //validation for phone number
        public bool ValidatePhoneNumber(string PhoneNumber)
        {
            return Regex.IsMatch(PhoneNumber, Regex_PhoneNumber);
        }

        //validation for password
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_Password);
        }
        public  bool ValidateSampleEmails(string SampleEmail)
        {
            return Regex.IsMatch(SampleEmail, Regex_SampleEmails);
        }
    }
}
