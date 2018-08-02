using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Controls.Buttons
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LabelWithArrow : ContentView
	{
        public static BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(LabelWithArrow), string.Empty);

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

		public LabelWithArrow ()
		{
			InitializeComponent ();
		}
	}
}