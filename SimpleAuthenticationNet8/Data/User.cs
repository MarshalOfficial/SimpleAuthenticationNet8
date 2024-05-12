using Microsoft.AspNetCore.Identity;

namespace SimpleAuthenticationNet8.Data
{
    public class User : IdentityUser
    {
        public string? TestProp { get; set; }
    }
}