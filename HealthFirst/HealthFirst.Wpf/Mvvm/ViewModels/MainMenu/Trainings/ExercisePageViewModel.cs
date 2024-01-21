using HealthFirst.Core.Training.Interfaces;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Commands;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Trainings
{
    public sealed class ExercisePageViewModel : ViewModelBase
    {
        private readonly IExercise _exercise;

        #region Commands


        private RelayCommand _completeExericise;
        public ICommand CompleteExericise
        {
            get => RelayCommand.GetCommand(ref _completeExericise, () =>
            {
            });
        }

        public ICommand BackToPrevCommand { get; }


        #endregion Commands


        public ExercisePageViewModel(IExercise exercise, ICommand backCommand)
        {
            _exercise = exercise;
            BackToPrevCommand = backCommand;
        }
    }
}
