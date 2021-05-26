/*
    Use them whenever you feel you can reduce your lines of code. 
    Keep in mind the maintainability while reducing the number of lines of code.
    People think that Lambda Expressions are awkward looking code, 
    but I'm telling you its worth it to use them in code wisely.
*/
using System;

namespace LambdaTest
{
     // Object Oriented typesafe managed function Pointer
    delegate void doSomething(); 
    delegate int anonymousOperation1(int i); 
    delegate int anonymousOperation2(int a, int b);
   

  /*  class Program
    {
        static void Main(string[] args)
        {
            doSomething IamVoid = () => { Console.WriteLine("Hello there! I take nothing and return nothing"); };  
            IamVoid();  

            anonymousOperation1 proxy = new anonymousOperation1(  
                                                        delegate(int x){  
                                                            return x * 2;
                                                        }
                                    );  
            Console.WriteLine("{0}", proxy(5));  
            //(input parameters) => Expression; 
            anonymousOperation1 proxy2 = x => x * 2;  //x => x * 2 is the expression that is the known as Lambda Expression
            anonymousOperation2 proxyBigInteger = (x, y) => { if (x > y) return x; else return y; };  // Logic
            int result=proxyBigInteger(10,15);  // invoking agent
                                      // reference pointing to instance of delegate
                                      // delegate is registered with  logic
                                      // dynamic invoking logic
            Console.WriteLine(result);  
            Console.WriteLine("{0}", proxy2(25));  
            Console.WriteLine("Hello World!");
        }
    } */
}
