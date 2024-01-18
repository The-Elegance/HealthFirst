using HealthFirst.Core.Training;
using HealthFirst.Core.Training.Interfaces;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Commands;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Trainings
{
    public sealed class TrainingsViewModel : ViewModelBase
    {
        #region Properties


        private ICommand _backCommand;
        private Action<ViewModelBase> _changeCurrentViewModel;

        public IEnumerable<TrainingCourse> Trainings { get; }


        #endregion Properties


        #region Commands


        private RelayCommand _trainingCommand;
        public ICommand AddTrainingCommand 
        {
            get => RelayCommand.GetCommand(ref _trainingCommand, () => 
            {
                
            });
        }

        private RelayCommand _openTrainingCoursePage;
        public ICommand OpenTrainingCoursePage 
        {
            get => RelayCommand.GetCommand<ITrainingCourse>(ref _openTrainingCoursePage, (tc) => 
            {
                var backNavCommand = new NavigateCommand(_changeCurrentViewModel, () => this);
                _changeCurrentViewModel?.Invoke(new TrainingCourseViewModel(tc, backNavCommand, _changeCurrentViewModel));
            });
        }


        #endregion Commands


        #region Constructors

        // main nav point of view section
        public TrainingsViewModel(IEnumerable<TrainingCourse> trainings, Action<ViewModelBase> changeViewModel, ICommand backCommand)
        {
            Trainings = trainings;
            _changeCurrentViewModel = changeViewModel;
            _backCommand = backCommand;
        }


        #endregion Constructors
    }
}
