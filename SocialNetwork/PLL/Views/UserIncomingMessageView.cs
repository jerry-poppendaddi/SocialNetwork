using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Inbox");

            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("There are no messages");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("From: {0}. Message: {1}", message.SenderEmail, message.Content);
            });
        }
    }
}