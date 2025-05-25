using Microsoft.Maui.Controls;

namespace DemoMauiApp.CoreMVVM.MVVM
{
    public class BasePopup : BasePage
    {
        public BasePopup()
        {
            Shell.SetPresentationMode(this, PresentationMode.Modal);
        }
    }
}