using System;
using System.Collections.Generic;
using System.Text;
using XamarinProjectSimple.Models.CardsModels;

[assembly: Xamarin.Forms.Dependency(typeof(XamarinProjectSimple.Services.Cards.CardService))]
namespace XamarinProjectSimple.Services.Cards
{
    public class CardService : ICardService
    {
        public List<CardModel> GetAll()
        {
            return new List<CardModel>()
            {
                new CardModel(){Name = "Addidas", ImageSource=""},
                new CardModel(){Name = "Aasdq", ImageSource=""},
                new CardModel(){Name = "Bersq", ImageSource=""},
                new CardModel(){Name = "Qewr", ImageSource=""},
                new CardModel(){Name = "Berq", ImageSource=""},
                new CardModel(){Name = "Adolf", ImageSource=""}
            };
        }
    }
}
