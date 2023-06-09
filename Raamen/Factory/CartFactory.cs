using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Factory
{
    public class CartFactory
    {
        public static Cart newCart(int userId)
        {
            Cart cart = new Cart
            {
                UserId = userId
            };
            return cart;
        }
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