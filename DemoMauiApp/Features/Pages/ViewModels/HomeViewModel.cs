using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using DemoMauiApp.DataAccess.Interfaces;
using DemoMauiApp.DataAccess.Models;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Features.Pages.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private IMainService _mainService;

        public ObservableCollection<PlayLists> PlayLists { get; set; }
        public ObservableCollection<Artist> Artists { get; set; }
        public HomeViewModel(IAppNavigator appNavigator, IMainService mainService) : base(appNavigator)
        {
            _mainService = mainService;
            var playListDB = _mainService.GetPlayLists();
            PlayLists = new ObservableCollection<PlayLists>(playListDB);
            var artists = _mainService.GetArtist();
            Artists = new ObservableCollection<Artist>(artists);
        }
    }
}
