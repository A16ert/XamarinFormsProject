using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinProjectSimple.Services.Authorization;

namespace XamarinProjectSimple.ViewModels.Authorization
{
    class AuthViewModel : BaseViewModel
    {
        IAuthService _authSerivce;

        string phoneNumber = string.Empty;
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }
        string code = string.Empty;
        public string Code
        {
            get => code;

            set
            {
                code = value;
                OnPropertyChanged();
            }
        }

        public AuthViewModel()
        {
            _authSerivce = new AuthService();

            EnterCommand = new Command(Enter);
        }

        public ICommand EnterCommand { get; }

        private void Enter()
        {
            App.GoToRoot();
        }
    }
}
