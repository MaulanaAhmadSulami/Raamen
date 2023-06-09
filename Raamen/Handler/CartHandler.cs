using Raamen.Factory;
using Raamen.Model;
using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class CartHandler
    {
        public static List<CartDetail> getUserCartDetail(int userId)
        {
            return CartRepository.getUserCartDetail(userId);
        }
        public static string insert(int ramenId, int userId)
        {
            return CartRepository.insert(ramenId, userId);
        }
        public static string insertNew(int cartId, int ramenId, int quantity)
        {
            CartDetail cartDetail = CartFactory.newCartDetail(cartId, ramenId, quantity);
            return CartRepository.insertNew(cartDetail);
        }
        public static string delete(int cdId, int userId)
        {
            return CartRepository.delete(cdId, userId);
        }
        public static string clearCart(int userId)
        {
            return CartRepository.clear(userId);
        }
        public static string checkout(int userId)
        {
            return CartRepository.checkout(userId);
        }
        public static void CreateCart(int userId)
        {
            Cart cart = CartFactory.newCart(userId);
            CartRepository.createCart(cart);
        }
    }
}