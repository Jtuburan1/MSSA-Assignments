using System.ComponentModel.DataAnnotations;
namespace EmpManagementSystem.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter a valid Username")]
        public string? UserName { get; set; }

        [Required(ErrorMessage ="Please enter a valid Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
