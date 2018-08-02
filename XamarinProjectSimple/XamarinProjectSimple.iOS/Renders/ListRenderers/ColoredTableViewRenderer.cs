using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinProjectSimple.Controls.List;
using XamarinProjectSimple.iOS.Renders.ListRenderers;

[assembly: ExportRenderer(typeof(ColoredTableView), typeof(ColoredTableViewRenderer))]
namespace XamarinProjectSimple.iOS.Renders.ListRenderers
{
    class ColoredTableViewRenderer : TableViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TableView> e)
        {
            base.OnElementChanged(e);
            if (Control == null)
                return;

            var tableView = Control as UITableView;
            var coloredTableView = Element as ColoredTableView;
            tableView.SeparatorColor = coloredTableView.SeparatorColor.ToUIColor();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == ColoredTableView.SeparatorColorProperty.PropertyName)
            {
                var tableView = Control as UITableView;
                var coloredTableView = Element as ColoredTableView;

                tableView.SeparatorColor = coloredTableView.SeparatorColor.ToUIColor();
            }
        }
    }
}