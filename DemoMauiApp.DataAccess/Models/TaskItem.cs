namespace DemoMauiApp.DataAccess.Models
{
    public class TaskItem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Project { get; set; }
        public string Priority { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
    }
}
