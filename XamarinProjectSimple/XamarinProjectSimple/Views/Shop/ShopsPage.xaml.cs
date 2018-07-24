using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Controls.labels;
using XamarinProjectSimple.Models.ShopModels;

namespace XamarinProjectSimple.Views.Shop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShopsPage : ContentPage
    {
        public ShopsPage()
        {
            InitializeComponent();
            
        }

        private void ClickGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            var label = ((sender as Label).GestureRecognizers[0] as TapGestureRecognizer).CommandParameter as MultiLineLabel;

            label.Lines = -1;
            label.LineBreakMode = LineBreakMode.WordWrap;

            (sender as View).IsVisible = false;
        }

        private void ShopFooterBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
