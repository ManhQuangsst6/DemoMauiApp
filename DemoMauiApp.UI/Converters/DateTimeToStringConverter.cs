using System.Globalization;

namespace DemoMauiApp.UI.Converters
{
    class DateTimeToStringConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is DateTime dt)
            {
                return dt.ToString("MMM d, yyyy, h:mm tt", CultureInfo.InvariantCulture);
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
