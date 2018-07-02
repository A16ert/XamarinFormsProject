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
    public partial class DialogsPage : ContentPage
    {
        public DialogsPage()
        {
            InitializeComponent();
            DialogsListView.ItemsSource = new ObservableCollection<DialogShortModel>()
            {
                new DialogShortModel() { Name = "mergen", LastMessage = "Ваша скидка увеличилась", Date = "19.09.2017"},
                new DialogShortModel() { Name = "ООО Тест", LastMessage = "Ваша скидка увеличилась", Date = "21.09.2017"},
                new DialogShortModel() { Name = "Тесе2", LastMessage = "Ваша скидка увеличилась", Date = "19.09.2017"}
            };
        }

        private async void DialogsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new DialogDetailPage());
        }
    }
}
