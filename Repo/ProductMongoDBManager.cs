using System;
using MongoDB.Bson;  
using MongoDB.Driver; 
using System.Collections.Generic;

namespace Repo
{

 public class MongoProduct  
  {  
    public ObjectId Id { get; set; }  
    public int ProductID { get; set; }  
    public string Title { get; set; } 
    public string Picture { get; set; }  
    public string Category { get; set; }  
    public double Price { get; set; }  
    public int Quantity { get; set; }  
    public string PaymentTerm { get; set; }
    public string Delivery { get; set; }
    public string Description { get; set; }  
  }   

  public  static class ProductMongoDBManager
  {  
    public static IMongoClient client;  
    public  static IMongoDatabase database;  

    public static List<MongoProduct> GetAll() {
      List<MongoProduct> products = new List<MongoProduct>();
      client = new MongoClient();  
      database = client.GetDatabase("eCommerce");  
      var collection = database.GetCollection<MongoProduct>("customers");  
    
      //Read all existing document  
      var all = collection.Find(new BsonDocument());  
      products=all as List<MongoProduct>;
      return products;
    }

    public static MongoProduct Get(int productId){
      MongoProduct theProduct=null;
      List<MongoProduct> customers = new List<MongoProduct>();
      client = new MongoClient();  
      database = client.GetDatabase("eCommerce");  
      var collection = database.GetCollection<MongoProduct>("products");  
      //Implement Logic for get by Id from Mongo DB
      return theProduct;
  }
    public static bool Delete(int productId){
      bool status = false;
      client = new MongoClient();  
      database = client.GetDatabase("eCommerce");  
      var collection = database.GetCollection<MongoProduct>("products");  
    
      collection.DeleteOne(s => s.ProductID == productId);  
      return status;
  }
   public static bool Update(MongoProduct product)
    {
      bool status = false;
        client = new MongoClient();  
        database = client.GetDatabase("eCommerce");  
        var collection = database.GetCollection<MongoCustomer>("products");  
        collection.FindOneAndUpdate<Customer>  
                  (Builders<MongoCustomer>.Filter.Eq("productID", product.ProductID),  
                  Builders<MongoCustomer>.Update.Set("title", product.Title).Set("picuture", product.Picture).Set("price", product.Price));  
        status=true;   
        return status;
    }
   public static bool Insert(MongoProduct product)
    {
      bool status = false;
      client = new MongoClient();  
      database = client.GetDatabase("eCommerce");  
      var collection = database.GetCollection<MongoProduct>("products");  
      collection.InsertOne(product);  
      return status;
    }
  }
}