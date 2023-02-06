using Microsoft.Build.Framework;

namespace EmpManagementSystem.ViewModels
{
    public class RegisterViewModel : LoginViewModel
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int PhoneNumber { get; set; }
    }
}
