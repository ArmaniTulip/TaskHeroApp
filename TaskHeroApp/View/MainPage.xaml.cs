using TaskHeroApp.ViewModel;

namespace TaskHeroApp.View
{

    public partial class MainPage : ContentPage
    {
        private MainViewModel vm = new MainViewModel();

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

 
    }
}
