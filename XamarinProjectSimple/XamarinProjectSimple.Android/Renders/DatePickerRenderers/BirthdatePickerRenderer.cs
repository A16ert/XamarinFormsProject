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
using XamarinProjectSimple.Controls.DatePickers;
using XamarinProjectSimple.Droid.Renders.DatePickerRenderers;

[assembly: ExportRenderer(typeof(BirthDatePicker), typeof(BirthdatePickerRenderer))]
namespace XamarinProjectSimple.Droid.Renders.DatePickerRenderers
{
#pragma warning disable CS0618 // Type or member is obsolete
    class BirthdatePickerRenderer : ViewRenderer<BirthDatePicker, Android.Widget.DatePicker>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<BirthDatePicker> e)
        {
            base.OnElementChanged(e);

            if(Control == null)
            {
                var datePicker = new Android.Widget.DatePicker(Context);

                datePicker.SetBackgroundResource(XamarinProjectSimple.Droid.Resource.Drawable.EntryShape);
                SetNativeControl(datePicker);

            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
#pragma warning restore CS0618 // Type or member is obsolete
}