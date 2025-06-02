using System.Globalization;

namespace DemoMauiApp.UI.Converters
{
    class AlignConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is int intValue)
            {
                return intValue == 1 ? LayoutOptions.End : LayoutOptions.Start;
            }
            return LayoutOptions.Start;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
