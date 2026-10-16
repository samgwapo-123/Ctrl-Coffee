using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is DateTime date && date.Date >= DateTime.Today)
            return ValidationResult.Success;
        return new ValidationResult(ErrorMessage ?? "Please pick today or a later date.");
    }
}

public class RepairBooking
{
    public string Reference { get; set; } = "";

    [Required(ErrorMessage = "Please enter your name.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter your contact number.")]
    [MinLength(7, ErrorMessage = "Contact number is too short.")]
    public string Contact { get; set; } = "";

    [Required(ErrorMessage = "Please choose your device.")]
    public string Device { get; set; } = "";

    [Required(ErrorMessage = "Please choose a repair service.")]
    public string Service { get; set; } = "";

    [Required(ErrorMessage = "Please describe the problem.")]
    [StringLength(300, ErrorMessage = "Please keep it under 300 characters.")]
    public string Issue { get; set; } = "";

    [FutureDate(ErrorMessage = "Please pick today or a later date.")]
    public DateTime Date { get; set; } = DateTime.Today.AddDays(1);

    [Required(ErrorMessage = "Please pick a time slot.")]
    public string TimeSlot { get; set; } = "";
}