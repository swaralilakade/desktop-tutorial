
using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Banking
{
    public  static class BankDBManager
    {
    public static string conString = @"server=localhost;user=root;database=actsdb;password=''";

    public static List<Account> GetAll() 
        {
            List<Account> accounts = new List<Account>();

            IDbConnection con = new MySqlConnection(conString);
            string query = "SELECT * FROM accounts";
            IDbCommand cmd = new MySqlCommand(query, con as MySqlConnection);
            try
            {
                con.Open(); 
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  
                // read one record at a time in while loop
                {
                    int id = int.Parse(reader["Id"].ToString());
                    int customerId = int.Parse(reader["customerId"].ToString());
                    double balance = double.Parse(reader["Balance"].ToString());
     
                    accounts.Add(new Account()
                    {
                        Id = id,
                        CustomerId = customerId,
                        Balance = balance
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
            return accounts;
        }
    public static Account GetById(int accountId)
        {
            Account theAccount=null;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM accounts WHERE Id=@AccountId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@CustomerId", accountId)); //Parameterized command handling
                 IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["Id"].ToString());
                    int customerId = int.Parse(reader["customerId"].ToString());
                    double balance = double.Parse(reader["Balance"].ToString());
     
                    theAccount=new Account()
                    {
                        Id = id,
                        CustomerId = customerId,
                        Balance = balance
                    };
                }
                reader.Close();
                if (con.State == ConnectionState.Open)
                con.Close();
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return theAccount;
        }
    public static bool Delete(int accountId)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                if (con.State == ConnectionState.Closed)
                 con.Open();
                string query = "DELETE FROM accounts WHERE Id=@AccountId";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.Add(new MySqlParameter("@AccountId", accountId));
                cmd.ExecuteNonQuery(); 
                if (con.State == ConnectionState.Open)
                con.Close();
                status = true;
            }
            catch (MySqlException ee) {
                string message = ee.Message;
            }
            return status;
        }   
    public static bool Update(Account account)
        {
            bool status = false;
            try
            {
              MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();

                    string query = "UPDATE accounts SET Balance=@Balance, CustomerId=@CustomerId, "+ "WHERE Id=@Id";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", account.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Balance", account.Balance));
                    cmd.Parameters.Add(new MySqlParameter("@CustomerId", account.CustomerId));
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

    public static bool Insert(Account account)
        {
            bool status = false;
            try
            {
                MySqlConnection con = new MySqlConnection(conString);
                {
                    if (con.State == ConnectionState.Closed)
                    con.Open();
                    string query = "INSERT INTO accounts (Id,CustomerId, Balance) " +
                                    "VALUES (@Id, @Balance, @CustomerId)";
                        MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.Add(new MySqlParameter("@Id", account.Id));
                    cmd.Parameters.Add(new MySqlParameter("@Balance", account.Balance));
                    cmd.Parameters.Add(new MySqlParameter("@CustomerId", account.CustomerId));
                      cmd.ExecuteNonQuery();
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