using Raamen.Controller;
using Raamen.Factory;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class UserHandler
    {
        // Regist
        public static void InUser(string username, string email, string gender, string password, int RoleId)
        {
            User user = UserFactory.createUser(username, email, gender, password, RoleId);

            UserRepository.RegistUser(user);
        }

        

        //Login
        public static User loginUser(string username, string password)
        {
            User user = UserRepository.userLogin(username, password);

            return user;
        }
    }
}