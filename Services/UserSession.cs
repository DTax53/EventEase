// Services/UserSession.cs
namespace EventEase.Services
{
    public class UserSession
    {
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;
        public bool IsRegistered { get; set; }
        public int RegisteredEventId { get; set; }
    }
}
