using Microsoft.AspNetCore.Identity;

namespace EmpManagementSystem.Models
{
    public class User: IdentityUser
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
    }
}
