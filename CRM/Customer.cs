using System;
namespace CRM
{
    public class Customer
    { 
        public int Id{get;set;}
        public string Name{get;set;}
        public string ContactNumber{get;set;}
        public string Email{get;set;}
        public string Location{get;set;}
        public int Age{get;set;}

        public Customer(){
            this.Id=909;
            this.Name="swrl lkd";
            this.ContactNumber="97664585876";
            this.Email="swrl@gmail.com";
            this.Location="saswad";
            this.Age=23;
        }
        public Customer(int id,string name,string contactNumber,string email,string location,int age){
            this.Id=id;
            this.Name=name;
            this.ContactNumber=contactNumber;
            this.Email=email;
            this.Location=location;
            this.Age=age;
        }
    }
         
    }
