using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinProjectSimple.Models.CardsModels;
using XamarinProjectSimple.Services.Cards;

namespace XamarinProjectSimple.ViewModels.Cards
{
    public class AddingCardViewModel : BaseViewModel
    {
        public List<CardsGroup> CardsList { get; set; }

        public AddingCardViewModel()
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
