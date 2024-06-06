using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserOutcomingMessageView
    {
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("Sent messages");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("You have no sent messages.");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("To: {0}. Message: {1}", message.RecipientEmail, message.Content);
            });
        }
    }
}