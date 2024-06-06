using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserDataUpdateView
    {
        UserService userService;
        public UserDataUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("First name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            user.LastName = Console.ReadLine();

            Console.Write("Profile picture: ");
            user.Photo = Console.ReadLine();

            Console.Write("Favorite movie: ");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("Favorite book: ");
            user.FavoriteBook = Console.ReadLine();

            this.userService.Update(user);

            SuccessMessage.Show("Your profile was successfully updated!");
        }
    }
}
