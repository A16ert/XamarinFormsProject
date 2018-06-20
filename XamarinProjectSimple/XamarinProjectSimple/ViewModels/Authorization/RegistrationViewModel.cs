using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.ViewModels.Authorization
{
    class RegistrationViewModel : BaseViewModel
    {
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

        }
    }
}
