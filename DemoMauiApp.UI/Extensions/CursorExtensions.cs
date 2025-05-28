using DemoMauiApp.UI.Enums;
using Microsoft.Maui.Platform;
using Microsoft.UI.Input;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Input;
using System.Reflection;
using Windows.UI.Core;

namespace DemoMauiApp.UI.Extensions
{
    public static class CursorExtensions
    {
        public static void SetCustomCursor(this VisualElement visualElement, CursorIcon cursor, IMauiContext? mauiContext)
        {
            ArgumentNullException.ThrowIfNull(mauiContext);
            UIElement view = visualElement.ToPlatform(mauiContext);
            view.PointerEntered += ViewOnPointerEntered;
            view.PointerExited += ViewOnPointerExited;
            void ViewOnPointerExited(object sender, PointerRoutedEventArgs e)
            {
                view.ChangeCursor(InputCursor.CreateFromCoreCursor(new CoreCursor(GetCursor(CursorIcon.Arrow), 1)));
            }
            void ViewOnPointerEntered(object sender, PointerRoutedEventArgs e)
            {
                view.ChangeCursor(InputCursor.CreateFromCoreCursor(new CoreCursor(GetCursor(cursor), 1)));
            }
        }

        static CoreCursorType GetCursor(CursorIcon cursor)
        {
            return cursor switch
            {
                CursorIcon.Hand => CoreCursorType.Hand,
                CursorIcon.IBeam => CoreCursorType.IBeam,
                CursorIcon.Cross => CoreCursorType.Cross,
                CursorIcon.Arrow => CoreCursorType.Arrow,
                CursorIcon.SizeAll => CoreCursorType.SizeAll,
                CursorIcon.Wait => CoreCursorType.Wait,
                _ => CoreCursorType.Arrow,
            };
        }
        public static void TrySetCursor(this BindableObject bindable, CursorIcon cursor)
        {
#if WINDOWS
            if (bindable is IElement element && element.Handler is IViewHandler handler)
            {
                if (handler.PlatformView is UIElement uiElement)
                {
                    uiElement.PointerEntered += (s, e) =>
                    {
                        uiElement.ChangeCursor(InputCursor.CreateFromCoreCursor(new CoreCursor(GetCursor(cursor), 1)));
                    };
                    uiElement.PointerExited += (s, e) =>
                    {
                        uiElement.ChangeCursor(InputCursor.CreateFromCoreCursor(new CoreCursor(CoreCursorType.Arrow, 1)));
                    };
                }
            }
#endif
        }

        public static void ChangeCursor(this UIElement uiElement, InputCursor cursor)
        {
            var type = typeof(UIElement);
            type.InvokeMember(
                "ProtectedCursor",
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.SetProperty,
                null,
                uiElement,
                new object[] { cursor }
            );
        }

    }

}


