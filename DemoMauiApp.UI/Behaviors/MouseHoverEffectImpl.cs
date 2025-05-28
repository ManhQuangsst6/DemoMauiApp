using Microsoft.Maui.Controls.Platform;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System.Diagnostics;
using Windows.UI.Core;
[assembly: ExportEffect(typeof(DemoMauiApp.UI.Behaviors.MouseHoverEffectImpl), nameof(DemoMauiApp.UI.Behaviors.MouseHoverEffect))]

namespace DemoMauiApp.UI.Behaviors
{
    public class MouseHoverEffectImpl : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is FrameworkElement controlElement)
            {
                controlElement.PointerEntered += OnPointerEntered;
                controlElement.PointerExited += OnPointerExited;
            }
            else if (Container is FrameworkElement containerElement)
            {
                containerElement.PointerEntered += OnPointerEntered;
                containerElement.PointerExited += OnPointerExited;
            }
        }

        protected override void OnDetached()
        {
            if (Control is FrameworkElement controlElement)
            {
                controlElement.PointerEntered -= OnPointerEntered;
                controlElement.PointerExited -= OnPointerExited;
            }
            else if (Container is FrameworkElement containerElement)
            {
                containerElement.PointerEntered -= OnPointerEntered;
                containerElement.PointerExited -= OnPointerExited;
            }
        }

        private void OnPointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Debug.WriteLine("Mouse entered!");
            var window = Microsoft.Maui.Controls.Application.Current?.Windows?.FirstOrDefault();
            if (window?.Handler?.PlatformView is Microsoft.UI.Xaml.Window nativeWindow)
            {
                nativeWindow.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Hand, 1);
            }
        }

        private void OnPointerExited(object sender, PointerRoutedEventArgs e)
        {
            var window = Microsoft.Maui.Controls.Application.Current?.Windows?.FirstOrDefault();
            if (window?.Handler?.PlatformView is Microsoft.UI.Xaml.Window nativeWindow)
            {
                nativeWindow.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 0);
            }
        }
    }
}
