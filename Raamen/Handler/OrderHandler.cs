using Raamen.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Raamen.Handler
{
    public class OrderHandler
    {
        public static void InsertOrderQueue(int customerId)
        {
            // Insert the order into the order queue
            OrderRepository.InsertOrderQueue(customerId);
        }

        public static List<Order> GetOrderQueue()
        {
            // Retrieve the order queue data
            return OrderRepository.GetOrderQueue();
        }

        public static void HandleOrder(int customerId, int ramenId, int quantity)
        {
            // Handle the order (move to the handled transactions section)
            OrderRepository.HandleOrder(customerId, ramenId, quantity);
        }
    }
}