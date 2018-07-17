using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinProjectSimple.Controls.CustomEntrys;
using XamarinProjectSimple.Droid.Renders.EntryRenders;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]
namespace XamarinProjectSimple.Droid.Renders.EntryRenders
{
#pragma warning disable CS0618 // Type or member is obsolete
    public class CustomEntryRender : ViewRenderer<CustomEntry, EditText>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomEntry> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var entryText = new EditText(Context);

                entryText.SetPadding(0, 0, 0, 0);
                entryText.TextAlignment = Android.Views.TextAlignment.Center;

                SetNativeControl(entryText);

                if (e.NewElement != null)
                {
                    entryText.Hint = Element.Placeholder;

                    SetText();
                    SetTextColor();
                    SetBackgroundColor();
                    SetTextSize();
                    SetPadding();

                    entryText.SetBackgroundResource(Resource.Drawable.EntryShape);
                }  
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomEntry.PaddingProperty.PropertyName)
            {
                SetPadding();
            }
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

        private void SetBackgroundColor()
        {
            Android.Graphics.Color andrColor = Android.Graphics.Color.White;

            if (Element.BackgroundColor != Xamarin.Forms.Color.White)
            {
                Xamarin.Forms.Color color = Element.BackgroundColor;
                andrColor = Android.Graphics.Color.Argb(
                    (byte)(color.A * 255),
                    (byte)(color.R * 255),
                    (byte)(color.G * 255),
                    (byte)(color.B * 255));
            }
            Control.SetBackgroundColor(andrColor);
        }

        private void SetTextSize()
        {
            Control.SetTextSize(Android.Util.ComplexUnitType.Dip, (float)Element.FontSize);
        }

        private void SetPadding()
        {
            Control.SetPadding((int)Element.Padding.Left, (int)Element.Padding.Top, (int)Element.Padding.Right, (int)Element.Padding.Bottom);
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}