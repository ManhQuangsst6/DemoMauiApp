using DemoMauiApp.CoreMVVM.MVVM;
using DemoMauiApp.Features.Pages.ViewModels;

namespace DemoMauiApp.Features.Pages.Views;

public partial class Chat : BasePage
{
    public Chat(ChatViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}