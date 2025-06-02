using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Features.Pages.ViewModels;

namespace DemoMauiApp.Features.Pages.Views;

public partial class TicketView : BaseContentView
{
    public TicketView(IAppNavigator appNavigator)
    {
        InitializeComponent();
        BindingContext = new TicketViewModel(appNavigator);
    }
}