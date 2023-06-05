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
    }
}