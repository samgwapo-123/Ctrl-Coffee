using System.ComponentModel.DataAnnotations;

namespace ExamApp.Models;

public class CheckoutModel
{
    [Required(ErrorMessage = "Please enter your name.")]
    public string Name { get; set; } = "";

    [Required(ErrorMessage = "Please enter your contact number.")]
    [MinLength(7, ErrorMessage = "Contact number is too short.")]
    public string Contact { get; set; } = "";
}