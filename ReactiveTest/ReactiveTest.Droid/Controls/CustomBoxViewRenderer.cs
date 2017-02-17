using System.ComponentModel;
using Android.Graphics;
using ReactiveTest.Controls;
using ReactiveTest.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly:ExportRenderer(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace ReactiveTest.Droid.Controls
{
    public sealed class CustomBoxViewRenderer: BoxRenderer
    {
        public CustomBoxViewRenderer()
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Canvas canvas)
        {
            CustomBoxView boxView = (CustomBoxView) Element;
            Rect rect = new Rect();
            GetDrawingRect(rect);
            Rect inside = rect;
            inside.Inset((int)boxView.BorderThickness,
                (int)boxView.BorderThickness);
            Paint p = new Paint
            {
                Color = boxView.Color.ToAndroid()
            };

            canvas.DrawRect(inside, p);

            p.Color = boxView.BorderColor.ToAndroid();
            p.StrokeWidth = (float) boxView.BorderThickness;
            p.SetStyle(Paint.Style.Stroke);
            canvas.DrawRect(rect, p);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            Invalidate();
        }
    }
}