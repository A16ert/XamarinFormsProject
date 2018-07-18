using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using XamarinProjectSimple.Controls.labels;

namespace XamarinProjectSimple.iOS.Renders.LabelRenders
{
    class UnderlineLabelRender : ViewRenderer<UnderlineLabel, UILabel>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<UnderlineLabel> e)
        {

            base.OnElementChanged(e);

            if (Control == null)
            {
                UILabel uilabel = new UILabel
                {
                    Font = UIFont.SystemFontOfSize(25)
                };
                SetNativeControl(uilabel);
            }
            if (e.NewElement != null)
            {
                this.Control.AttributedText = new NSAttributedString(Element.Text, underlineStyle: NSUnderlineStyle.Single);

                SetText();
                SetTextColor();
                //SetTextSize();
            }

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == UnderlineLabel.TextColorProperty.PropertyName)
            {
                SetTextColor();
            }
            else if (e.PropertyName == UnderlineLabel.TextProperty.PropertyName)
            {
                SetText();
            }
        }
        private void SetText()
        {
            Control.Text = Element.Text;
        }
        private void SetTextColor()
        {
            UIColor iosColor = UIColor.Gray;

            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                iosColor = UIColor.FromRGBA(
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255),
                    (byte)(color.A * 255));
            }
            Control.TextColor = iosColor;
        }

        private void SetTextSize()
        {
            Control.Font.WithSize(new nfloat(Element.FontSize));
        }
    }
}