using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace ServiceReqApp.Domain
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int UserProfileId { get; set; }
        public UserProfile UserProfile { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}