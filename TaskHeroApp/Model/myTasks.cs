using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHeroApp.Model
{
    [ObservableObject]
    public partial class myTasks
    {
        [ObservableProperty]
        public string taskName;

        [ObservableProperty]
        public DateTime dueDate;

        [ObservableProperty]
        public string priorityLevel;

        [ObservableProperty]
        public string energyNecessary;

        [ObservableProperty]
        public string expectedTimeToComplete;
    }

}
