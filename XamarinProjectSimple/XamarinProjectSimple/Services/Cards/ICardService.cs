using System;
using System.Collections.Generic;
using System.Text;
using XamarinProjectSimple.Models.CardsModels;

namespace XamarinProjectSimple.Services.Cards
{
    public interface ICardService
    {
        List<CardModel> GetAll();
    }
}
