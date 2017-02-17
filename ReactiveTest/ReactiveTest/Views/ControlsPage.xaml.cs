using System;
using System.Reactive.Linq;
using ReactiveTest.ViewModels;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveTest.Views
{
    public partial class ControlsPage : IViewFor<ControlaPageViewModel>
    {
        public ControlsPage()
        {
            InitializeComponent();
            ViewModel = new ControlaPageViewModel();
            this.Bind(ViewModel, vm => vm.Red, v => v.RedSlider.Value);
            this.Bind(ViewModel, vm => vm.Blue, v => v.BlueSlider.Value);
            this.Bind(ViewModel, vm => vm.Green, v => v.GreenSlider.Value);
            this.WhenAnyValue(x => x.ViewModel.Red, x => x.ViewModel.Green, x => x.ViewModel.Blue)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(a =>
                {
                    ColoredGrid.BackgroundColor = Color.FromRgb(a.Item1, a.Item2, a.Item3);
                });
        }

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(ControlaPageViewModel), typeof(ControlsPage), null, BindingMode.OneWay);

        public ControlaPageViewModel ViewModel
        {
            get { return (ControlaPageViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (ControlaPageViewModel)value; }
        }
    }
}
