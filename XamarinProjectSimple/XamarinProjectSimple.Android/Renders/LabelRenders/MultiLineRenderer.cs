using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinProjectSimple.Controls.labels;
using XamarinProjectSimple.Droid.Renders.LabelRenders;

[assembly: ExportRenderer(handler: typeof(MultiLineLabel), target: typeof(MultiLineRenderer))]
namespace XamarinProjectSimple.Droid.Renders.LabelRenders
{
#pragma warning disable CS0618
    public class MultiLineRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Label> e)
        {
            base.OnElementChanged(e);

            MultiLineLabel multiLineLabel = (MultiLineLabel)Element;

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
            {


                Control.SetSingleLine(false);
                Control.SetLines(multiLineLabel.Lines);
            }

            if (multiLineLabel?.Lines == -1)
            {
                Control.InputType = Android.Text.InputTypes.TextFlagMultiLine;
                Control.SetSingleLine(false);
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == MultiLineLabel.LinesProperty.PropertyName)
            {

                if (((MultiLineLabel)Element).Lines != -1)
                    Control.SetLines(((MultiLineLabel)Element).Lines);
                else
                    Control.SetSingleLine(true);
            }

            //if(e.PropertyName == Label.HeightProperty.PropertyName)
            //{
            //    Control.SetHeight((int)Element.HeightRequest);
            //}
        }

        private void SetText()
        {
            Control.Text = Element.Text;
        }
        private void SetTextColor()
        {
            Android.Graphics.Color andrColor = Android.Graphics.Color.Gray;

            if (Element.TextColor != Xamarin.Forms.Color.Default)
            {
                Xamarin.Forms.Color color = Element.TextColor;
                andrColor = Android.Graphics.Color.Argb(
                    (byte)(color.A * 255),
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255));
            }
            Control.SetTextColor(andrColor);
        }
    }
#pragma warning restore CS0618 
}