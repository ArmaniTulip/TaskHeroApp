using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;



namespace TaskHeroApp.ViewModel
{
    public enum PriorityLevel
    {
        Low,
        Medium,
        High
    }

    public class TaskViewModel : INotifyPropertyChanged
    {
        private PriorityLevel _priority;
        private Color _buttonColor;

        public PriorityLevel Priority
        {
            get => _priority;
            set
            {
                _priority = value;
                OnPropertyChanged(nameof(Priority));
                UpdateButtonColor();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                OnPropertyChanged(nameof(ButtonColor));
            }
        }

        private void UpdateButtonColor()
        {
            switch (_priority)
            {
                case PriorityLevel.Low:
                    ButtonColor = Color.FromRgb(0,255,0);
                    break;
                case PriorityLevel.Medium:
                    ButtonColor = Color.FromRgb(255,255,0);
                    break;
                case PriorityLevel.High:
                    ButtonColor = Color.FromRgb(255,255,0);
                    break;
            }
        }

        // Implement INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
