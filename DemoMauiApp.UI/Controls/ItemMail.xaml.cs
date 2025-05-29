namespace DemoMauiApp.UI.Controls;

public partial class ItemMail : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
       nameof(Name),
       typeof(string),
       typeof(ItemMail),
       default(string),
       BindingMode.TwoWay);

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public static readonly BindableProperty EmailAddressProperty = BindableProperty.Create(
        nameof(EmailAddress),
        typeof(string),
        typeof(ItemMail),
        default(string),
        BindingMode.TwoWay);
    public string EmailAddress
    {
        get => (string)GetValue(EmailAddressProperty);
        set => SetValue(EmailAddressProperty, value);
    }
    public static readonly BindableProperty ImageUrlProperty = BindableProperty.Create(
        nameof(ImageUrl),
        typeof(string),
        typeof(ItemMail),
        default(string),
        BindingMode.TwoWay);
    public string ImageUrl
    {
        get => (string)GetValue(ImageUrlProperty);
        set => SetValue(ImageUrlProperty, value);
    }
    public ItemMail()
    {
        InitializeComponent();
    }
}