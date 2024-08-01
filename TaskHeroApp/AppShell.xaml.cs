namespace TaskHeroApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(TaskDetailsPage), typeof(TaskDetailsPage));
        }
    }
}
