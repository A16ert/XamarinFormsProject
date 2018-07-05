using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardView : ContentView
    {
        public readonly static BindableProperty OwnerNameProperty = BindableProperty.Create("OwnerName", typeof(string),
            typeof(CardView), string.Empty);
        public CardView()
        {
            InitializeComponent();


        }

        public string OwnerName
        {
            get => (string)this.GetValue(OwnerNameProperty);

            set => this.SetValue(OwnerNameProperty, value);
        }
    }

    public class StringToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (string)value == string.Empty || (string)value == null ? false : true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "";
        }
    }
}