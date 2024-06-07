using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserMenuView
    {
        UserService userService;
        public UserMenuView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            while (true)
            {
                Console.WriteLine("Inbox: {0}", user.IncomingMessages.Count());
                Console.WriteLine("Sent: {0}", user.OutgoingMessages.Count());

                Console.WriteLine("View your profile - press 1");
                Console.WriteLine("Edit your profile - press 2");
                Console.WriteLine("Add a friend - press 3");
                Console.WriteLine("To see your friends - press 4");
                Console.WriteLine("Write a message - press 5");
                Console.WriteLine("See inbox - press 6");
                Console.WriteLine("See sent messages - press 7");
                Console.WriteLine("Log out - press 8");

                string keyValue = Console.ReadLine();

                if (keyValue == "8") break;

                switch (keyValue)
                {
                    case "1":
                        {
                            Program.userInfoView.Show(user);
                            break;
                        }
                    case "2":
                        {
                            Program.userDataUpdateView.Show(user);
                            break;
                        }

                    case "3":
                        {
                            Program.addFriendView.Show(user);
                            break;
                        }

                    case "4":
                        {
                            Program.viewFriends.Show(user);
                            break;
                        }

                    case "5":
                        {
                            Program.messageSendingView.Show(user);
                            break;
                        }

                    case "6":
                        {

                            Program.userIncomingMessageView.Show(user.IncomingMessages);
                            break;
                        }

                    case "7":
                        {
                            Program.userOutcomingMessageView.Show(user.OutgoingMessages);
                            break;
                        }
                }
            }

        }
    }
}
