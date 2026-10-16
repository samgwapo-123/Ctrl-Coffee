using ExamApp.Models;

namespace ExamApp.Services;

public class BookingService
{
    private readonly List<RepairBooking> _bookings = new();

    public static readonly string[] Slots =
        { "9:00 AM", "10:00 AM", "11:00 AM", "1:00 PM", "2:00 PM", "3:00 PM", "4:00 PM" };

    public IReadOnlyList<RepairBooking> Bookings => _bookings;
    public RepairBooking? Latest => _bookings.LastOrDefault();

    public bool IsTaken(DateTime date, string slot) =>
        _bookings.Any(b => b.Date.Date == date.Date && b.TimeSlot == slot);

    public RepairBooking Add(RepairBooking booking)
    {
        booking.Reference = $"BB-{1000 + _bookings.Count + 1}";
        _bookings.Add(booking);
        return booking;
    }
}