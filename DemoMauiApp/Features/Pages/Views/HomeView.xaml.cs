using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.Features.Pages.ViewModels;
using DemoMauiApp.UI.Extensions;

namespace DemoMauiApp.Features.Pages.Views;

public partial class HomeView : BaseContentView
{
    private readonly IMainService mainService;
    public HomeView(IAppNavigator appNavigator, IMainService mainService)
    {
        InitializeComponent();
        this.mainService = mainService;
        BindingContext = new HomeViewModel(appNavigator, mainService);
    }

    private void StackLayout_Loaded(object sender, EventArgs e)
    {
        aa.SetCustomCursor(UI.Enums.CursorIcon.Arrow, this.Handler?.MauiContext);
    }
}