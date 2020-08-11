using ServiceReqApp.Domain;

namespace ServiceReqApp.Infrastructure.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}