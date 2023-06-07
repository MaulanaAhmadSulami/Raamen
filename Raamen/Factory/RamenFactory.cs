using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class RamenFactory
    {
        public static Raman createRamen(string name, int meat, string broth, string price)
        {
            Raman raman = new Raman
            {
                Name = name,
                MeatId = meat,
                Broth = broth,
                Price = price
            };

            return raman;
        }
    }
}