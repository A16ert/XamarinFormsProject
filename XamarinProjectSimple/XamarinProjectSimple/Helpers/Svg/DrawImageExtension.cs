using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms.Xaml;

namespace XamarinProjectSimple.Helpers.Svg
{
    public class DrawImageExtension : IMarkupExtension
    {
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            var source = SvgHelper.GetAsImageSource(FileName, Width, Height, Color);

            return source;
        }

        public string FileName { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public Color Color { get; set; }
    }
}
