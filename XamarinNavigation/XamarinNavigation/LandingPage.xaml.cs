using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinNavigation.ViewModel;

namespace XamarinNavigation
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private static bool _showAnimation = true;

        private static bool ToggleAnimation()
        {
            _showAnimation = !_showAnimation;
            return _showAnimation;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var landingPageViewModel = BindingContext as LandingPageViewModel;
            if (landingPageViewModel == null) return;
                 
            var secondPage = new SecondPage();
            var secondPageViewModel = secondPage.BindingContext as SecondPageViewModel;

            secondPageViewModel.Text = landingPageViewModel.Text;

            await Navigation.PushAsync(secondPage, ToggleAnimation());
        }
    }
}

