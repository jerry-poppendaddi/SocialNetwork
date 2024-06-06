using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserInfoView
    {
        public void Show(User user)
        {
            Console.WriteLine("My profile");
            Console.WriteLine("My id: {0}", user.Id);
            Console.WriteLine("My first name: {0}", user.FirstName);
            Console.WriteLine("My last name: {0}", user.LastName);
            Console.WriteLine("My password: {0}", user.Password);
            Console.WriteLine("My email: {0}", user.Email);
            Console.WriteLine("My profile picture: {0}", user.Photo);
            Console.WriteLine("My favorite movie: {0}", user.FavoriteMovie);
            Console.WriteLine("My favorite book: {0}", user.FavoriteBook);
        }
    }
}