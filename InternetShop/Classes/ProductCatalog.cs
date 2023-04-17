namespace InternetShop
{
    internal class ProductCatalog
    {
        private List<IProduct> products;
        public ProductCatalog()
        {
            products = new List<IProduct>();
        }
        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }
        public void RemoveProduct(int productId)
        {
            IProduct productToRemove = products.FirstOrDefault(p => p.Id == productId);

            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
        }
        public List<IProduct> GetAllProducts()
        {
            return products;
        }

        public IProduct GetProductDetails(int productId)
        {
            return products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
