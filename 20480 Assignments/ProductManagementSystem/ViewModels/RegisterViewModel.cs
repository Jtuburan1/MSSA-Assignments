using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }

        [Display(Description = "Options are: Customer or Employee")]
        public string? Role { get; set; }
    }
}
