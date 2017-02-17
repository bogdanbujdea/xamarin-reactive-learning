using Xamarin.Forms;

namespace ReactiveTest.Controls
{
    public class CustomBoxView : BoxView
    {
        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(nameof(BorderColor), typeof(Color),
                                                                        typeof(CustomBoxView),
                                                                        default(Color), BindingMode.OneWay,
                                                                        propertyChanged: OnIsPopupVisibleChanged);

        public Color BorderColor
        {
            get { return (Color) GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        private static void OnIsPopupVisibleChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
        }




        public double BorderThickness
        {
            get { return (double)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.Create(nameof(BorderThickness), typeof(double), typeof(CustomBoxView), default(double));


    }
}