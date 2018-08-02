using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinProjectSimple.Controls.List;
using XamarinProjectSimple.Droid.Renders.ListRenders;

[assembly: ExportRenderer(typeof(ColoredTableView), typeof(ColoredTableViewRenderer))]
namespace XamarinProjectSimple.Droid.Renders.ListRenders
{
#pragma warning disable CS0618 // Тип или член устарел
    class ColoredTableViewRenderer : TableViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
                return;

            var listView = Control as Android.Widget.ListView;
            var coloredTableView = (ColoredTableView)Element;
            listView.Divider = new ColorDrawable(coloredTableView.SeparatorColor.ToAndroid());
            listView.DividerHeight = 3;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ColoredTableView.SeparatorColorProperty.PropertyName)
            {
                var listView = Control as Android.Widget.ListView;
                var coloredTableView = (ColoredTableView)Element;
                listView.Divider = new ColorDrawable(coloredTableView.SeparatorColor.ToAndroid());
            }
        }
    }
#pragma warning restore CS0618 // Тип или член устарел
}