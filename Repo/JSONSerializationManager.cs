using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Repo
{


    [Serializable]
    public class Product {  
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}
    }  
    
    public static  class JSONSerializationManager
    {
        public   static bool Serialize(string  fileName, List<Product> products )
        {
            bool status=false;
            try{             
                    // dynamic data type variable
                    var options=new JsonSerializerOptions {IncludeFields=true};
                    var produtsJson=JsonSerializer.Serialize<List<Product>>(products,options);
                    File.WriteAllText(fileName,produtsJson);
                    status =true;
                }
                catch(Exception exp){

                }
                finally{
                }

                return true;
        }

       public static List<Product> Desrialize(string fileName)
        {
            List<Product> products=new List<Product>();
            try{
                string jsonString = File.ReadAllText(fileName);
                products = JsonSerializer.Deserialize<List<Product>>(jsonString);
              
                /*foreach( Product product in jsonProducts)
                {
                    Console.WriteLine($"{product.Title} : {product.Description}");   
                }   */
              
            }
            catch(Exception exp){

            }
            finally{

            }
            return products;
        }   
    }
}