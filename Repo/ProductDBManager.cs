using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Repo
{
    public  static class ProductDBManager
    {
        public static string conString = @"server=localhost;user=root;database=actsdb;password=''";
      public static List<Product> GetAll() 
        {
            List<Product> products = new List<Product>();
            IDbConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM flowers";
            IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            try
            {
                con.Open(); // establishing connection

                IDataReader reader = cmd.ExecuteReader();
                //Online data using streaming mechanism
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    float unitPrice = float.Parse(reader["UnitPrice"].ToString());
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    string image = reader["ImageUrl"].ToString();
     
                    products.Add(new Product()
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = image
                    });
                }
                reader.Close();
            }

            catch (MySqlException exp)
            {
                string message = exp.Message;
                //report to developer 
                //log exception message log file
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                     con.Close();
                }
            }

            return products;
        }
      public static Product Get(int productId)
        {
             Product theProduct=null;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                con.Open();
                
                string query = "DELETE FROM flowers WHERE Id=@ProductId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@ProductId", productId));
                
                IDataReader reader = cmd.ExecuteReader();
                
                if (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    string title = reader["Title"].ToString();
                    string description = reader["Description"].ToString();
                    float unitPrice = float.Parse(reader["UnitPrice"].ToString());
                    int quantity = int.Parse(reader["Quantity"].ToString());
                    string image = reader["ImageUrl"].ToString();
     
                   theProduct=new Product()
                    {
                        Id = id,
                        Title = title,
                        Description = description,
                        UnitPrice = unitPrice,
                        Quantity = quantity,
                        ImageUrl = image
                    };
                }
                reader.Close();
                if (con.State == ConnectionState.Open)
                con.Close();
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return theProduct;
        }
      public static bool Delete(int productId)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM flowers WHERE Id=@ProductId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@ProductId", productId)); //Parameterized command handling
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
       public static bool Update(Product product)
        {
            bool status = false;
            try
            {
              MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "UPDATE flowers SET Title=@Title , Description=@Description, " +
                        "ImageUrl=@Image, UnitPrice=@UnitPrice, Quantity=@Quantity " +
                        "WHERE Id=@Id";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.Add(new MySqlParameter("@Id", product.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new MySqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new MySqlParameter("@Image", product.ImageUrl));
                    cmd.Parameters.Add(new MySqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new MySqlParameter("@Quantity", product.Quantity));   

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
       public static bool Insert(Product product)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "INSERT INTO flowers (Id,Title, Description, ImageUrl, UnitPrice, Quantity) " +
                        "VALUES (@Id, @Title, @Description, @Image, @UnitPrice, @Quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", product.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Title", product.Title));
                    cmd.Parameters.Add(new MySqlParameter("@Description", product.Description));
                    cmd.Parameters.Add(new MySqlParameter("@Image", product.ImageUrl));
                    cmd.Parameters.Add(new MySqlParameter("@UnitPrice", product.UnitPrice));
                    cmd.Parameters.Add(new MySqlParameter("@Quantity", product.Quantity));  
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