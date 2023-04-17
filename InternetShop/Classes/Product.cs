using InternetShop.Interfaces;

namespace InternetShop
{
    internal class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool InStock { get; set; }
        public int Quantity { get; set; }

        public Product (int id, string name, string description, double price, int quantity, bool inStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;

            InStock = IsStock(quantity);
        }

        public int AddQuantity (int quantity)
        {
            Quantity += quantity;
            return Quantity;
        }

        private bool IsStock(int quantity)
        {
            if (quantity > 0) return InStock = true;
            return InStock = false;
        }

        //public Product GetProductDetails(Product product)
        //{
        //    Id = this.Id;
        //    Name = this.Name;
        //    Description = this.Description;
        //    Price = this.Price;
        //    Quantity = this.Quantity;
        //    InStock = product.InStock;
        //    Console.WriteLine($"{Id}, {Name}, {Description}, {Price}, Quantity = {Quantity}, In Stock {InStock}");
        //    return new Product(Id,Name, Description, Price, Quantity, InStock);
        //}

        public string GetProductDetails()
        {
            string details = $"Product ID: {Id}\nName: {Name}\nPrice: {Price:C}\nDescription: {Description}\nIn Stock {InStock}\nQuantity: {Quantity}";
            return details;
        }
    }
}
