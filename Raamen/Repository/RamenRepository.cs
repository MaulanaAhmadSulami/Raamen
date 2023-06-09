using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class RamenRepository
    {
        static Database1Entities db = new Database1Entities();
        public static List<Raman> getAllRamen()
        {
            return db.Ramen.ToList();
        }
        public static string insertRamen(Raman raman)
        {
            db.Ramen.Add(raman);
            db.SaveChanges();
            return "Success";
        }
        public static Raman getRamenbyId(int id)
        {
            return db.Ramen.Find(id);
        }
        public static string updateRamen(int id, string name, int meat, string broth, string price)
        {
            Raman raman = getRamenbyId(id);
            raman.Name = name;
            raman.MeatId = meat;
            raman.Broth = broth;
            raman.Price = price;
            db.SaveChanges();
            return "Success";
        }
        public static void deleteRamen(int id)
        {
            Raman ramen = getRamenbyId(id);
            db.Ramen.Remove(ramen);
            db.SaveChanges();
        }

    }
}