using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Threading.Tasks;

namespace TaskHeroApp.ViewModel
{
    [QueryProperty("Text", "Text")]
    public partial class TaskDetailsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        string text;

        [ObservableProperty]
        DateTime dueDate = DateTime.Now;

        [ObservableProperty]
        string selectedPriorityLevel;

        [ObservableProperty]
        string selectedEnergyLevel;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}


