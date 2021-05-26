using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace CRM
{
    public static class CustomerManager
    { 
      public static List<Customer> GetAll()
       {
           List<Customer> customers= new List<Customer>();

           customers=GetAllCustomersFromDatabase();
             return customers;
        }
        public static List<Customer> GetAllCustomersFromDatabase()
        {
            List<Customer> customers = CustomerDBManager.GetAll();
            return customers;
        }
   
       public static Customer GetById(int customerId)
       {
           /* theCustomer = null;

           theCustomer=CustomerDBManager.GetById();
           return theCustomer;     */
           //thecustomers = null;
            List<Customer> thecustomers = GetAll();
            Customer theCustomers = thecustomers.FirstOrDefault(p => p.Id == customerId);
            return theCustomers;
        }
       

       public static bool Delete(int customerId)
       {
           bool status = false;
            status=CustomerDBManager.Delete(customerId);

           return status;
       }
       public static bool Update(Customer customer)
       {
           bool status = false;
           return status;
       }

       public static bool Insert(Customer customer)
       {
           bool status = false;
           return status;
       }
   
    }

}