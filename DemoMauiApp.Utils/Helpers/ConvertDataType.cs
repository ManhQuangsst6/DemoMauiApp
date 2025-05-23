namespace DemoMauiApp.Utils.Helpers
{
    public static class ConvertDataType
    {
        public static string ConvertToString(this DateTime date)
        {
            return date.ToString("yyyy/MM/dd");
        }
    }
}
