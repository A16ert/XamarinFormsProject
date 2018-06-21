using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.ViewModels.Authorization
{
    class EnteringCodeViewModel : BaseViewModel
    {
        string _code = string.Empty;
        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged();
            }
        }

        public EnteringCodeViewModel()
        {
            SendCodeCommand = new Command(SendCode);
        }
        
        public Command SendCodeCommand { get; private set; }

        private void SendCode()
        {
            App.GoToRoot();
        }
    }
}
