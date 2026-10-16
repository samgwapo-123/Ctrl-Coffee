namespace ExamApp.Models;

public static class ProductData
{
    public static readonly List<Product> All = new()
    {
        new Drink(1, "Café Latte", 120, "☕", "Smooth espresso with steamed milk."),
        new Drink(2, "Iced Americano", 110, "🧊", "Bold espresso over ice."),
        new Drink(3, "Caramel Macchiato", 150, "🍮", "Sweet caramel, espresso, and milk."),
        new Drink(4, "Matcha Latte", 140, "🍵", "Creamy ceremonial-style matcha."),
        new Drink(5, "Cold Brew", 130, "🥤", "Steeped 18 hours, ultra smooth."),
        new Pastry(6, "Butter Croissant", 85, "🥐", "Flaky, freshly baked every morning."),
        new Pastry(7, "Blueberry Muffin", 75, "🫐", "Soft muffin packed with blueberries."),
        new Pastry(8, "Ensaymada", 65, "🥖", "Classic buttery Filipino favorite."),
        new Pastry(9, "Cheesecake Slice", 140, "🍰", "Creamy slice, perfect with coffee."),
        new Gadget(10, "USB-C Cable", 250, "🔌", "Durable 1-meter braided cable."),
        new Gadget(11, "20W Fast Charger", 590, "⚡", "Charge up to 50% in 30 minutes."),
        new Gadget(12, "Wireless Earbuds", 799, "🎧", "Clear sound for your coffee break."),
        new Gadget(13, "Power Bank 10,000mAh", 1200, "🔋", "Keeps your phone alive all day."),
        new Gadget(14, "Phone Case", 350, "📲", "Slim protective case."),
        new Gadget(15, "Smart Watch", 1999, "⌚", "Track steps, sleep, and notifications."),
        new Gadget(16, "Bluetooth Speaker", 1100, "🔊", "Compact speaker with deep bass.")
    };
}