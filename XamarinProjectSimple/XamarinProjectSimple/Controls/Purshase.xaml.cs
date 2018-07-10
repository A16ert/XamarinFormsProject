using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.Models.CardsModels;

namespace XamarinProjectSimple.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Purshase : ContentView
	{
        public static readonly BindableProperty PurshaseInfoProperty = BindableProperty.Create(nameof(PurshaseInfo), typeof(PurshaseModel), typeof(Purshase), new PurshaseModel());

        public PurshaseModel PurshaseInfo
        {
            get => (PurshaseModel)GetValue(PurshaseInfoProperty);

            set
            {
                SetValue(PurshaseInfoProperty, value);
            }
        }

        public Purshase ()
		{
			InitializeComponent ();
		}
	}
}