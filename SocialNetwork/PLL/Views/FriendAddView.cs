using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendAddView
    {
        UserService userService;

        public FriendAddView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("Введите почтовый адрес пользователя для добавления в друзья: ");
            string friendMail = Console.ReadLine();

            try
            {
                var userAddFriendData = new UserAddFriendData()
                {
                    UserId = user.Id,
                    FriendMail = friendMail
                };

                userService.AddFriend(userAddFriendData);

                SuccessMessage.Show("Пользователь успешно добавлен в друзья!");

            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }
            catch (Exception)
            {
                AlertMessage.Show("Ошибка при добавлении пользователя в друзья!");
            }
        }
    }
}
