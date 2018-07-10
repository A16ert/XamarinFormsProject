using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinProjectSimple.Models.CardsModels
{
    public class PurshaseListModel
    {
        public int TotalSummValue { get; set; }

        public string TotalSumm => TotalSummValue + "P";

        public List<PurshaseModel> PurshaseList;
    }
}
