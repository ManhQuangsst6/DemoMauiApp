using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Pages.ViewModels;
using DemoMauiApp.Utils.Resources;

namespace DemoMauiApp.Pages.Views;

public partial class MainPage : BasePage
{
    private readonly IAppNavigator _appNavigator;
    public MainPage(MainViewModel vm, IAppNavigator appNavigator)
    {
        InitializeComponent();
        _appNavigator = appNavigator;
        BindingContext = vm;
        contentControl.Content = new HomeView(appNavigator);
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
                contentControl.Content = new HomeView(_appNavigator);
                break;
            case var _ when text == AppResource.BrowseNavigate:
                contentControl.Content = new BrowseView();
                break;
            case var _ when text == AppResource.RadioNavigate:
                contentControl.Content = new HomeView(_appNavigator);
                break;
            case var _ when text == AppResource.PlaylistsNavigate:
                contentControl.Content = new HomeView(_appNavigator);
                break;
            case var _ when text == AppResource.SongsNavigate:
                contentControl.Content = new HomeView(_appNavigator);
                break;
            case var _ when text == AppResource.PickNavigate:
                contentControl.Content = new HomeView(_appNavigator);
                break;
        }
    }
}
