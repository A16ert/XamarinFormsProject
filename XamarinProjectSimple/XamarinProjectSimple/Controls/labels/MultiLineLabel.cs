using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.Controls.labels
{
    public class MultiLineLabel : Label
    {
        public static readonly BindableProperty LinesProperty = BindableProperty.Create("Lines", typeof(int), typeof(MultiLineLabel), defaultValue: -1);

        public int Lines
        {
            get => (int)GetValue(LinesProperty);

            set => SetValue(LinesProperty, value);
        }
    }
}
