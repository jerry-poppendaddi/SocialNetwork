using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;

namespace SocialNetwork
{
    class Program
    {
        public static UserService userService = new UserService();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Social Network!");

            while (true)
            {
                Console.Write("To Register, please enter your First Name: ");

                string firstName = Console.ReadLine();

                Console.Write("Please enter your Last Name: ");
                string lastName = Console.ReadLine();

                Console.Write("Please create a password: ");
                string password = Console.ReadLine();

                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();

                UserRegistrationData userRegistrationData = new UserRegistrationData()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    Email = email
                };

                try
                {
                    userService.Register(userRegistrationData);
                    Console.WriteLine("Registration successful!");
                }

                catch (ArgumentNullException)
                {
                    Console.WriteLine("Please input correct values.");
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Registration error has occured: {ex.Message}");
                }

                Console.ReadLine();
            }

        }
    }
}
