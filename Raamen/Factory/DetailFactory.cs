using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class DetailFactory
    {
        public static Detail newDetail(int headerId, int ramenId, int quantity)
        {
            Detail detail = new Detail
            {
                HeaderId = headerId,
                RamenId = ramenId,
                Quantity = quantity
            };

            return detail;
        }
    }
}