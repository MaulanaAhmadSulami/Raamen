using Raamen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class CartRepository
    {
        static Database1Entities db = new Database1Entities();
        private static Cart getUserCart(int userId)
        {
            return db.Carts.Where(x => x.UserId == userId).FirstOrDefault();
        }
        public static List<CartDetail> getUserCartDetail(int userId)
        {
            Cart cart = getUserCart(userId);
            return db.CartDetails.Where(x => x.CartId == cart.CartId).ToList();
        }
        public static string insert(int ramenId, int userId)
        {
            Cart cart = getUserCart(userId);
            CartDetail cartDS = db.CartDetails.Where(x => x.CartId == cart.CartId && x.RamenId == ramenId).FirstOrDefault();
            if (cartDS != null)
            {
                cartDS.Quantity += 1;
                db.SaveChanges();
                return "Success";
            }
            else
            {

                CartDetail cartD = new CartDetail();
                cartD.CartId = cart.CartId;
                cartD.RamenId = ramenId;
                cartD.Quantity = 1;
                db.CartDetails.Add(cartD);
                db.SaveChanges();
                return "Success";
            }
        }
        public static string delete(int cdId, int userId)
        {
            Cart cart = getUserCart(userId);
            CartDetail cartDS = db.CartDetails.Where(x => x.CartDetailId == cdId).FirstOrDefault();
            if (cartDS != null)
            {
                db.CartDetails.Remove(cartDS);
                db.SaveChanges();
                return "Success";
            }
            else
            {
                return "Failed";
            }
        }
        public static string clear(int userId)
        {
            Cart cart = getUserCart(userId);
            List<CartDetail> cartDS = db.CartDetails.Where(x => x.CartId == cart.CartId).ToList();
            if (cartDS != null)
            {
                foreach (var item in cartDS)
                {
                    db.CartDetails.Remove(item);
                }
                db.SaveChanges();
                return "Success";
            }
            else
            {
                return "Failed";
            }
        }   
    }
}