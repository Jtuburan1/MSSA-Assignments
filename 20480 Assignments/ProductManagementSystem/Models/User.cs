using Microsoft.AspNetCore.Identity;
namespace ProductManagementSystem.Models
{
    public class User:IdentityUser
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? Role { get; set; }
    }
}
