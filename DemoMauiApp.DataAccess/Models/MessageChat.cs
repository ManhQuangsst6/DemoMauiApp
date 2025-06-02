namespace DemoMauiApp.DataAccess.Models
{
    public class MessageChat
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserChatId { get; set; }
        public bool IsNewTime { get; set; } = false;
    }
}
