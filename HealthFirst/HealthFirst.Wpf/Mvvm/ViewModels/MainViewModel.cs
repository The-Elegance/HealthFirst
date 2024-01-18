using HealthFirst.Core.CalendarObject;
using HealthFirst.Core.Training;
using HealthFirst.Core.Training.Builders;
using HealthFirst.Core.Training.Interfaces;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.Layouts;
using HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Trainings;
using HealthFirst.WPF.Mvvm.Views.Layouts;
using System.Security.Cryptography.X509Certificates;

namespace HealthFirst.WPF.Mvvm.ViewModels
{
    public class Ingred 
    {
        public string Product { get; }
        public int Count { get; }

        public Ingred(string procuct, int count)
        {
            Product = procuct;
            Count = count;
        }
    }

    public class IngredBuilder
    {
        public IngredBuilder AddProduct(string product) 
        {
            return this;
        }

        public IngredBuilder AddCount(int count) 
        {
            return this;
        }

        public Ingred Build() 
        {
            return null;
        }   
    }

    public class Test 
    {
        public Test AddIntegedient(Func<IngredBuilder, Ingred> g) 
        {
            var s = new IngredBuilder();
            var ingred = g?.Invoke(s);
            return this;
        }
    }



    public class TrainingCourseBuilder 
    {
        private uint _id;
        private ITrainingCourseInfo _courseInfo;
        private CalendarObjectRepeatInfo _calendarInfo;
        private ICollection<ITrainingWeek> _trainingWeeks;

        public TrainingCourseBuilder AddTrainingCourseInfo() 
        {
            return this;
        }

        public TrainingCourseBuilder AddTrainingWeek(ITrainingWeek trainingWeek) 
        {
            _trainingWeeks.Add(trainingWeek);
            return this;
        }

        public ITrainingCourse Build() 
        {
            return new TrainingCourse(_id, _courseInfo, _calendarInfo, _trainingWeeks);
        } 
    }

    public sealed class MainViewModel : ViewModelBase   
    {
        private readonly INavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel { get => _navigationStore.CurrentViewModel; }

        public MainViewModel(INavigationStore navigationStore) 
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;


            var trainings = new List<ITrainingCourse>();

            var exerciesBuilder = new ExercisesBuilder().AddPresentationInfo("Home training", "...", "...", 4, 12, TimeSpan.FromSeconds(60));

            _navigationStore.CurrentViewModel = new TrainingMenuLayoutViewModel(); //new TrainingCourseViewModel();//new TrainingViewModel(new List<TrainingCourse>()); //new MainMenuLayoutViewModel();
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}