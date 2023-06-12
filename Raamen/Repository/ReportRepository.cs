using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class ReportRepository
    {
        public static List<Header> GetAllTransactions()
        {
            Database1Entities db = new Database1Entities();
            return db.Headers.ToList();
        }

        public static List<Raman> GetAllRamen()
        {
            Database1Entities db = new Database1Entities();
            return db.Ramen.ToList();
        }
    }
}