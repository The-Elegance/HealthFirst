using HealthFirst.Core.Training.Interfaces;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Commands;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Trainings
{
    public sealed class TrainingCourseViewModel : ViewModelBase
    {
        private readonly ITrainingCourse _trainingCourse;
        private Action<ViewModelBase> _changeCurrentViewModel;

        public IEnumerable<ITrainingWeek> TrainingWeek { get => _trainingCourse.TrainingWeeks; }


        private RelayCommand _openExerciesPage;
        public ICommand OpenExerciesPage
        {
            get => RelayCommand.GetCommand<IExercise>(ref _openExerciesPage, (exericise) =>
            {
                var backNavCommand = new NavigateCommand(_changeCurrentViewModel, () => this);
                _changeCurrentViewModel(new ExercisePageViewModel(exericise, backNavCommand));
            });
        }

        public ICommand BackCommand { get; }

        public TrainingCourseViewModel(ITrainingCourse trainingCourse, ICommand backCommand, Action<ViewModelBase> changeCurrentViewModel)
        {
            _trainingCourse = trainingCourse;
            BackCommand = backCommand;
            _changeCurrentViewModel = changeCurrentViewModel;
        }
    }
}
