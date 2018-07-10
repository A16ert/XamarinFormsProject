using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Models.CardsModels
{
    public class PurshaseModel
    {
        public PurshaseModel()
        {
            Name = string.Empty;
            Date = string.Empty;
            Summ = string.Empty;
            DiscountSumm = string.Empty;
            TotalSumm = string.Empty;
        }
        public PurshaseModel(PurshaseModel model)
        {
            Name = model.Name;
            Date = model.Date;
            Summ = model.Summ;
            DiscountSumm = model.DiscountSumm;
            TotalSumm = model.TotalSumm;
        }
        public string Name { get; set; }

        public string Date { get; set; }
        public string Summ { get; set; }

        public string DiscountSumm { get; set; }

        public string TotalSumm { get; set; }
    }
}
