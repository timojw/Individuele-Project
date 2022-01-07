using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Logic.DTO;
using Logic.Interfaces;

namespace DAL.Managers
{
    public class OrderDatabaseManager : DatabaseManager, IOrderDatabaseManager
    {
        public List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("select ID, userID, status, time from Order", conn);
                conn.Open();

                var reader = query.ExecuteReader();
                while (reader.Read())
                {
                    OrderDTO order = new OrderDTO();
                    order.ID = reader.GetInt32(0);
                    order.UserID = reader.GetInt32(1);
                    order.Status = reader.GetString(2);
                    order.Time = reader.GetDateTime(3);

                    orders.Add(order);
                }
            }
            return orders;
        }

        void IOrderDatabaseManager.AddOrder(OrderDTO OrderDTO)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using SqlCommand query = new SqlCommand("INSERT INTO [dbo].[Order] ([userID], [status], [time]) VALUES (@userID, @status, @time", conn);
                conn.Open();

                query.Parameters.AddWithValue("@userID", OrderDTO.UserID);
                query.Parameters.AddWithValue("@status", OrderDTO.Status);
                query.Parameters.AddWithValue("@time", OrderDTO.Time);


                var modified = query.ExecuteScalar();
                OrderDTO.ID = (int)modified;
            }
        }
    }
}

