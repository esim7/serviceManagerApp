using Microsoft.AspNetCore.Identity;
using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class UserDto : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public UserProfile UserProfile { get; set; }
        public Employee Employee { get; set; }
    }
}