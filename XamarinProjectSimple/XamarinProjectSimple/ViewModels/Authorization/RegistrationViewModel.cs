using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.ViewModels.Authorization
{
    class RegistrationViewModel : BaseViewModel
    {
        public event Action RegisterIsSuccsess = delegate {};

        private Dictionary<int, string> _sexDictionary;
        public Dictionary<int, string> SexDictionary
        {
            get => _sexDictionary;

            set
            {
                _sexDictionary = value;
                OnPropertyChanged();
            }
        }

        public RegistrationViewModel()
        {
            SexDictionary = new Dictionary<int, string>
            {
                { 0, "Мужской" },
                { 1, "Женский" }
            };

            RegisterCommand = new Command(RegisterUser);
        }

        public Command RegisterCommand { get; private set; }

        private void RegisterUser()
        {
            RegisterIsSuccsess.Invoke();
        }
    }
}
