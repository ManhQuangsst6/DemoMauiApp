using Microsoft.Maui.Controls;

namespace DemoMauiApp.CoreMVVM.MVVM
{
    public class BaseContentView : ContentView
    {
        public BaseContentView()
        {
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }
    }
}
