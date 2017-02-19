using ReactiveUI;

namespace ReactiveTest.ViewModels
{
    public class ControlsPageViewModel: ReactiveObject
    {
        private int _red;
        private int _blue;
        private int _green;

        public int Red
        {
            get { return _red; }
            set { this.RaiseAndSetIfChanged(ref _red, value); }
        }

        public int Blue
        {
            get { return _blue; }
            set { this.RaiseAndSetIfChanged(ref _blue, value); }
        }

        public int Green
        {
            get { return _green; }
            set { this.RaiseAndSetIfChanged(ref _green, value); }
        }
    }
}
