using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.Pages.ViewModels;

namespace DemoMauiApp.Pages.Views;

public partial class MainPage : BasePage
{
    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        BindingContext =vm;
    }
}