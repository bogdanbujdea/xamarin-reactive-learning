using System;
using System.Drawing;
using Xamarin.Forms.Xaml;
using Color = Xamarin.Forms.Color;

namespace ReactiveTest.Controls
{
    public class ColorFromRGBExtension: IMarkupExtension
    {
        public double Red { get; set; }

        public double Green { get; set; }

        public double Blue { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromRgb(Red, Green, Blue);
        }
    }
}