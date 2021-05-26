using System;
using MongoDB.Bson;  
using MongoDB.Driver; 
using System.Collections.Generic;

namespace Repo
{
    public class MongoCustomer  
    {  
        public ObjectId Id { get; set; }  
        public string FirstName { get; set; }  
        public string LastName { get; set; }  
        public string City { get; set; }  
        public string Age { get; set; }  
    }   
    public  static class CustomerMongoDBManager
    {    
        public static IMongoClient client;  
        public  static IMongoDatabase database;  
        public static MongoCustomer GetCustomer()  
        {  
            Console.WriteLine("Please enter customer first name : ");  
            string firstName = Console.ReadLine();  

            Console.WriteLine("Please enter customer last name : ");  
            string lastName = Console.ReadLine();  

            Console.WriteLine("Please enter customer age : ");  
            string age = Console.ReadLine();  

            Console.WriteLine("Please enter city name : ");  
            string city = Console.ReadLine();  

            MongoCustomer customer = new MongoCustomer()  
            {  
                FirstName = firstName,  
                LastName = lastName,  
                Age = age,  
                City = city
            };  
            return customer;  
        }  
        public static List<MongoCustomer> GetAll() 
        {
                List<MongoCustomer> customers = new List<MongoCustomer>();
                client = new MongoClient();  
                database = client.GetDatabase("eCommerce");  
                var collection = database.GetCollection<MongoCustomer>("customers");  
    
                //Read all existing document  
                var all = collection.Find(new BsonDocument());  
                customers=all as List<MongoCustomer>;
                return customers;
        }
        public static MongoCustomer GetById(int customerId)
        {
                MongoCustomer theCustomer=null;
                List<MongoCustomer> customers = new List<MongoCustomer>();
                client = new MongoClient();  
                database = client.GetDatabase("eCommerce");  
                var collection = database.GetCollection<MongoCustomer>("customers");  
                //Implement Logic for get by Id from Mongo DB
                return theCustomer;
        }
        public static bool Delete(string  customerName)
        {
                bool status = false;
                client = new MongoClient();  
                database = client.GetDatabase("eCommerce");  
                var collection = database.GetCollection<MongoCustomer>("customers");  
                var deletefirstName = customerName;  
                collection.DeleteOne(s => s.FirstName == deletefirstName);  
                return status;
        }   
        public static bool Update(MongoCustomer customer)
        {
                bool status = false;
                client = new MongoClient();  
                database = client.GetDatabase("eCommerce");  
                var collection = database.GetCollection<MongoCustomer>("customers");  
                collection.FindOneAndUpdate<Customer>  
                            (Builders<MongoCustomer>.Filter.Eq("FirstName", customer.FirstName),  
                            Builders<MongoCustomer>.Update.Set("LastName", customer.LastName).Set("City", customer.City).Set("Age", customer.Age));  
                status=true;   
                return status;
        }
        public static bool Insert(MongoCustomer newCustomer)
        {
                bool status = false;
                client = new MongoClient();  
                database = client.GetDatabase("eCommerce");  
                var collection = database.GetCollection<MongoCustomer>("customers");  
                collection.InsertOne(newCustomer);  
                return status;
        }
    }
}