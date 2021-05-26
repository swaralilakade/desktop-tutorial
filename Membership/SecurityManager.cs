using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections.Generic;

namespace Membership
{
 public static class SecurityManager
    {
        public static string conString=@"server=localhost;user=root;database=CRM;password='root'";
        public static List<User> GetAll()
        {
           List<User> allUsers=new List<User>();
            MySqlConnection con= new MySqlConnection(conString);
            string query = "SELECT * FROM credential";
          
            MySqlCommand command=new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataReader reader=command.ExecuteReader();
               
                while(reader.Read()){
                    int id=int.Parse(reader["Id"].ToString());
                    string username=reader["username"].ToString();
                    string password=reader["password"].ToString();

                    User theUser=new User{
                        Id=id,
                        UserName=username,
                        Password=password
                    };
                     allUsers.Add(theUser);
                }
                reader.Close();
            }
           catch(MySqlException exp){
               string message=exp.Message;
           }
           finally 
           {        con.Close();      }
           return allUsers;
        }
        public static bool Validate(string username, string password)
        {
            bool status =false;
            MySqlConnection con= new MySqlConnection(conString);
            string query = "SELECT * FROM credential WHERE username='"+ username + "' AND password='"+password+"'";
            Console.WriteLine(query);

            MySqlCommand command=new MySqlCommand(query, con);
            try
            {
                con.Open();
                MySqlDataReader reader=command.ExecuteReader();
               
                if(reader.Read()){
                    status=true;
                }
                reader.Close();
            }
           catch(MySqlException exp){
               string message=exp.Message;
           }
           finally 
           {        con.Close();      }
           return status;
        }
       
        public static bool Register( User newUser){
            bool status =false;

              MySqlConnection con= new MySqlConnection(conString);
            string query = "INSERT INTO credential (id,username, password) VALUES(@Id,@UserName, @Password)";
            MySqlCommand command=new MySqlCommand(query, con);
            command.Parameters.Add(new MySqlParameter("@UserName", newUser.Id));
            command.Parameters.Add(new MySqlParameter("@UserName", newUser.UserName));
            command.Parameters.Add(new MySqlParameter("@Password", newUser.Password));
            try
            {
                con.Open();
                command.ExecuteNonQuery();
                status=true;
            }
            catch(Exception exp){
                string message=exp.Message;
              
            }
            finally{
                    con.Close();
            }
           return status;
        }
    }
}