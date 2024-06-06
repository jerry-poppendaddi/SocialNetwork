using SocialNetwork.BLL.Exceptions;
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

                Console.WriteLine("To Log In, please enter 1.");
                Console.WriteLine("To Register, please enter 2.");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            var authenticationData = new UserAuthenticationData();

                            Console.WriteLine("Enter your email address:");
                            authenticationData.Email = Console.ReadLine();

                            Console.WriteLine("Enter your password:");
                            authenticationData.Password = Console.ReadLine();

                            try
                            {
                                User user = userService.Authenticate(authenticationData);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("You've successfully logged in! Welcome back, {0}!", user.FirstName);
                                Console.ForegroundColor = ConsoleColor.White;

                                while (true)
                                {
                                    Console.WriteLine("To view your profile, press 1");
                                    Console.WriteLine("To edit your profile, press 2");
                                    Console.WriteLine("To find friends, press 3");
                                    Console.WriteLine("For message, press 4");
                                    Console.WriteLine("To log out, press 5");

                                    switch (Console.ReadLine())
                                    {
                                        case "1":
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("My profile info:");
                                                Console.WriteLine("My id: {0}", user.Id);
                                                Console.WriteLine("First name: {0}", user.FirstName);
                                                Console.WriteLine("Last name: {0}", user.LastName);
                                                Console.WriteLine("Password: {0}", user.Password);
                                                Console.WriteLine("Email: {0}", user.Email);
                                                Console.WriteLine("Profile picture link: {0}", user.Photo);
                                                Console.WriteLine("My favorite movie: {0}", user.FavoriteMovie);
                                                Console.WriteLine("My favorite book: {0}", user.FavoriteBook);
                                                Console.ForegroundColor = ConsoleColor.White;
                                                break;
                                            }
                                        case "2":
                                            {
                                                Console.Write("My first name is:");
                                                user.FirstName = Console.ReadLine();

                                                Console.Write("My last name is:");
                                                user.LastName = Console.ReadLine();

                                                Console.Write("Link to profile pic:");
                                                user.Photo = Console.ReadLine();

                                                Console.Write("My favorite movie:");
                                                user.FavoriteMovie = Console.ReadLine();

                                                Console.Write("My favorite book:");
                                                user.FavoriteBook = Console.ReadLine();

                                                userService.Update(user);

                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Your profile was successfully updated!");
                                                Console.ForegroundColor = ConsoleColor.White;

                                                break;
                                            }
                                    }
                                }

                            }
                            catch (WrongPasswordException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Incorrect password!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (UserNotFoundException)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("User not found!");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            break;
                        }

                    case "2":
                        {
                            var userRegistrationData = new UserRegistrationData();

                            Console.WriteLine("To Register, please enter your First name:");
                            userRegistrationData.FirstName = Console.ReadLine();

                            Console.WriteLine("Enter your Last name:");
                            userRegistrationData.LastName = Console.ReadLine();

                            Console.WriteLine("Create your password (8 symbols min):");
                            userRegistrationData.Password = Console.ReadLine();

                            Console.WriteLine("Enter your email address:");
                            userRegistrationData.Email = Console.ReadLine();

                            try
                            {
                                userService.Register(userRegistrationData);

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your profile was created. Now you can log in using your login and password information.");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (ArgumentNullException)
                            {
                                Console.WriteLine("Enter the correct value.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Registration error has occured: {ex.Message} ");
                            }

                            break;
                        }
                }
            }

        }
    }
}
   
