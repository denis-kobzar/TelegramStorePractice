using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelegramStorePractice.Model;

namespace TelegramStorePractice.FactoryMethod
{
    internal static class UserFactory
    {
        public static UserModel NewUser(int id, string name, string link, string description)
        {
            return new UserModel(id, name, link, description);
        }
    }
}
