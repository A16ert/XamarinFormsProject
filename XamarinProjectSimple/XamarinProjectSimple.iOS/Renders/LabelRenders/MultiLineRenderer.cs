using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinProjectSimple.Controls.labels;
using XamarinProjectSimple.iOS.Renders.LabelRenders;

[assembly: ExportRenderer(typeof(MultiLineLabel), typeof(MultiLineRenderer))]
namespace XamarinProjectSimple.iOS.Renders.LabelRenders
{
    class MultiLineRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            MultiLineLabel multiLineLabel = (MultiLineLabel)Element;

            if (multiLineLabel != null && multiLineLabel.Lines != -1)
                Control.Lines = multiLineLabel.Lines;
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == MultiLineLabel.LinesProperty.PropertyName)
            {
                var label = (MultiLineLabel)Element;

                if (label.Lines == -1)
                {
                    Control.LineBreakMode = UILineBreakMode.WordWrap;
                }
                else
                {
                    Control.Lines = ((MultiLineLabel)Element).Lines;
                }
            }
        }
    }
}