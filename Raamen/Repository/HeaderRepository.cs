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
        public static List<Header> getTransactionAll() //this one report
        {
            return db.Headers.ToList();
        }
        public static List<Header> getTransactionUnhandled()
        {
            return db.Headers.Where(x => x.StaffId == 0).ToList();
        }
        public static List<Header> getTransactionHandled()
        {
            return db.Headers.Where(x => x.StaffId != 0).ToList();
        }
        public static string handleTransaction(int trxId, int staffId)
        {
            try
            {
                Header header = db.Headers.Where(x => x.HeaderId == trxId).FirstOrDefault();
                header.StaffId = staffId;
                db.SaveChanges();
                return "Transaction handled";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "Transaction failed to handle";
            }
        }
    }
}