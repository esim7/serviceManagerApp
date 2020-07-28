using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class UserDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }

        public UserDto()
        {
            var user = new User();
            
        }
    }
}