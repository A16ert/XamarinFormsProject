using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using XamarinProjectSimple.Models.CardsModels;
using XamarinProjectSimple.Services.Cards;
using Xamarin.Forms;

namespace XamarinProjectSimple.ViewModels.Cards
{
    class CardsViewModel : BaseViewModel
    {
        public int SelectedFilterIndex { get; set; }

        public List<CardsGroup> CardsList { get; set; }

        public CardsViewModel()
        {
            cardService = DependencyService.Get<ICardService>();

            var list = cardService.GetAll();

            CardsList = new List<CardsGroup>();

            var group = list.GroupBy(x => x.FirstLetter);

            foreach (var item in group)
            {
                CardsList.Add(new CardsGroup(item.Key, item));
            }

            OnPropertyChanged(nameof(CardsList));
        }

        private ICardService cardService;
        private ObservableCollection<CardModel> _cardsList { get; set; }
    }

}
