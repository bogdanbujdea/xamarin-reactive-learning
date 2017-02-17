using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveTest.ViewModels;
using ReactiveUI;
using Xamarin.Forms;

namespace ReactiveTest.Views
{
    public partial class LoginPage : ContentPage, IViewFor<LoginViewModel>
    {
        public LoginPage()
        {
            InitializeComponent();
            // We'll initialize our viewmodel
            ViewModel = new LoginViewModel();
            // We'll add the bindings
          //  this.Bind(ViewModel, vm => vm.Email, v => v.Email.Text);
            this.Bind(ViewModel, vm => vm.Password, v => v.Password.Text);
            this.BindCommand(ViewModel, vm => vm.Login, v => v.Login);
            this.WhenAnyValue(x => x.ViewModel.IsLoading)
                .ObserveOn(RxApp.MainThreadScheduler)
                .Subscribe(busy =>
                {
                    Email.IsEnabled = !busy;
                    Password.IsEnabled = !busy;
                    Loading.IsVisible = busy;
                });
        }


        //The rest of the code below is plumbing:

        public static readonly BindableProperty ViewModelProperty = BindableProperty.Create(nameof(ViewModel), typeof(LoginViewModel), typeof(LoginPage), null, BindingMode.OneWay);

        public LoginViewModel ViewModel
        {
            get { return (LoginViewModel)GetValue(ViewModelProperty); }
            set { SetValue(ViewModelProperty, value); }
        }

        object IViewFor.ViewModel
        {
            get { return ViewModel; }
            set { ViewModel = (LoginViewModel)value; }
        }
    }
}
