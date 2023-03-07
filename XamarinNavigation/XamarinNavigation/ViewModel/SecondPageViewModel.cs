using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinNavigation.ViewModel
{
    public class SecondPageViewModel : INotifyPropertyChanged
    {
        private string _text = "Welcome to the second page Nate!";

        public SecondPageViewModel()
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

