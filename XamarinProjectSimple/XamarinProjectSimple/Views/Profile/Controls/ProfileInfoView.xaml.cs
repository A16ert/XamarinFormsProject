using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Views.Profile.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileInfoView : ContentView
	{
        public static BindableProperty InfoValueProperty = BindableProperty.Create(nameof(InfoValue), typeof(string), typeof(ProfileInfoView), string.Empty);

        public static BindableProperty InfoNameProperty = BindableProperty.Create(nameof(InfoName), typeof(string), typeof(ProfileInfoView), string.Empty);

        public string InfoValue
        {
            get => (string)GetValue(InfoValueProperty);
            set => SetValue(InfoValueProperty, value);
        }

        public string InfoName
        {
            get => (string)GetValue(InfoNameProperty);
            set => SetValue(InfoNameProperty, value);
        }

		public ProfileInfoView ()
		{
			InitializeComponent ();
		}
	}
}