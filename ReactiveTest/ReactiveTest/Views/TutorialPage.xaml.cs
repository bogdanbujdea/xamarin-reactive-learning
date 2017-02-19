using System;
using System.Threading.Tasks;
using ReactiveTest.ViewModels;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveTest.Views
{
    public partial class TutorialPage : IViewFor<TutorialPageViewModel>
    {
        public TutorialPage()
        {
            InitializeComponent();
            ViewModel = new TutorialPageViewModel();
            this.OneWayBind(ViewModel, vm => vm.Cards, v => v.Tutorial.ItemsSource);
        }

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(TutorialPageViewModel), typeof(TutorialPage), null, BindingMode.OneWay);

        public TutorialPageViewModel ViewModel
        {
            get { return (TutorialPageViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (TutorialPageViewModel)value; }
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            var controlsPage = new ControlsPage();
            //var navigationPage = new NavigationPage(controlsPage);
            await Navigation.PushAsync(controlsPage);
        }
    }
}