namespace DemoMauiApp.DataAccess.Models
{
    public class DatabaseSettingModel
    {
        public string ServerName { get; set; }
        public string ServerInstanceName { get; set; }
        public string Port { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUser { get; set; }
        public string DatabasePassword { get; set; }
        public string DatabaseEncryptPassword { get; set; }
    }
}
