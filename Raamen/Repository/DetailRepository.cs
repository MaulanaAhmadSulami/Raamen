using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class DetailRepository
    {
        static Database1Entities db = new Database1Entities();
        public static Detail insertDetail(Detail detail)
        {
            db.Details.Add(detail);
            db.SaveChanges();
            return detail;
        }
    }
}