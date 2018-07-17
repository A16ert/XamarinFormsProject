using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinProjectSimple.Controls.CustomEntrys;
using XamarinProjectSimple.iOS.Renders.EntryRenders;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]
namespace XamarinProjectSimple.iOS.Renders.EntryRenders
{
    public class CustomEntryRender : ViewRenderer<CustomEntry, UITextField>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomEntry> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
            {
                var uiTextField = new UITextField
                {
                    Font = UIFont.SystemFontOfSize(25)
                };
                uiTextField.BorderStyle = UITextBorderStyle.Line;

                SetNativeControl(uiTextField);
                DrawBorder();
            }
            if (e.NewElement != null)
            {
                SetText();
                SetTextColor();
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

        void DrawBorder()
        {
            CALayer borderLayer = new CALayer();
            borderLayer.BackgroundColor = UIColor.FromRGB(23, 162, 227).CGColor;
            borderLayer.Frame = new CGRect(0, 45, 335, 5);
            Layer.AddSublayer(borderLayer);
        }
    }
}