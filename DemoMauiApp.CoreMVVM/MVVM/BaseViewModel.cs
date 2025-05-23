using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DemoMauiApp.CoreMVVM.Navigation;
using Serilog;

namespace DemoMauiApp.CoreMVVM.MVVM
{
    public abstract partial class BaseViewModel : ObservableRecipient
    {

        [ObservableProperty]
        protected bool isBusy;

        protected async Task ExecuteCommandAsync(Func<Task> action)
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                await action();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected void ExecuteCommand(Action action)
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;
                action();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        protected IAppNavigator AppNavigator { get; }

        protected BaseViewModel(IAppNavigator appNavigator)
        {
            AppNavigator = appNavigator;
        }

        public virtual Task OnAppearingAsync()
        {
            System.Diagnostics.Debug.WriteLine($"{GetType().Name}.{nameof(OnAppearingAsync)}");

            return Task.CompletedTask;
        }

        public virtual Task OnDisappearingAsync()
        {
            System.Diagnostics.Debug.WriteLine($"{GetType().Name}.{nameof(OnDisappearingAsync)}");

            return Task.CompletedTask;
        }

        [RelayCommand]
        protected virtual Task BackAsync() => AppNavigator.GoBackAsync(data: GetType().FullName);
    }
}
