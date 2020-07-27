namespace ServiceReqApp.Domain
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Information { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}