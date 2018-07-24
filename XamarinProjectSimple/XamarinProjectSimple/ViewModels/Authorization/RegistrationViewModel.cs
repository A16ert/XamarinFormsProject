using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.ViewModels.Authorization
{
    class RegistrationViewModel : BaseViewModel
    {
        public event Action RegisterIsSuccsess = delegate {};

        public int SexSelectedId { get; set; }

        private DateTime _birthDateValue = DateTime.Now;
        public DateTime BirthDateValue
        {
            get => _birthDateValue;
            set
            {
                _birthDateValue = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(BirthDate));
            }
        }

        public string BirthDate => BirthDateValue.ToString("dd.MM.yyyy");

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
                { 0, "Я Мужчина" },
                { 1, "Я Женщина" }
            };
            SexSelectedId = 0;
            RegisterCommand = new Command(RegisterUser);
        }

        public Command RegisterCommand { get; private set; }

        private void RegisterUser()
        {
            RegisterIsSuccsess.Invoke();
        }
    }
}
