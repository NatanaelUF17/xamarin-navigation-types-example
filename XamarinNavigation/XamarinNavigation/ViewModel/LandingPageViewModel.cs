using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinNavigation.ViewModel
{
	public class LandingPageViewModel : INotifyPropertyChanged
	{
		private string _text;

		public LandingPageViewModel()
		{
		}

		public string Text
		{
			get => _text;
			set
			{
				if (_text == value) return;

				_text = value;
				OnPropertyChanged();
			}
		}

        public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
    }
}

