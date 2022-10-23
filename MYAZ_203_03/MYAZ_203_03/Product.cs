class Product
{
    public Product()
    {
    }

    public Product(double price, string productName)
    {
        Price = price;
        ProductName = productName;
    }

    public double Price { get; set; }
    public int ProductId { get; set; }
    public string ProductName { get; set; }

    public override string ToString()
    {
        return $"{ProductName} {Price}";
    }

}
