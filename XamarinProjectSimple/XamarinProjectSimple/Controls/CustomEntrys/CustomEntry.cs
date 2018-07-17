using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.Controls.CustomEntrys
{
    public class CustomEntry : Entry
    {
        public static readonly BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(CustomEntry),defaultValue: new Thickness(0));

        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
    }
}
