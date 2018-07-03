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
        }

        private async void DialogsListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new DialogDetailPage());
        }
    }
}
