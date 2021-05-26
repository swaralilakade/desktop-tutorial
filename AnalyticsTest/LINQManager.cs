using System;
using System.Collections.Generic;
using System.Linq;

namespace AnalyticsTest
{
 public class LINQManager
    {
        public static void Takethree()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var first3Numbers = numbers.Take(3);
            Console.WriteLine("First 3 numbers:");
            foreach (var n in first3Numbers)
            {
                Console.WriteLine(n);
            }
        }
        public static void Skip()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var allButFirst4Numbers = numbers.Skip(4);
            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in allButFirst4Numbers)
            {
                Console.WriteLine(n);
            }
        }
        public static List<string> GetFruitsOrderby()
        {
            string[] words = { "cherry", "apple", "blueberry","banana", "mango" };
            var sortedWords =
                                from word in words
                                orderby word
                                select word;
            return sortedWords as List<string>;
        }    

        public static void SimpleOrderby()
        {
            string[] words = { "cherry", "apple", "blueberry","banana", "mango" };

            var sortedWords =
                            from word in words
                            orderby word
                            select word;
            Console.WriteLine("The sorted list of words:");
            foreach (var w in sortedWords)
            {
                Console.WriteLine(w);
            }

        }

        public static void OrderByDescending()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            var sortedDoubles =
                                from d in doubles
                                orderby d descending
                                select d;
            Console.WriteLine("The doubles from highest to lowest:");
            foreach (var d in sortedDoubles)
            {
                Console.WriteLine(d);
            }
        }

        public static void SimpleUnion()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            var uniqueNumbers = numbersA.Union(numbersB);
            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in uniqueNumbers)
            {
                Console.WriteLine(n);
            }

        }
        
        public static void SimpleIntersect()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var commonNumbers = numbersA.Intersect(numbersB);
            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in commonNumbers)
            {
                Console.WriteLine(n);
            }
        }
        
        public static void SimpleExcept()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            IEnumerable<int> aOnlyNumbers = numbersA.Except(numbersB);
            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in aOnlyNumbers)
            {
                Console.WriteLine(n);
            }
        }
        
        public static void ToSimpleList()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            var sortedWords =
                from w in words
                orderby w
                select w;
            var wordList = sortedWords.ToList();
            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }
        }
        public static void ToDictionary()
        {
            var scoreRecords = new[] {  new {   Name = "Ankur", Score = 89},
                                        new {   Name = "Vishwambhar", Score = 76},
                                        new {   Name = "Umesh", Score = 68},
                                        new {   Name = "Neha", Score = 72},
                                        new {   Name = "Priyadarshani", Score = 76},
                                        new {   Name = "Tukaram", Score = 45},
                                        new {   Name = "Swarali", Score = 45},
                                        new {   Name = "Rutuja", Score = 45}
            };
            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);  
        }
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
        public static Product GetFirstProduct()
        {
            List<Product> products = GetAllProducts();
            Product product5 = products.FirstOrDefault(p => p.ID == 5);
            return product5;
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
            allProducts.Add(new Product { ID = 1, Title = "Gerbera", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000 });
            allProducts.Add(new Product { ID = 2, Title = "Rose", Description = "Valentine Flower", UnitPrice = 15, Category = "Flower", Quantity = 7000 ,Likes=4000 });
            allProducts.Add(new Product { ID = 3, Title = "Lotus", Description = "Worship Flower", UnitPrice = 26, Category = "Flower", Quantity = 3400,Likes=4000  });
            allProducts.Add(new Product { ID = 4, Title = "Carnation", Description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", UnitPrice = 16, Category = "Flower", Quantity = 27000,Likes=4000  });
            allProducts.Add(new Product { ID = 5, Title = "Lily", Description = "Lilies are among the most popular flowers in the U.S.", UnitPrice = 6, Category = "Flower", Quantity = 1000,Likes=4000  });
            allProducts.Add(new Product { ID = 6, Title = "Jasmine", Description = "Jasmine is a genus of shrubs and vines in the olive family", UnitPrice = 26, Category = "Flower", Quantity = 2000 ,Likes=4000 });
            allProducts.Add(new Product { ID = 7, Title = "Daisy", Description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", UnitPrice = 36, Category = "Flower", Quantity = 159,Likes=4000  });
            allProducts.Add(new Product { ID = 8, Title = "Aster", Description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", UnitPrice = 16, Category = "Flower", Quantity = 67,Likes=4000  });
            allProducts.Add(new Product { ID = 9, Title = "Daffodil", Description = "Wedding Flower", UnitPrice = 6, Category = "Flower", Quantity = 5000,Likes=4000  });
            allProducts.Add(new Product { ID = 10, Title = "Dahlia", Description = "Dahlias are a popular and glamorous summer flower.", UnitPrice = 7, Category = "Flower", Quantity = 0,Likes=4000  });
            allProducts.Add(new Product { ID = 11, Title = "Hydrangea", Description = "Hydrangea is the fourth wedding anniversary flower", UnitPrice = 12, Category = "Flower", Quantity = 0,Likes=4000  });
            allProducts.Add(new Product { ID = 12, Title = "Orchid", Description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", UnitPrice = 10, Category = "Flower", Quantity = 700,Likes=4000  });
            allProducts.Add(new Product { ID = 13, Title = "Statice", Description = "Surprise them with this fresh, fabulous array of Statice flowers", UnitPrice = 16, Category = "Flower", Quantity = 1500,Likes=4000  });
            allProducts.Add(new Product { ID = 14, Title = "Sunflower", Description = "Sunflowers express your pure love.", UnitPrice = 8, Category = "Flower", Quantity = 2300,Likes=4000  });
            allProducts.Add(new Product { ID = 15, Title = "Tulip", Description = "Tulips are the quintessential spring flower and available from January to June.", UnitPrice = 17, Category = "Flower", Quantity = 10000,Likes=4000  });
            return allProducts;
        }
        public static List<Product> GetAllProductsFromDatabase()
        {
            List<Product> allProducts = new List<Product>();
            return allProducts;
        }
    }
}
