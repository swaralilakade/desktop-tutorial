using System;
namespace Banking{

    // Interfaces are used for defining contract, Policy, Agreement
    // end point
    // can not  be used to create instnace
    // intefaces are implemented by classes
    // 
    public interface IAccontDetails
    {

        // Rules to be followed by derived Classes
        // Only rules are going to  implemented by dervied classes
        // as per their logic


        void ShowAccountDetails();
        Account CreateAccount();
    }
}