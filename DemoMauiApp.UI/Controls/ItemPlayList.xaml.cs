namespace DemoMauiApp.UI.Controls;

public partial class ItemPlayList : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
        nameof(Name),
        typeof(string),
        typeof(ItemPlayList),
        default(string),
        BindingMode.TwoWay);

    public string Name
    {
        get => (string)GetValue(NameProperty);
        set => SetValue(NameProperty, value);
    }
    public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
        nameof(Description),
        typeof(string),
        typeof(ItemPlayList),
        default(string),
        BindingMode.TwoWay);
    public string Description
    {
        get => (string)GetValue(DescriptionProperty);
        set => SetValue(DescriptionProperty, value);
    }
    public static readonly BindableProperty ImageLinkProperty = BindableProperty.Create(
        nameof(ImageLink),
        typeof(string),
        typeof(ItemPlayList),
        default(string),
        BindingMode.TwoWay);
    public string ImageLink
    {
        get => (string)GetValue(ImageLinkProperty);
        set => SetValue(ImageLinkProperty, value);
    }
    public ItemPlayList()
    {
        InitializeComponent();
    }
}