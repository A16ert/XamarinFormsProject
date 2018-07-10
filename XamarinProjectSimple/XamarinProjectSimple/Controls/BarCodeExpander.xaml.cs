using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinProjectSimple.ViewModels.Cards;

namespace XamarinProjectSimple.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BarCodeExpander : ContentView
    {

        public BarCodeExpander ()
		{
			InitializeComponent ();
		}
	}
}