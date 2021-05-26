using System;

namespace Banking {
    public class Handler {
        public  void BlockAccount(){          
            Console.WriteLine( " The Account has been blocked....");
        }

        public  void SendEmailNotification(){
             Console.WriteLine( "Email notification has been sent to registered email address");    
        }
        public void PayIncomeTax(){
             Console.WriteLine( " Income tax has been deducted from your Account by Order...");
        }

        public void PayServiceTax(){
             Console.WriteLine( " Service tax has been deducted from your Account by Order...");
        }

        public void PayProfessionalTax(){
             Console.WriteLine( " Professional tax has been deducted from your Account by Order...");
    
        }

    }
}