using System;

namespace Banking{
    public class SalaryAccountDetails :IAccontDetails
    {
        
      void IAccontDetails.ShowAccountDetails(){
            Console.WriteLine(" Salary :Show Account Details");
      }

        Account IAccontDetails.CreateAccount(){  

            Console.WriteLine("Creating  Salary Account instance");
            // Create Salary Account 
            return Account.Create(15000);
        }

    }
        
    }
