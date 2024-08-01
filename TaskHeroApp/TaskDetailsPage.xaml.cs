using TaskHeroApp.ViewModel;

namespace TaskHeroApp;

public partial class TaskDetailsPage : ContentPage
{
	public TaskDetailsPage(TaskDetailsPageViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
}