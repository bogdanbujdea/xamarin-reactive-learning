using ReactiveTest.Controls;
using ReactiveTest.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Color = Android.Graphics.Color;

[assembly:ExportRenderer(typeof(ShadedButton), typeof(ShadedButtonRenderer))]
namespace ReactiveTest.Droid.Controls
{
    public class ShadedButtonRenderer: ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(Color.Gray);
            }
        }
    }
}