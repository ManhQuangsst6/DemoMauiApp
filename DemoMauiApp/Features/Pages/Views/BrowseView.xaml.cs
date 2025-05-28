using DemoMauiApp.UI.Enums;
using DemoMauiApp.UI.Extensions;

namespace DemoMauiApp.Features.Pages.Views;

public partial class BrowseView : ContentView
{
    public BrowseView()
    {
        InitializeComponent();


    }

    protected override void OnParentSet()
    {
        base.OnParentSet();


    }

    private void a_Loaded(object sender, EventArgs e)
    {
#if WINDOWS
        if (this.Handler?.MauiContext is IMauiContext context)
        {
            a.SetCustomCursor(CursorIcon.Hand, context);
        }
#endif
    }
}