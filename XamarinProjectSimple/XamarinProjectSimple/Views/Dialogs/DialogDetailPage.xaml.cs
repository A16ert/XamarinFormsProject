using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Models.DialogModels;

namespace XamarinProjectSimple.Views.Dialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DialogDetailPage : ContentPage
    {
        public ObservableCollection<MessageModel> Items { get; set; }

        public DialogDetailPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<MessageModel>
            {
                new MessageModel(){ Text = "Item 1", IsMyMessage = true},
                new MessageModel(){ Text = "Item 2"},
                new MessageModel(){ Text = "Item 3"},
                new MessageModel(){ Text = "Item 4", IsMyMessage = true},
                new MessageModel(){ Text = "Item 5" }
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
