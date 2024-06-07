using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class ViewFriends
    {    
        
        public void Show(User user)
        {
            FriendRepository friendRepository = new FriendRepository();
            var friendCount = friendRepository.FindAllByUserId(user.Id);
            Console.Write(friendCount);
        }
    }
}
