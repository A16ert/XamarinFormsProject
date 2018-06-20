using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Views.Authorization
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AuthPage : ContentPage
	{
		public AuthPage ()
		{
			InitializeComponent ();
		}

        private void RegistrationButton_Clicked(object sender, EventArgs e)
        {
            App.GoToRegistration();
        }

        private void SkipAuthButton_Clicked(object sender, EventArgs e)
        {
            App.GoToRoot();
        }
    }
}