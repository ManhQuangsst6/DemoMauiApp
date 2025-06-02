using DemoMauiApp.UI.Enums;
using DemoMauiApp.UI.Extensions;

namespace DemoMauiApp.UI.Controls;

public partial class ItemArtist : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(
       nameof(Name),
       typeof(string),
       typeof(ItemArtist),
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
        typeof(ItemArtist),
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
        typeof(ItemArtist),
        default(string),
        BindingMode.TwoWay);
    public string ImageLink
    {
        get => (string)GetValue(ImageLinkProperty);
        set => SetValue(ImageLinkProperty, value);
    }
    public ItemArtist()
    {
        InitializeComponent();
    }

    private void Label_Loaded(object sender, EventArgs e)
    {
#if WINDOWS
        if (sender is Label label && label.Handler?.MauiContext is IMauiContext context)
        {
            label.SetCustomCursor(CursorIcon.Hand, context);
        }
#endif
    }

    private void Label_Loaded_1(object sender, EventArgs e)
    {
#if WINDOWS
        if (sender is Label label && label.Handler?.MauiContext is IMauiContext context)
        {
            label.SetCustomCursor(CursorIcon.Hand, context);
        }
#endif
    }

    private void Image_Loaded(object sender, EventArgs e)
    {
#if WINDOWS
        if (sender is Image image && image.Handler?.MauiContext is IMauiContext context)
        {
            image.SetCustomCursor(CursorIcon.Hand, context);
        }
#endif
    }

    private void Label_Loaded_2(object sender, EventArgs e)
    {
        if (sender is Label label && label.Handler?.MauiContext is IMauiContext context)
        {
            label.SetCustomCursor(CursorIcon.Hand, context);
        }
    }
}