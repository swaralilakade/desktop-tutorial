using System;


namespace Banking{
    public class RecurringAccountDetails:IAccontDetails{

        
      void IAccontDetails.ShowAccountDetails(){
                Console.WriteLine("Recurring :Show Account Details");
      }

        Account IAccontDetails.CreateAccount(){  
            // Create Recurring Account instance
            Console.WriteLine("Creating  Recurring Account instance");
            return Account.Create(15000);
        }

    }

    }
