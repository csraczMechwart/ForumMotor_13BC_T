using Microsoft.AspNetCore.Identity;

namespace ForumMotor_13BC_T.Models
{
    public class ForumUser : IdentityUser
    {
        public string? FirstName { get; set; }
        //...
    }
}
