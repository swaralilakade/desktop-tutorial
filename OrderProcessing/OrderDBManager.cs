
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace OrderProcessing
{
    public  static class OrderDBManager
    {
        public static string conString = @"server=localhost;user=root;database=Ecommerce;password='root'";

        public static List<Order> GetAll() 
            {
                List<Order> orders = new List<Order>();
                IDbConnection con = new MySqlConnection(conString);
                string query = "SELECT * FROM orders";
                IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            
                try
                {
                    con.Open(); 
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["Id"].ToString());
                        DateTime date=DateTime.Parse(reader["OrderDate"].ToString());
                        string status=reader["Status"].ToString();
                        double totalAmount=double.Parse(reader["TotalAmount"].ToString());
                        
                        orders.Add(new Order()
                        {
                            Id = id,
                            OrderDate=date,
                            Status=status,
                            TotalAmount=totalAmount 
                        });
                    }
                    reader.Close();
                }
                catch (MySqlException exp)
                {
                    string message = exp.Message;
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
                return orders;
            }
        public static Order GetById(int orderId)
            {
                Order theOrder=null;
                try
                {       
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "DELETE FROM orders WHERE Id=@OrderId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@OrderId", orderId)); //Parameterized command handling
                    IDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = int.Parse(reader["Id"].ToString());
                        DateTime date = DateTime.Parse(reader["OrderDate"].ToString());
                        float totalAmout = float.Parse(reader["TotalAmount"].ToString());
                        string status = reader["Status"].ToString();
        
                        theOrder=new Order()
                        {
                            Id = id,
                            OrderDate = date,
                            TotalAmount = totalAmout,
                            Status = status
                        };
                    }
                    reader.Close();
                    if (con.State == ConnectionState.Open)
                    con.Close();
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return theOrder;
            }
        public static bool Delete(int orderId)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "DELETE FROM orders WHERE Id=@OrderId";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@OrderId", orderId)); //Parameterized command handling
                    cmd.ExecuteNonQuery();  // DML Operation
                    if (con.State == ConnectionState.Open)
                    con.Close();
                    status = true;
                }
                catch (MySqlException ee) {
                    string message = ee.Message;
                }
                return status;
            }   
        public static bool Update(Order order)
            {
                bool status = false;
                try
                {
                MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)
                        con.Open();

                        string query = "UPDATE order SET Name=@Name , Email=@Email, " +
                                        "ContactNumber=@ContactNumber " + "WHERE Id=@Id";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", order.Id));
                        cmd.Parameters.Add(new MySqlParameter("@OrderDate", order.OrderDate));
                        cmd.Parameters.Add(new MySqlParameter("@TotalAmount", order.TotalAmount));
                        cmd.Parameters.Add(new MySqlParameter("@Status", order.Status));
                        cmd.ExecuteNonQuery();  // DML Operation
                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (MySqlException ex)
                {
                    throw ex;
                }
                return status;
            }
        public static bool Insert(Order order)
            {
                bool status = false;
                try
                {
                    MySqlConnection con = new MySqlConnection(conString);
                    {
                        if (con.State == ConnectionState.Closed)

                        con.Open();
                        string query = "INSERT INTO orders (Id,OrderDate, TotalAmount, Status) " +
                                        "VALUES (@Id, @OrderDate,@TotalAmount, @Status)";

                        MySqlCommand cmd = new MySqlCommand(query, con);
                        cmd.Parameters.Add(new MySqlParameter("@Id", order.Id));
                        cmd.Parameters.Add(new MySqlParameter("@OrderDate", order.OrderDate));
                        cmd.Parameters.Add(new MySqlParameter("@TotalAmount", order.TotalAmount));
                        cmd.Parameters.Add(new MySqlParameter("@Status", order.Status));
                        cmd.ExecuteNonQuery();// DML

                        if (con.State == ConnectionState.Open)
                            con.Close();
                        status = true;
                    }
                }
                catch (MySqlException ex)
                {
                    string message = ex.Message;
                    throw ex;
                }
                return status;
            }
    }
}