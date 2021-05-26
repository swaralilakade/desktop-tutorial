using System;
using System.Collections.Generic;
using System.Linq;



namespace Catalog
{

    // business Logic Layer
    
 public class ProductManager
    {
        public static List<Product> GetSoldOutProducts()
        {
            List<Product> products = GetAllProducts();
            var soldOutProducts = from prod in products
                                  where prod.Quantity == 0
                                  select prod;
            return soldOutProducts as List<Product>; 
        }
        public static List<Product> GetProuductsInStockLessthan(int amount)
        {
            List<Product> products = GetAllProducts();
            var expensiveInStockProducts =
                from prod in products
                where prod.Quantity > 0 && prod.UnitPrice > amount
                select prod;
            return expensiveInStockProducts as List<Product>;
        }
        public static List<string> GetProjectTitles()
        {
            List<Product> products = GetAllProducts();
            var productNames =
                from prod in products
                select prod.Title;

            return productNames as List<string>;
        }
        public static dynamic GetProductDetails()
        {
            List<Product> products = GetAllProducts();
            var productInfos =
                from prod in products
                select new { prod.Title, prod.Category, Price = prod.UnitPrice };
            return productInfos;         
        }     
        public static List<Product> GetProductsOrderby()
        {
            List<Product> products = GetAllProducts();
            var sortedProducts =
                from prod in products
                orderby prod.Title
                select prod;
            return sortedProducts as List<Product>;
        }   
        public static List<Product> GetProductsByDescending()
        {
            List<Product> products = GetAllProducts();
            var sortedProducts =
                from prod in products
                orderby prod.Quantity descending
                select prod;
            return sortedProducts as List<Product>;
        }
        public static List<Product> GetProductsGroupByCategory()
        {
            List<Product> products = GetAllProducts();
            var orderGroups =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, Products = prodGroup };

            return orderGroups as List<Product>;
        }
        public static List<string> GetProductsDistinct()
        {
            List<Product> products = GetAllProducts();
            var categoryNames = (   from prod in products
                                    select prod.Category
                                ).Distinct();
            return categoryNames as List<string>;
        }   
        public static Product Get(int id)
        {
            List<Product> products = GetAllProducts();
            Product theProduct = products.FirstOrDefault(p => p.Id == id);
            return theProduct;
        }
        public static dynamic  GetProductCount()
        {
            List<Product> products = GetAllProducts();
            var categoryCounts =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, ProductCount = prodGroup.Count() };
            return categoryCounts;
        }
        public static dynamic GetAveragePriceOfCategory()
        {
            List<Product> products = GetAllProducts();
            var categories =
                from prod in products
                group prod by prod.Category into prodGroup
                select new { Category = prodGroup.Key, AveragePrice = prodGroup.Average(p => p.UnitPrice) };
            return categories;
        }
        public static List<Product> GetAllProducts()
        {
            List<Product> allProducts = new List<Product>();
            /* allProducts.Add(new Product { Id = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000 });
            allProducts.Add(new Product { Id = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", Quantity = 7000 ,Likes=4000 });
            allProducts.Add(new Product { Id = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", Quantity = 3400,Likes=4000  });
            allProducts.Add(new Product { Id = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", Quantity = 27000,Likes=4000  });
            allProducts.Add(new Product { Id = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", Quantity = 1000,Likes=4000  });
            allProducts.Add(new Product { Id = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", Quantity = 2000 ,Likes=4000 });
            allProducts.Add(new Product { Id = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", Quantity = 159,Likes=4000  });
            allProducts.Add(new Product { Id = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", Quantity = 67,Likes=4000  });
            allProducts.Add(new Product { Id = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000  });
            allProducts.Add(new Product { Id = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", Quantity = 0,Likes=4000  });
            allProducts.Add(new Product { Id = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", Quantity = 0,Likes=4000  });
            allProducts.Add(new Product { Id = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", Quantity = 700,Likes=4000  });
            allProducts.Add(new Product { Id = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", Quantity = 1500,Likes=4000  });
            allProducts.Add(new Product { Id = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", Quantity = 2300,Likes=4000  });
            allProducts.Add(new Product { Id = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Quantity = 10000,Likes=4000  });
            */
            allProducts=GetAllProductsFromDatabase();
             return allProducts;
        }
        public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = ProductDBManager.GetAll();
            return allProducts;
        }
   

        // CRUD Methods for Entity data processing
        
        public static bool Insert(Product product){

            bool status=false;
            status=ProductDBManager.Insert(product);
            return status;
        }
        public static bool Update(Product product){

            bool status=false;
              status=ProductDBManager.Update(product);
            return status;

        }
        public static bool Delete(int id){
            bool status=false;
            status=ProductDBManager.Delete(id);
            return status;
        }
   
    }
}
