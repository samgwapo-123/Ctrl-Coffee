using ExamApp.Models;

namespace ExamApp.Services;

public class CartService
{
    private readonly List<CartItem> _items = new();

    public IReadOnlyList<CartItem> Items => _items;
    public int Count => _items.Sum(i => i.Quantity);
    public decimal Total => _items.Sum(i => i.LineTotal);

    public event Action? OnChange;

    public void Add(Product product)
    {
        var existing = _items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existing is null) _items.Add(new CartItem(product));
        else existing.Increase();
        OnChange?.Invoke();
    }

    public void Increase(int id)
    {
        _items.FirstOrDefault(i => i.Product.Id == id)?.Increase();
        OnChange?.Invoke();
    }

    public void Decrease(int id)
    {
        var item = _items.FirstOrDefault(i => i.Product.Id == id);
        if (item is null) return;
        if (!item.Decrease()) _items.Remove(item);
        OnChange?.Invoke();
    }

    public void Remove(int id)
    {
        _items.RemoveAll(i => i.Product.Id == id);
        OnChange?.Invoke();
    }

    public void Clear()
    {
        _items.Clear();
        OnChange?.Invoke();
    }
}