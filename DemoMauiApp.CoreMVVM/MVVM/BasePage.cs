﻿using Microsoft.Maui.Controls;

namespace DemoMauiApp.CoreMVVM.MVVM
{
    public abstract class BasePage : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (BindingContext is BaseViewModel vm)
            {
                vm.OnAppearingAsync();
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            if (BindingContext is BaseViewModel vm)
            {
                vm.OnDisappearingAsync();
            }
        }
    }
}
