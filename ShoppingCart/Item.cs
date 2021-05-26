namespace ShoppingCart
{
    public class Item  
    {
        // A place to store the quantity in the cart
        // This property has an implicit getter and setter.
        public int Quantity { get; set; }
    
        private int productId;
        public int ProductId {
            get { return productId; }
            set {
                // To ensure that the Prod object will be re-created
                productId = value;
            }
        }
    
        // Item constructor just needs a productId
        public Item(int productId) {
            this.ProductId = productId;
        }
    
        public bool Equals(Item item) {
            return item.ProductId == this.ProductId;
        }
    }
}