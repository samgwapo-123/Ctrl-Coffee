namespace ExamApp.Models;

public class RepairService
{
    public RepairService(int id, string name, string emoji, decimal estimatedPrice, int estimatedMinutes)
    {
        Id = id;
        Name = name;
        Emoji = emoji;
        EstimatedPrice = estimatedPrice;
        EstimatedMinutes = estimatedMinutes;
    }

    public int Id { get; }
    public string Name { get; }
    public string Emoji { get; }
    public decimal EstimatedPrice { get; }
    public int EstimatedMinutes { get; }
    public string PriceText => $"₱{EstimatedPrice:N0}";
}

public static class RepairData
{
    public static readonly List<RepairService> All = new()
    {
        new(1, "Screen Replacement", "📱", 1500, 60),
        new(2, "Battery Replacement", "🔋", 900, 45),
        new(3, "Charging Port Repair", "🔌", 700, 45),
        new(4, "Software Fix", "💾", 400, 30),
        new(5, "Water Damage Check", "💧", 500, 90),
        new(6, "Diagnostic Check", "🔍", 200, 15)
    };
}