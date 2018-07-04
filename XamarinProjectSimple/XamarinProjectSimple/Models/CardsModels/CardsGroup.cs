using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Models.CardsModels
{
    public class CardsGroup : List<CardModel>
    {
        public string FirstLetter { get; set; }

        public CardsGroup(string firstLetter)
        : base()
        {
            FirstLetter = firstLetter;
        }
        public CardsGroup(string firstLetter, IEnumerable<CardModel> source)
                : base(source)
        {
            FirstLetter = firstLetter;
        }


    }
}
