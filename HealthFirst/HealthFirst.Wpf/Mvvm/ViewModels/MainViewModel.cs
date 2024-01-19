using HealthFirst.Core.Training.Builders;
using HealthFirst.Core.Training.Interfaces;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Modal;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.Layouts;
using HealthFirst.WPF.Mvvm.ViewModels.Modal;

namespace HealthFirst.WPF.Mvvm.ViewModels
{
    public sealed class MainViewModel : ViewModelBase   
    {
        private readonly INavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel { get => _navigationStore.CurrentViewModel; }


        private ModalNavigationStore _modalNavigationStore = new();

        public IModalViewModel CurrentModalViewModel { get => _modalNavigationStore.CurrentViewModel; } 
        public bool IsModalOpen { get => _modalNavigationStore.CurrentViewModel != null; }



        public MainViewModel(INavigationStore navigationStore) 
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;


            var trainings = new List<ITrainingCourse>();

            var exerciesBuilder = new ExercisesBuilder().AddPresentationInfo("Home training", "...", "...", 4, 12, TimeSpan.FromSeconds(60));

            _navigationStore.CurrentViewModel = new TrainingMenuLayoutViewModel(); //new TrainingCourseViewModel();//new TrainingViewModel(new List<TrainingCourse>()); //new MainMenuLayoutViewModel();
            _modalNavigationStore.CurrentViewModelChanged += OnModalCurrentViewModelChanged;

            _modalNavigationStore.RegisterModalViewModel(typeof(AddTrainingCourseViewModel), () => new AddTrainingCourseViewModel());
            //_modalNavigationStore.OpenRegisteredModal(typeof(AddTrainingCourseViewModel));
        }

        private void OnModalCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentModalViewModel));
            OnPropertyChanged(nameof(IsModalOpen));
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}