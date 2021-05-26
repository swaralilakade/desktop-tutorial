using System;


namespace Banking{

   public class SavingAccountDetails:IAccontDetails
   {

      void IAccontDetails.ShowAccountDetails(){
            Console.WriteLine("Saving:Show Account Details");
      }

        Account IAccontDetails.CreateAccount(){  
            Console.WriteLine("Creating  Saving Account instance"); 
            return Account.Create(15000);
        }

    }
}