using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Features.Pages.ViewModels;

namespace DemoMauiApp.Features.Pages.Views;

public partial class DashboardView : BaseContentView
{
    public DashboardView(IAppNavigator appNavigator)
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel(appNavigator);
    }
}