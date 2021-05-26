using System;


// Child Class
// Derived Class
// Sub Class

namespace PaymentProcessing{
    public class CashPayment : Payment
    {

        public CashPayment(double val) 
        {   
            this.cash=val;
        }

        public override  void PaymentDetails()
        {
            Console.WriteLine("The payment of cash:  $" + this.cash);
        }
    }

}