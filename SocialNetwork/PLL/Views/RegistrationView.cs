using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class RegistrationView
    {
        UserService userService;
        public RegistrationView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show()
        {
            var userRegistrationData = new UserRegistrationData();

            Console.WriteLine("To register, please enter your first name:");
            userRegistrationData.FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            userRegistrationData.LastName = Console.ReadLine();

            Console.WriteLine("Please create a password:");
            userRegistrationData.Password = Console.ReadLine();

            Console.WriteLine("Please enter your email address:");
            userRegistrationData.Email = Console.ReadLine();

            try
            {
                this.userService.Register(userRegistrationData);

                SuccessMessage.Show("Profile successfully created. You can now log in using your credentials.");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Please enter correct values.");
            }

            catch (Exception)
            {
                AlertMessage.Show("Registration error occured.");
            }
        }
    }
}
