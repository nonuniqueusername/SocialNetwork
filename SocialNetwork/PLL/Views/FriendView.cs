using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendView
    {
        UserService userService;

        public FriendView(UserService userService)
        {
            this.userService = userService;
        }
        public void Show(User user)
        {
            var friends = userService.GetFriendsByUserId(user.Id);
            Console.WriteLine("Мои друзья:");
            foreach (var friend in friends)
            {
                Console.WriteLine($"{friend.LastName} {friend.FirstName} : {friend.Email}");
            }
        }
    }
}
