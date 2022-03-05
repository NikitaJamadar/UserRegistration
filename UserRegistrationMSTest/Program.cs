using System;

namespace UserRegistrationMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Program");
            UserRegistration userRegistration = new UserRegistration();

            Console.WriteLine("Enter your first name");
            string FirstName = Console.ReadLine();          
            Console.WriteLine(userRegistration.ValidateFirstName(FirstName));

            Console.WriteLine("Enter your last name");
            string LastName = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateLastName(LastName));

            Console.WriteLine("Enter your Email");
            string Email = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateEmail(Email));

            Console.WriteLine("Enter your Phone number");
            string PhoneNumber= Console.ReadLine();
            Console.WriteLine(userRegistration.ValidatePhoneNumber(PhoneNumber));

            Console.WriteLine("Enter your Password");
            string Password = Console.ReadLine();
            Console.WriteLine(userRegistration.ValidateFirstName(Password));

        }
    }
}
