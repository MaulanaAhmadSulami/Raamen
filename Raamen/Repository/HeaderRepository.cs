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
    }
}