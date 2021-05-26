using System;

namespace PaymentProcessing
{
        // you can not create object from class

    // Parent Class
    // Super Class
    

    // condition: minumum one function need to be abstract
    public abstract class Payment 
    {
        protected double cash;
        public double getcash() 
        {
                return cash;
        }
        public void setcash(double newval) 
        {
                this.cash = newval;
        }
        public abstract void PaymentDetails() ;
    }
}
