using System.ComponentModel.DataAnnotations;

namespace proiect.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name must be at least 3 characters.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name must be at least 3 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^07[0-9]{8}$", ErrorMessage = "Invalid phone number format. It should start with 07 and have 10 digits.")]
        public string PhoneNumber { get; set; }
    }
}
