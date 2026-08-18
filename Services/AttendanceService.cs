namespace EventEase.Services
{
    public class AttendanceService
    {
        private readonly List<(int EventId, string UserName, string UserEmail)> attendance 
            = new List<(int, string, string)>();

        public void RegisterUser(int eventId, string name, string email)
        {
            attendance.Add((eventId, name, email));
        }

        public IEnumerable<(int EventId, string UserName, string UserEmail)> GetAttendance()
        {
            return attendance;
        }
    }
}
