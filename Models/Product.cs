namespace ExamApp.Models;

public abstract class Product
{
    public int Id { get; }
    public string Name { get; }
    public decimal Price { get; }
    public string Emoji { get; }
    public string Description { get; }

    protected Product(int id, string name, decimal price, string emoji, string description)
    {
        if (price < 0) throw new ArgumentOutOfRangeException(nameof(price), "Price cannot be negative.");
        Id = id;
        Name = name;
        Price = price;
        Emoji = emoji;
        Description = description;
    }

    public abstract string Category { get; }
    public virtual string ActionLabel => "Add to cart";
    public string PriceText => $"₱{Price:N2}";

    // Fix: IDs 1 and 2 use .png; IDs 3 to 16 use .jpg; both start with '/'
   public string ImagePath => Id == 1
    ? $"/images/products/{Id}.png"
    : $"/images/products/{Id}.jpg";
}

public class Drink(int id, string name, decimal price, string emoji, string description)
    : Product(id, name, price, emoji, description)
{
    public override string Category => "Drinks";
    public override string ActionLabel => "Add to order";
}

public class Pastry(int id, string name, decimal price, string emoji, string description)
    : Product(id, name, price, emoji, description)
{
    public override string Category => "Pastries";
}

public class Gadget(int id, string name, decimal price, string emoji, string description)
    : Product(id, name, price, emoji, description)
{
    public override string Category => "Gadgets";
}