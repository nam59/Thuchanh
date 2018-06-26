namespace Store
{
    public class Product
    {
        private string productID;
        private string name;
        private int price;

        public Product(string productId, string name, int price)
        {
            productID = productId;
            this.name = name;
            this.price = price;
        }

        public string ProductId
        {
            get => productID;
            set => productID = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Price
        {
            get => price;
            set => price = value;
        }
    }
}
