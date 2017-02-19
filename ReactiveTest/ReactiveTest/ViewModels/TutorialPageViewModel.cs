using ReactiveUI;

namespace ReactiveTest.ViewModels
{
    public class TutorialPageViewModel: ReactiveObject
    {
        private ReactiveList<Card> _cards;

        public TutorialPageViewModel()
        {
            Cards = new ReactiveList<Card>
            {
                new Card
                {
                    Image = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png",
                    Description = "Hello"
                },
                new Card
                {
                    Image = "http://content.screencast.com/users/JamesMontemagno/folders/Jing/media/6b60d27e-c1ec-4fe6-bebe-7386d545bb62/2016-06-02_1051.png",
                    Description = "Hello 2"
                },
                new Card
                {
                    Image = "https://exoticcars.enterprise.com/etc/designs/exotics/clientlibs/dist/img/homepage/Homepage-Hero-Car.png",
                    Description = "Hello 3"
                }
            };
        }

        public ReactiveList<Card> Cards
        {
            get { return _cards; }
            set { this.RaiseAndSetIfChanged(ref _cards, value); }
        }
    }

    public class Card: ReactiveObject
    {
        public string Image { get; set; }

        public string Description { get; set; }
    }
}
