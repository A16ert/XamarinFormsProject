using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;
using XamarinProjectSimple.Controls.Buttons;
using XamarinProjectSimple.Droid.Renders.ButtonRenders;

[assembly: ExportRenderer(typeof(ButtonUnderline), typeof(ButtonUnderlineRender))]
namespace XamarinProjectSimple.Droid.Renders.ButtonRenders
{
    public class ButtonUnderlineRender : Xamarin.Forms.Platform.Android.ButtonRenderer
    {
        public ButtonUnderlineRender(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if(e.PropertyName == Xamarin.Forms.Button.TextProperty.PropertyName)
            {
                Control.Text = Element.Text;
                Control.PaintFlags = Android.Graphics.PaintFlags.UnderlineText;
            }
        }
    }
}