using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.Controls.Frames
{
    class CounterCircle : Frame
    {
        public CounterCircle()
        {
            CornerRadius = 30;
            BackgroundColor = Color.Red;
            BorderColor = Color.Red;
            HorizontalOptions = LayoutOptions.Start;
            VerticalOptions = LayoutOptions.Start;
            Margin = 0;
            Padding = 0;
            Content = new Label
            {
                Text = "2",
                BackgroundColor = Color.Red,
                TextColor = Color.White,
                Margin = 0,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            };
        }
    }
}
