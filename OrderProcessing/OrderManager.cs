using System;
using System.Data;
using System.Collections.Generic;

namespace OrderProcessing
{
    public static class OrderManager
    { 
      public static List<Order> GetAll()
       {
           List<Order> orders= new List<Order>();
           return orders;

       }
       public static Order GetById(int orderId)
       {
           Order theOrder = null;
           return theOrder;
       }

       public static bool Delete(int orderId)
       {
           bool status = false;
           return status;
       }
       public static bool Update(Order order)
       {
           bool status = false;
           return status;
       }

       public static bool Insert(Order order)
       {
           bool status = false;
           return status;
       }
   
    }

}