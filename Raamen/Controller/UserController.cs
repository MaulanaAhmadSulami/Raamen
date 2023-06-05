using Raamen.Factory;
using Raamen.Handler;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Controller
{   
    
    public class UserController
    {
        //static Database1Entities db = new Database1Entities();

        public static string RegisterUser(string username, string email, string gender, string password, string conf_password, bool isStaff)
        {

            if (username.Length < 5 || username.Length > 15)
            {
                return "Username must be between 5 and 15 and alphabet with spaces only";

            }

            else if (!email.EndsWith(".com"))
            {
                return "Email must ends with .com";

            }
            else if (string.IsNullOrEmpty(gender))
            {
                return "Gender must be chosen";

            }
            else if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(conf_password))
            {
                return "Password and confirm password must be provided.";
            }
            else if (password != conf_password)
            {
                return "Password and confirm password must match";

            }
            using (var db = new Database1Entities())
            {
                if (isStaff)
                {
                    User staffUser = UserFactory.CreateStaffUser(username, email, gender, password);
                    UserRepository.RegistUser(staffUser);
                }
                else
                {
                    User customerUser = UserFactory.createUser(username, email, gender, password, 4); // RoleId 4 for customers
                    UserRepository.RegistUser(customerUser);
                }
                //User user = Factory.UserFactory.createUser(username, email, gender, password, 4);
                //db.Users.Add(user);
                //db.SaveChanges();
            }

            return "User registered successfully.";
        }


        public static User UserLogin(string username, string password)
        {
            User user = UserHandler.loginUser(username, password);

            return user;
        }
    }
}