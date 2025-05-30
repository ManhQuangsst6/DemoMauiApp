using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Features.Pages.ViewModels;
using DemoMauiApp.UI.Extensions;

namespace DemoMauiApp.Features.Pages.Views;

public partial class DashboardView : BaseContentView
{
    public DashboardView(IAppNavigator appNavigator)
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(appNavigator);
    }



    private void ScrollView_Loaded(object sender, EventArgs e)
    {
        scrollView.SetCustomCursor(UI.Enums.CursorIcon.Arrow, this.Handler?.MauiContext);
    }
}