class CartItem
{
    public CartItem()
    {

    }

    public CartItem(int cartId)
    {
        
    }

    public CartItem(Product product, int quantity, int cartId)
    {
        Product = product;
        Quantity = quantity;
        CartId = cartId;
    }

    public int CartId { get; set; }
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return $"{Product} {Quantity}";
    }

}
