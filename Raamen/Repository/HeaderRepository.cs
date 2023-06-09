using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class HeaderRepository
    {
        static Database1Entities db = new Database1Entities();
        public static Header insertHeader(Header header)
        {
            try
            {
                db.Headers.Add(header);
                db.SaveChanges();
                return header;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }   
            //db.Headers.Add(header);
            //db.SaveChanges();
            //return header;
        }
        public static List<Header> getTransactionUser(int userId)
        {
            return db.Headers.Where(x => x.CustomerId == userId).ToList();
        }
        public static List<Header> getTransactionAll()
        {
            return db.Headers.ToList();
        }
    }
}