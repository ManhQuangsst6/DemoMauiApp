namespace DemoMauiApp.DataAccess.Models
{
    public class PlayLists
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? LinkImage { get; set; }
    }
}
