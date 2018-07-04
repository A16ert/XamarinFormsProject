using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Models.CardsModels
{
    public class CardModel
    {
        public string Name { get; set; }

        public string FirstLetter
        {
            get => Name[0].ToString().ToUpper();
        }

        public string ImageSource { get; set; }
    }
}
