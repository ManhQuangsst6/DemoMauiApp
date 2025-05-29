using Telerik.Maui.Controls.Compatibility.Chart;

namespace DemoMauiApp.UI.Extensions
{
    public class DateLabelFormatter : LabelFormatterBase<DateTime>
    {
        public override string FormatTypedValue(DateTime value)
        {
            if (value.Day == 1)
            {
                return value.Day + "st";
            }
            else if (value.Day == 2)
            {
                return value.Day + "nd";
            }
            else if (value.Day == 3)
            {
                return value.Day + "rd";
            }
            else
            {
                return value.Day + "th";
            }
        }
    }
}
