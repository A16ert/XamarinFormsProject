using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Views.Qr;

namespace XamarinProjectSimple.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private void TabbedPage_CurrentPageChanged(object sender, EventArgs e)
        {
            // 2 - qr_scan
            if( this.Children.IndexOf(this.CurrentPage) != 2)
                return;

            Scanner();
        }

        public async void Scanner()
        {

            var qrPage = new QrPage();

            await Navigation.PushAsync(qrPage);
        }
    }
}