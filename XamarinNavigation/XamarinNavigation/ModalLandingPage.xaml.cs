using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinNavigation
{	
	public partial class ModalLandingPage : ContentPage
	{	
		public ModalLandingPage ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new NavigationPage(new LandingPage()));
        }
    }
}

