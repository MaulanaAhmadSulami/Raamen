using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class ReportRepository
    {
        static Database1Entities db = new Database1Entities();
        public static List<Raman> GetRamen()
        {

            return db.Ramen.ToList();
        }
    }
}