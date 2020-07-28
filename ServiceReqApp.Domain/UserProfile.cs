namespace ServiceReqApp.Domain
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Information { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}