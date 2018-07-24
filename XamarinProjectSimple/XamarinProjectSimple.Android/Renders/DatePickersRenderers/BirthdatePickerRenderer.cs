using System;
using System.Collections.Generic;
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
using XamarinProjectSimple.Droid.Renders.DatePickersRenderers;

[assembly: ExportRenderer(typeof(BirthDatePicker), typeof(BirthdatePickerRenderer))]
namespace XamarinProjectSimple.Droid.Renders.DatePickersRenderers
{
    class BirthdatePickerRenderer : ViewRenderer<Bir>
    {
    }
}