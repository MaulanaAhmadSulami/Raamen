using Raamen.Handler;
using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Controller
{
    public class RamenController
    {
        public static string insertRamen(string name, int meat, string broth, string price)
        {
            int priceInt = 0;
            bool priceNotEmpty = int.TryParse(price, out priceInt);
            if (!name.Contains("Ramen"))
            {
                return "Name must contains 'Ramen'";
            }
            else if (meat == 0)
            {
                return "Meat must be selected";
            }
            else if (broth.Equals("")){
                return "Broth cannot be empty";
            }
            else if(priceInt < 3000)
            {
                 return "Price must be at least 3000";
            }
            return RamenHandler.insertRamen(name, meat, broth, price);
        }
        public static Raman getRamenbyId(int id)
        {
            if (id == 0)
            {
                return null;
            }
            return RamenHandler.getRamenbyId(id);
        }
        public static string updateRamen(int id, string name, int meat, string broth, string price)
        {
            int priceInt = 0;
            bool priceNotEmpty = int.TryParse(price, out priceInt);
            if (!name.Contains("Ramen"))
            {
                return "Name must contains 'Ramen'";
            }
            else if (meat == 0)
            {
                return "Meat must be selected";
            }
            else if (broth.Equals(""))
            {
                return "Broth cannot be empty";
            }
            else if (priceInt < 3000)
            {
                return "Price must be at least 3000";
            }
            return RamenHandler.updateRamen(id, name, meat, broth, price);
        }
    }
}