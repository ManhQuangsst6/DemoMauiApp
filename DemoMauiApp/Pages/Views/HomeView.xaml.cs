using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Pages.ViewModels;

namespace DemoMauiApp.Pages.Views;

public partial class HomeView : BaseContentView
{

    public HomeView(IAppNavigator appNavigator)
    {
        InitializeComponent();
        BindingContext = new HomeViewModel(appNavigator);
    }
}