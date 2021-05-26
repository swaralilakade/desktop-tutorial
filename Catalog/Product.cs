using System;

namespace Catalog
{
    public class Product
    {


        //ecapsulated variable  are private
       /*
        private int likes;

        // Property
        public int Likes{
            get{ return likes;}   // getter function

            set{ likes=value;}    //setter function

        }
        */
       
        // How  we can write Propery 
        // Auto property get by default private variable
        public  int Likes{get;set;}
        public int Id{get;set;}
        public string Title {get;set;}
        public string Category{get;set;}
        public string Description{get;set;}
        public string ImageUrl { get; set;}
        public double UnitPrice{ get; set;}
        public int Quantity{get;set;}

        public Product(){
            this.Id=2;
            this.Title="Honda City";
            this.Description="Best Automobile";
            this.Quantity=1000;
            this.UnitPrice=1000000;
        }

        public Product(int id, string title, string description, double unitPrice, int quantity)
         {
            this.Id=id;
            this.Title=title;
            this.Description=description;
            this.Quantity=quantity;
            this.UnitPrice=unitPrice;
        }

    }
}
