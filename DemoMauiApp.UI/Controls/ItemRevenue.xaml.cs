namespace DemoMauiApp.UI.Controls;

public partial class ItemRevenue : ContentView
{
    public ItemRevenue()
    {
        InitializeComponent();
    }
    public static readonly BindableProperty RevenueNumberProperty = BindableProperty.Create(
      nameof(RevenueNumber),
      typeof(string),
      typeof(ItemRevenue),
      default(string),
      BindingMode.TwoWay);

    public string RevenueNumber
    {
        get => (string)GetValue(RevenueNumberProperty);
        set => SetValue(RevenueNumberProperty, value);
    }
    public static readonly BindableProperty RateProperty = BindableProperty.Create(
      nameof(Rate),
      typeof(string),
      typeof(ItemRevenue),
      default(string),
      BindingMode.TwoWay);

    public string Rate
    {
        get => (string)GetValue(RateProperty);
        set => SetValue(RateProperty, value);
    }
}