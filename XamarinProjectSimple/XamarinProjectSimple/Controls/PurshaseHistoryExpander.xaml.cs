using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Models.CardsModels;

namespace XamarinProjectSimple.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PurshaseHistoryExpander : ContentView
	{
        public static readonly BindableProperty PurshaseListProperty = BindableProperty.Create(nameof(PurshaseList), typeof(PurshaseListModel),
            typeof(PurshaseHistoryExpander), null);

        public PurshaseListModel PurshaseList
        {
            get => (PurshaseListModel)GetValue(PurshaseListProperty);

            set
            {
                SetValue(PurshaseListProperty, value);
                ChangePurshaseStack(value);
            }
        }

        public PurshaseHistoryExpander ()
		{
			InitializeComponent ();

        }

        private void ChangePurshaseStack(PurshaseListModel model)
        {
            purshaseStack.Children.Clear();

            if (model == null) return;

            foreach(var item in model.PurshaseList)
            {
                var grid = new Purshase()
                {
                    PurshaseInfo = new PurshaseModel(item)
                };

                purshaseStack.Children.Add(grid);
            }
        }

        //public Grid GetPurchaseGrid(PurshaseModel model)
        //{
        //    Grid grid = new Grid();

        //    var boxView = new BoxView() { BackgroundColor = Color.Gray };

        //    grid.RowDefinitions.Add(new RowDefinition());
        //    grid.RowDefinitions.Add(new RowDefinition());
        //    grid.RowDefinitions.Add(new RowDefinition());
        //    grid.RowDefinitions.Add(new RowDefinition());
        //    grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Absolute) });

        //    grid.ColumnDefinitions.Add(new ColumnDefinition());
        //    grid.ColumnDefinitions.Add(new ColumnDefinition());

        //    grid.Children.Add(new Label() { Text = model.Date });

        //    grid.Children.Add(new Label() { Text = model.Name }, 0, 1);
        //    grid.Children.Add(new Label() { Text = model.Summ} , 1, 1);

        //    grid.Children.Add(new Label() { Text = "Скидка"}   , 0, 2);
        //    grid.Children.Add(new Label() { Text = model.DiscountSumm }, 1, 2);

        //    grid.Children.Add(new Label { Text = "Итого" }, 0, 3);
        //    grid.Children.Add(new Label { Text = model.TotalSumm }, 1, 3);

        //    grid.Children.Add(boxView);

            

        //    return grid;
        //}

    }
}