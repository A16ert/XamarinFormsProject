using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.ViewModels.Cards
{
    class BarCodeViewModel : BaseViewModel
    {
        public string BarCodeNumber
        {
            get => barCodeNumber;

            set
            {
                barCodeNumber = value;
                OnPropertyChanged();
            }
        }

        public string ImageSource
        {
            get => imageSource;

            set
            {
                imageSource = value;
                OnPropertyChanged();
            }
        }

        public BarCodeViewModel()
        {
            BarCodeNumber = "0181-983-3288-3";
        }

        private string barCodeNumber = string.Empty;

        private string imageSource = string.Empty;
    }
}
