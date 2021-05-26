using System;
using System.Linq;
using System.Collections.Generic;

namespace AnalyticsTest
{
   public class  BusinessManager
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
    }
}