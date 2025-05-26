using CommunityToolkit.Mvvm.Input;
using DemoMauiApp.CoreMVVM.Navigation;
using Serilog;
using System.Windows.Input;

namespace DemoMauiApp.CoreMVVM.MVVM
{
    public abstract class BaseViewModel : BaseModel
    {

        private bool isBusy;

        ICommand? backCommand;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy != value)
                {
                    isBusy = value;
                    OnPropertyChanged(nameof(IsBusy));
                }
            }
        }

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
            backCommand = new RelayCommand(() => AppNavigator.GoBackAsync(data: GetType().FullName));
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
    }
}
