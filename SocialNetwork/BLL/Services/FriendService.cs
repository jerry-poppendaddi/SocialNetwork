using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {        
        IFriendRepository friendRepository;
        IUserRepository userRepository;
        public FriendService()
        {
            friendRepository = new FriendRepository();            
        }

        public void AddFriend(string email)
        {
            UserService userService = new UserService();
            UserRepository userRepository = new UserRepository();
            FriendRepository friendRepository = new FriendRepository();

            var friendEntity = userRepository.FindByEmail(email);           

            var newFriend = ConstructFriendModel(friendEntity); //creating new friend entity
            friendRepository.Create(newFriend);                 //adding user to our friends

        }           

       private FriendEntity ConstructFriendModel(UserEntity userEntity)
        {
            return new FriendEntity();
        }
        
    }
}
