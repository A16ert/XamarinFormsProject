using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Models.ReviewModel;

namespace XamarinProjectSimple.Views.Cards.ShopInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReviewsListPage : ContentPage
    {
        public ObservableCollection<ReviewModel> Items { get; set; }

        public ReviewsListPage()
        {
            InitializeComponent();

            var review1 = new ReviewModel()
            {
                UserName = "Ирина",
                MessageText = "Хороший магазин! И цены хорошие!\nВ прошлый раз ходили с мамой\nи купили ролики.А менеджер\nподсказал всё вежливо.",
                Date = "12.05.2017 18:00",
                PositivRating = 5,
                NegativeRating = 1
            };

            var review2 = new ReviewModel()
            {
                UserName = "sladkiKoti",
                MessageText = "Всегда хожу только сюда!!",
                Date = "12.05.2017 18:00",
                PositivRating = 7,
                NegativeRating = 0
            };

            var review3 = new ReviewModel()
            {
                UserName = "Vladi",
                MessageText = "Больше НИ НОГОЙ!!! Меня\nобслужили как скота!Хуже ещё\nни разу в жизни не видывал!",
                Date = "12.05.2017 18:00",
                PositivRating = 0,
                NegativeRating = 5
            };

            review3.Add(new CommentModel { Avatar = "", MessageText = "Дорогой, Влади!\nМы искренне приносим\nсвои извинения и больше\nтак не будем" });

            Items = new ObservableCollection<ReviewModel>
            {
                review1,
                review2,
                review3
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
