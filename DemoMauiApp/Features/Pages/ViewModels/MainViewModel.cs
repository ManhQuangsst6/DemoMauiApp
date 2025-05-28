using CommunityToolkit.Mvvm.Input;
using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using System.Windows.Input;

namespace DemoMauiApp.Features.Pages.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private object selectedItem;
        public ICommand SelectedMenuItem { set; get; }
        public MainViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
            SelectedMenuItem = new RelayCommand<object>(SelectedMenuItemAction);
        }

        private void SelectedMenuItemAction(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
