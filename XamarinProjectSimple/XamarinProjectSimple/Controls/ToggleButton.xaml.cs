using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToggleButton : ContentView
	{
        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(ToggleButton), default(string));
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(nameof(IsChecked), typeof(bool), typeof(ToggleButton), false);

        public string Text {

            get => (string)this.GetValue(TextProperty);
            set => this.SetValue(TextProperty, value);
        }

        public bool IsChecked
        {
            get => (bool)GetValue(IsCheckedProperty);

            set
            {
                SetValue(IsCheckedProperty, value);

                if (value) iconControl.RotationRadius = 0f;
                else iconControl.RotationRadius = 180f;
            }
        }


        public ToggleButton ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
        }
    }
}