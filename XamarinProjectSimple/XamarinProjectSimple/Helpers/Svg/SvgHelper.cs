using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinProjectSimple.Helpers.Svg
{
    class SvgHelper
    {
        public static ImageSource GetAsImageSource(string svgImage, float width, float height, Color color)
        {
            var scaleFactor = 0;

#if __IOS__
                scaleFactor = (int)UIKit.UIScreen.MainScreen.Scale;
#elif __ANDROID__
                 // В MainActivity добавлено статическое свойство Current.
                 scaleFactor = MainActivity.Current.Resources.DisplayMetrics.Density
#endif

            var svg = new SkiaSharp.Extended.Svg.SKSvg();

#if __IOS__
                svg.Load(svgImage);
#elif __ANDROID__
                var assetStream = MainActivity.Current.Assets.Open(svgImage);
                svg.Load(assetStream);
#endif

            var svgSize = svg.Picture.CullRect;
            var svgMax = Math.Max(svgSize.Width, svgSize.Height);

            float canvasMin = Math.Min((int)(width * scaleFactor), (int)(height * scaleFactor));
            var scale = canvasMin / svgMax;
            var matrix = SKMatrix.MakeScale(scale, scale);

            var bitmap = new SKBitmap((int)(width * scaleFactor), (int)(height * scaleFactor));

            var paint = new SKPaint()
            {
                ColorFilter = SKColorFilter.CreateBlendMode(color.ToSKColor(), SKBlendMode.SrcIn)
            };

            var canvas = new SKCanvas(bitmap);
            canvas.DrawPicture(svg.Picture, ref matrix, paint);

            var image = SKImage.FromBitmap(bitmap);
            var encoded = image.Encode();
            var stream = encoded.AsStream();
            var source = ImageSource.FromStream(() => stream);

            return source;
        }
    }
}
