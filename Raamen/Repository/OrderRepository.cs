using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Raamen.Repository
{
    public class OrderRepository
    {
        public static void InsertOrderQueue(int customerId)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO OrderQueue (CustomerId) VALUES (@CustomerId)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerId", customerId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // Retrieve the order queue data
        public static List<Order> GetOrderQueue()
        {
            // Retrieve the order queue data from the database
            // You can use database-specific operations or an ORM framework like Entity Framework

            // Example using ADO.NET:
            List<Order> orderQueue = new List<Order>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT CustomerId, RamenId, Quantity FROM OrderQueue";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int customerId = Convert.ToInt32(reader["CustomerId"]);
                    int ramenId = Convert.ToInt32(reader["RamenId"]);
                    int quantity = Convert.ToInt32(reader["Quantity"]);
                    Order order = new Order(customerId, ramenId, quantity);
                    orderQueue.Add(order);
                }
                reader.Close();
            }
            return orderQueue;
        }

        public static void HandleOrder(int customerId, int ramenId, int quantity)
        {
           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string updateQuery = "UPDATE OrderQueue SET Status = 'Handled' WHERE CustomerId = @CustomerId AND RamenId = @RamenId";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@CustomerId", customerId);
                updateCommand.Parameters.AddWithValue("@RamenId", ramenId);
                connection.Open();
                updateCommand.ExecuteNonQuery();
            }

            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string insertQuery = "INSERT INTO HandledTransactions (CustomerId, RamenId, Quantity) VALUES (@CustomerId, @RamenId, @Quantity)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@CustomerId", customerId);
                insertCommand.Parameters.AddWithValue("@RamenId", ramenId);
                insertCommand.Parameters.AddWithValue("@Quantity", quantity);
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }
    }
}