using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.ViewModels.Cards;

namespace XamarinProjectSimple.Views.Cards
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CardDetailPage : ContentPage
	{
        public CardDetailPage ()
		{
			InitializeComponent ();
            Title = "Merge";
            barCode.BindingContext = new BarCodeViewModel();

            purshaseHistory.PurshaseList = new Models.CardsModels.PurshaseListModel()
            {
                TotalSummValue = 2000,
                PurshaseList = new List<Models.CardsModels.PurshaseModel>()
                {
                    new Models.CardsModels.PurshaseModel(){Name = "Товар", Date = "13.02.2018", DiscountSumm = "200", Summ = "2000", TotalSumm ="1800"},
                    new Models.CardsModels.PurshaseModel(){Name = "Товар", Date = "13.02.2018", DiscountSumm = "200", Summ = "2000", TotalSumm ="1800"},
                    new Models.CardsModels.PurshaseModel(){Name = "Товар", Date = "13.02.2018", DiscountSumm = "200", Summ = "2000", TotalSumm ="1800"},
                    new Models.CardsModels.PurshaseModel(){Name = "Товар", Date = "13.02.2018", DiscountSumm = "200", Summ = "2000", TotalSumm ="1800"}
                }
            };
        }
    }
}