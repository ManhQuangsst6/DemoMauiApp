using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.Pages.ViewModels;

namespace DemoMauiApp.Pages.Views;

public partial class HomeView : BaseContentView
{
    private readonly IMainService mainService;
    public HomeView(IAppNavigator appNavigator,IMainService mainService)
    {
        InitializeComponent();
        BindingContext = new HomeViewModel(appNavigator, mainService);
    }
}