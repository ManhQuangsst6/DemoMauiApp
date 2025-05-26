using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.CoreMVVM.Navigation;
using System.Collections.ObjectModel;

namespace DemoMauiApp.Pages.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
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
        public ObservableCollection<string> PlayLists { get; set; }
        public HomeViewModel(IAppNavigator appNavigator) : base(appNavigator)
        {
            PlayLists = new ObservableCollection<string>
            {
                "Playlist 1",
                "Playlist 2",
                "Playlist 3",
                "Playlist 4",
                "Playlist 5"
            };
            Test = "13124";
        }
    }
}
