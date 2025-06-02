namespace DemoMauiApp.UI.Controls;

public partial class ItemUserChat : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
       nameof(Name),
       typeof(string),
       typeof(ItemUserChat),
       default(string),
       BindingMode.TwoWay);

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public static readonly BindableProperty ContentDataProperty = BindableProperty.Create(
        nameof(ContentData),
        typeof(string),
        typeof(ItemUserChat),
        default(string),
        BindingMode.TwoWay);
    public string ContentData
    {
        get => (string)GetValue(ContentDataProperty);
        set => SetValue(ContentDataProperty, value);
    }
    public static readonly BindableProperty ImageUrlProperty = BindableProperty.Create(
        nameof(ImageUrl),
        typeof(string),
        typeof(ItemUserChat),
        default(string),
        BindingMode.TwoWay);
    public string ImageUrl
    {
        get => (string)GetValue(ImageUrlProperty);
        set => SetValue(ImageUrlProperty, value);
    }
    public ItemUserChat()
    {
        InitializeComponent();
    }
}