using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.Features.Pages.ViewModels;
using DemoMauiApp.UI.Extensions;
using DemoMauiApp.Utils.Resources;

namespace DemoMauiApp.Features.Pages.Views;

public partial class MainPage : BasePage
{
    private readonly IAppNavigator _appNavigator;
    private readonly IMainService _mainService;
    public MainPage(MainViewModel vm, IAppNavigator appNavigator, IMainService mainService)
    {
        InitializeComponent();
        _appNavigator = appNavigator;
        _mainService = mainService;
        BindingContext = vm;
        contentControl.Content = new HomeView(appNavigator, mainService);
    }

    private void OnSelectionChanged(object sender, EventArgs e)
    {

    }

    private void navigationView_ItemClicked(object sender, Telerik.Maui.Controls.NavigationView.NavigationViewItemEventArgs e)
    {
        var text = e.NavigationItem.Text;
        switch (text)
        {
            case var _ when text == AppResource.HomeNavigate:
                contentControl.Content = new HomeView(_appNavigator, _mainService);
                break;
            case var _ when text == AppResource.BrowseNavigate:
                contentControl.Content = new BrowseView();
                break;
            case var _ when text == AppResource.RadioNavigate:
                contentControl.Content = new HomeView(_appNavigator, _mainService);
                break;
            case var _ when text == AppResource.PlaylistsNavigate:
                contentControl.Content = new HomeView(_appNavigator, _mainService);
                break;
            case var _ when text == AppResource.SongsNavigate:
                contentControl.Content = new HomeView(_appNavigator, _mainService);
                break;
            case var _ when text == AppResource.PickNavigate:
                contentControl.Content = new HomeView(_appNavigator, _mainService);
                break;
        }
    }

    private void navigationView_Loaded(object sender, EventArgs e)
    {
        navigationView.SetCustomCursor(UI.Enums.CursorIcon.Hand, this.Handler?.MauiContext);
    }

    private void contentControl_Loaded(object sender, EventArgs e)
    {
        // navigationView.SetCustomCursor(UI.Enums.CursorIcon.Arrow, this.Handler?.MauiContext);
    }
}
