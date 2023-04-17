namespace InternetShop.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        double Price { get; set; }
        public int Quantity { get; set; }
        public string GetProductDetails();
    }
}
