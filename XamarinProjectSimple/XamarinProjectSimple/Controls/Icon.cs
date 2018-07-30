using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinProjectSimple.Controls
{
	public class Icon : Frame
	{

        public static readonly BindableProperty IconFilePathProperty = BindableProperty.Create(
                                                                                            nameof(ResourceId),
                                                                                            typeof(string),
                                                                                            typeof(Icon),
                                                                                            default(string),
                                                                                            propertyChanged: RedrawCanvas);

        public static readonly BindableProperty RotationRadiusProperty = BindableProperty.Create(nameof(RotationRadius),
                                                                                           typeof(float),
                                                                                           typeof(Icon),
                                                                                           0f,
                                                                                           propertyChanged: RedrawCanvas);

        public static readonly BindableProperty IconColorProperty = BindableProperty.Create(nameof(RotationRadius),
                                                                                           typeof(Color),
                                                                                           typeof(Icon),
                                                                                           Color.Transparent,
                                                                                           propertyChanged: RedrawCanvas);

        public string ResourceId
        {
            get => (string)GetValue(IconFilePathProperty);
            set => SetValue(IconFilePathProperty, value);
        }

        public float RotationRadius
        {
            get => (float)GetValue(RotationRadiusProperty);

            set => SetValue(RotationRadiusProperty, value);
        }

        public Color IconColor
        {
            get => (Color)GetValue(IconColorProperty);

            set => SetValue(IconColorProperty, value);
        }

        private readonly SKCanvasView _canvasView = new SKCanvasView();

        public Icon() : base()
        {
            Padding = new Thickness(0);

            // Thanks to TheMax for pointing out that on mobile, the icon will have a shadow by default.
            // Also it has a white background, which we might not want.
            HasShadow = false;
            BackgroundColor = Color.Transparent;
            BorderColor = Color.Transparent;

            Content = _canvasView;

            HorizontalOptions = LayoutOptions.Fill;
            VerticalOptions = LayoutOptions.Fill;

            _canvasView.PaintSurface += CanvasViewOnPaintSurface;
        }

        


        private static void RedrawCanvas(BindableObject bindable, object oldvalue, object newvalue)
        {
            Icon svgIcon = bindable as Icon;
            svgIcon?._canvasView.InvalidateSurface();
        }

        private void CanvasViewOnPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKCanvas canvas = args.Surface.Canvas;
            canvas.Clear();

            if (string.IsNullOrEmpty(ResourceId))
                return;
            
            using (Stream stream = GetType().Assembly.GetManifestResourceStream(ResourceId))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                SKSvg svg = new SKSvg();
#pragma warning restore CS0618 // Type or member is obsolete
                svg.Load(stream);

                SKImageInfo info = args.Info;
                canvas.Translate(info.Width / 2f, info.Height / 2f);

                SKRect bounds = svg.ViewBox;
                
                float xRatio = info.Width / bounds.Width;
                float yRatio = info.Height / bounds.Height;

                float ratio = Math.Min(xRatio, yRatio);

                canvas.Scale(ratio);
                canvas.Translate(-bounds.MidX, -bounds.MidY);
                canvas.RotateDegrees(RotationRadius, bounds.MidX, bounds.MidY);

                if (IconColor == Color.Transparent)
                {
                    canvas.DrawPicture(svg.Picture);
                    return;
                }

                using (var paint = new SKPaint())
                {

                    paint.ColorFilter = SKColorFilter.CreateBlendMode(
                        IconColor.ToSKColor(),       // the color, also `(SKColor)0xFFFF0000` is valid
                        SKBlendMode.SrcIn); // use the source color

                    canvas.DrawPicture(svg.Picture, paint);
                }
            }
        }
    }
}