using HealthFirst.Core.Training;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Commands;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Trainings;

namespace HealthFirst.WPF.Mvvm.ViewModels.Layouts
{
    public sealed class TrainingMenuLayoutViewModel : ViewModelBase, ILayoutViewModel
    {
        private INavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel { get => _navigationStore.CurrentViewModel ;}

        private TrainingsViewModel _trainingsViewModel;

        public TrainingMenuLayoutViewModel()
        {
            _navigationStore = new NavigationStore();

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            BackCommand = new NavigateCommand<ViewModelBase>(_navigationStore, () => _trainingsViewModel);
            _trainingsViewModel = new TrainingsViewModel(new List<TrainingCourse>(), ChangeCurrentViewModel, BackCommand);
            _navigationStore.CurrentViewModel = _trainingsViewModel;
        }

        public NavigateCommand<ViewModelBase> BackCommand { get; }

        private void ChangeCurrentViewModel(ViewModelBase viewModelBase) 
        {
            _navigationStore.CurrentViewModel = viewModelBase;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
