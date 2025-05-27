using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.DataAccess.Models;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Pages.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private IMainService _mainService;
        private string test;
        public string Test
        {
            get => test;
            set
            {
                test = value;
                OnPropertyChanged(nameof(Test));
            }
        }
        public ObservableCollection<PlayLists> PlayLists { get; set; }
        public HomeViewModel(IAppNavigator appNavigator, IMainService mainService) : base(appNavigator)
        {
            _mainService = mainService;
            var playListDB = _mainService.GetPlayLists();
            PlayLists = new ObservableCollection<PlayLists>(playListDB);
        }
    }
}
