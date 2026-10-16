namespace ExamApp.Models;

public class CartItem
{
    public CartItem(Product product, int quantity = 1)
    {
        Product = product;
        Quantity = quantity;
    }

    public Product Product { get; }
    public int Quantity { get; private set; }
    public decimal LineTotal => Product.Price * Quantity;

    public void Increase() => Quantity++;

    // Returns false when the quantity is already 1 (the caller should remove the item).
    public bool Decrease()
    {
        if (Quantity <= 1) return false;
        Quantity--;
        return true;
    }
}