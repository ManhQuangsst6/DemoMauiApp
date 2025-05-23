using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;

namespace DemoMauiApp.Pages.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private object selectedItem;

        public MainViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
        }
    }
}
