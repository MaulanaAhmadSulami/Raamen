using Raamen.Factory;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class RamenHandler
    {
        public static List<Raman> getAllRamen()
        {
            return RamenRepository.getAllRamen();
        }
        public static string insertRamen(string name, int meat, string broth, string price)
        {
            Raman raman = RamenFactory.createRamen(name, meat, broth, price);
            return RamenRepository.insertRamen(raman);
        }
        public static Raman getRamenbyId(int id)
        {
            return RamenRepository.getRamenbyId(id);
        }
        public static string updateRamen(int id, string name, int meat, string broth, string price)
        {
            return RamenRepository.updateRamen(id, name, meat, broth, price);
        }
        public static void deleteRamen(int id)
        {
            RamenRepository.deleteRamen(id);
        }

    }
}