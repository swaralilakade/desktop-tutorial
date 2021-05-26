
using System;

namespace PaymentProcessing

{

    public class CreditCardPayment : Payment 
    {

        public string name, expDate, number;

        CreditCardPayment(double value, string name, string expDate, string number) 
        {
            this.cash=value;
            this.number = number;
            this.expDate = expDate;
            this.name = name;
        }

        public  override void PaymentDetails() {

        Console.WriteLine("The payment of $" + this.cash + " through the card " + this.number
            + ",  and expire date "	+ this.expDate + ", and the owner name: " + this.name + ".");
        }

    }

}