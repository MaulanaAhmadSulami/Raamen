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
        public static string delete(int cdId, int userId)
        {
            return CartRepository.delete(cdId, userId);
        }
        public static string clearCart(int userId)
        {
            return CartRepository.clear(userId);
        }
    }
}