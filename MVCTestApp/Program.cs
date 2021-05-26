using System;

namespace MVCTestApp
{
    
    class Product 
    {
        public int ID{get;set;}
        public String Title{get;set;}
        public String Description{get;set;} 
    }
  
    class ProductView 
    {
        public void Render(String title, String description)
        {
           Console.WriteLine("Product: ");
           Console.WriteLine("Title: " + title);
           Console.WriteLine("Description: " + description);
        }
    }
  
    class ProductsController 
    {
        public Product model;
        public ProductView view;
    
        public ProductsController(Product model, ProductView view)
        {
            this.model = model;
            this.view = view;
        }
    
        public void SetTitle(String name)
        {
            model.Title=name;        
        }
    
        public String GetTitle()
        {
            return model.Title;        
        }
    
        public void SetDescription(String description)
        {
            model.Description=description;        
        }
    
        public String GetDescription()
        {
            return model.Description;        
        }
    
        public void updateView()
        {                
            view.Render(model.Title, model.Description);
        }    
    }
    
    class Program 
    {
        public static void Main(string[] args) 
        {
            Product model  = RetriveFromDatabase(); 
            ProductView view = new ProductView();
            ProductsController controller = new ProductsController(model, view);
            controller.updateView();
            controller.SetTitle("Lotus");
            controller.updateView();
        }
        private static Product RetriveFromDatabase()
        {
            Product theProduct = new Product();
            theProduct.Title="Rose";
            theProduct.Description="Valentine Flower";
            return theProduct;
        }
    }   
}
