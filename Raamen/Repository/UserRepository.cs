using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class UserRepository
    {
        static Database1Entities db = new Database1Entities();
        public static User userLogin(string username, string password)
        {
            User user = (from x in db.Users where x.Username.Equals(username) && x.Password.Equals(password) select x).FirstOrDefault();
        
            return user;
        }

        public static void RegistUser(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static List<User> GetCustomers()
        {
            List<User> users = (from x in db.Users where x.RoleId == 4 select x).ToList();
            return users;
        }
        public static List<User> GetStaffs()
        {
            List<User> users = (from x in db.Users where x.RoleId == 3 select x).ToList();
            return users;
        }


        //Update section
        public static User getUserById(int CustomerId)
        {
            return db.Users.FirstOrDefault(u => u.CustomerId == CustomerId);
        }

        public static void UpdateUser(User user)
        {
            User currentUser = db.Users.FirstOrDefault(u => u.CustomerId == user.CustomerId);

            if(currentUser != null)
            {
                currentUser.Username = user.Username;
                currentUser.Email = user.Email;
                currentUser.Gender = user.Gender;
                currentUser.Password = user.Password;

                db.SaveChanges();
            }
        }
        
    }
}