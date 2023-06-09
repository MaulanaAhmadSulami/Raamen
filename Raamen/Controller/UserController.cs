using Raamen.Factory;
using Raamen.Handler;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;


namespace Raamen.Controller
{   
    
    public class UserController
    {
        //static Database1Entities db = new Database1Entities();

        public static string RegisterUser(string username, string email, string gender, string password, string conf_password, bool isStaff)
        {

            if (!IsValidUsername(username))
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
                    int userId = UserRepository.RegistUser(customerUser);
                    CartHandler.CreateCart(userId);
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

        public static string UpdateUserProfile(int CustomerId, string username, string email, string gender, string password)
        {
            if (!IsValidUsername(username))
            {
                return "Length must be between 5 and 15 and alphabet with space only.";
            }
            else if (!email.EndsWith(".com"))
            {
                return "Email must ends with .com";
            }
            else if (string.IsNullOrEmpty(gender))
            {
                return "Gender must be chosen";
            }
            else if(password.Length < 5)
            {
                return "Password must be longer than 5 characters";
            }

            User user = UserRepository.getUserById(CustomerId);
            if(user != null)
            {
                if(!password.Equals(user.Password))
                {
                    return "Must be the same with the current password";
                }
                user.Username = username;
                user.Email = email;
                user.Gender = gender;

                UserRepository.UpdateUser(user);

                return "Profile updated successfully";
            }

            return "User not found";
        }

        private static bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, "^[A-Za-z ]{5,15}$");
        }

    }
}