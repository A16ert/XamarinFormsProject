using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using Xamarin.Forms;
using XamarinProjectSimple.Models.ShopModels;
using XamarinProjectSimple.Services.Shop;

namespace XamarinProjectSimple.ViewModels.Shop
{
    public class ShopsViewModel : BaseViewModel
    {
        public ObservableCollection<ShopModel> ShopsList
        {
            get => _shopsList;

            private set
            {
                _shopsList = value;
                OnPropertyChanged();
            }

        }

        public Command<object> OpenDescriptionCommand { get; private set; }


        public ShopsViewModel()
        {
            Title = "Магазин";
            _shopsService = DependencyService.Get<IShopsService>();

            ShopsList = new ObservableCollection<ShopModel>( _shopsService.GetShopsList());

            OpenDescriptionCommand = new Command<object>(OpenDescription);
        }

        private ObservableCollection<ShopModel> _shopsList;

        private IShopsService _shopsService;

        private void OpenDescription(object model)
        {

        }
    }
}
