using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class CartFactory
    {
        public static CartDetail newCartDetail(int cartId, int ramenId, int quantity)
        {
            CartDetail cartDetail = new CartDetail
            {
                CartId = cartId,
                RamenId = ramenId,
                Quantity = quantity
            };

            return cartDetail;
        }
    }
}