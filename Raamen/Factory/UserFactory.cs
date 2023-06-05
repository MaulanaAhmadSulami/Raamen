using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class UserFactory
    {
        static Database1Entities db = new Database1Entities();
        public static User createUser(string username, string email, string gender, string password, int RoleId)
        {
            User user = new User();
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            user.RoleId = RoleId;


            return user;
        }
        public static User CreateStaffUser(string username, string email, string gender, string password)
        {
            User user = new User();
            user.Username = username;
            user.Email = email;
            user.Gender = gender;
            user.Password = password;
            user.RoleId = 3; // Set RoleId to 3 for staff users

            return user;
        }

        internal static User createUser(string username, string email, string gender, string password, object roleId)
        {
            throw new NotImplementedException();
        }
    }
}