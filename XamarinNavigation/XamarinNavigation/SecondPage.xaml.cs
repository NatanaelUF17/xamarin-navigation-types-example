using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinNavigation
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
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
            await Navigation.PopModalAsync(ToggleAnimation());
        }
    }
}

