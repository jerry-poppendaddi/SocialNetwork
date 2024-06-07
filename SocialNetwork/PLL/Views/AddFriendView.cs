using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.DAL.Entities;
using SocialNetwork.PLL.Helpers;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendView
    {
        
        public void Show(User user)
        {
            FriendService friendService = new FriendService();
            Console.WriteLine("Enter your new friend's email: ");
            var friendSearch = Console.ReadLine();

            try
            {                
                friendService.AddFriend(friendSearch);
                SuccessMessage.Show("Your friend was added!");

            }
            catch (ArgumentNullException)
            {
                AlertMessage.Show("Your friend wasn't found!");
            }
        }
    }
}
