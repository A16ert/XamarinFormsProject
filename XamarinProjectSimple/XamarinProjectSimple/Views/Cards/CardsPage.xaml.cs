using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Views.Cards
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardsPage : ContentPage
    {
        public CardsPage()
        {
            InitializeComponent();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await Navigation.PushAsync(new CardDetailPage());

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        private async void AddCard_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddingCardPage());
        }
    }
}
