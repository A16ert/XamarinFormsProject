using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinProjectSimple.Controls.Buttons;

[assembly: ExportRenderer(typeof(ButtonUnderline), typeof(XamarinProjectSimple.iOS.Renders.ButtonRenderers.ButtonUnderlineRenderer))]
namespace XamarinProjectSimple.iOS.Renders.ButtonRenderers
{
    class ButtonUnderlineRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Color color = Element.TextColor;
                var iosColor = UIColor.FromRGBA(
                                (byte)(color.R * 255),
                                (byte)(color.G * 255),
                                (byte)(color.B * 255),
                                (byte)(color.A * 255));

                var underlineAttr = new UIStringAttributes { UnderlineStyle = NSUnderlineStyle.Single, ForegroundColor = iosColor };

                Control.AccessibilityAttributedLabel = new NSAttributedString(Element.Text, underlineAttr);
            }
        }
    }
}