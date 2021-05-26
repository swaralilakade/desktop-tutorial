using System;

namespace OrderProcessing
{
    public class Order
    {
        public int Id{get;set;}
        public DateTime OrderDate{get;set;}
        public string Status{get;set;}
        public double TotalAmount{get;set;}
    }
}