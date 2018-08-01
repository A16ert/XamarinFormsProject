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
    }
}