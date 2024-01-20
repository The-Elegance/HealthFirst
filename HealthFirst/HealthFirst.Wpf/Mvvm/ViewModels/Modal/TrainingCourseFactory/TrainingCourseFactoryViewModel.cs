using HealthFirst.WPF.Mvvm.Core.Commands;
using HealthFirst.WPF.Mvvm.Core.Modal;
using HealthFirst.WPF.Mvvm.Core.Stores;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.Modal.TrainingCourseFactory
{
    public class TrainingCourseFactoryViewModel : ModalViewModelBase
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int TrainingWeekCount { get; set; } = 0;


        private readonly IModalNavigationStore _modalNavigationStore;

        public ObservableCollection<Exericise> Exericise { get; } = new ();

        public TrainingCourseFactoryViewModel(IModalNavigationStore modalNavigationStore)
        {            
            _modalNavigationStore = modalNavigationStore;

            Exericise.Add(new Exericise(0) { Name = "Пресс" });
            Exericise.Add(new Exericise(0) { Name = "ASD" });
            Exericise.Add(new Exericise(0) { Name = "AAAA" });
            Exericise.Add(new Exericise(0) { Name = "ASD" });
            Exericise.Add(new Exericise(0) { Name = "ПрDесс" });
            Exericise.Add(new Exericise(0) { Name = "A" });
            Exericise.Add(new Exericise(0) { Name = "D" });
            Exericise.Add(new Exericise(0) { Name = "AS" });
            Exericise.Add(new Exericise(0) { Name = "ПрAесс" });
        }


        private RelayCommand _editTrainingWeekCommand;
        public ICommand EditTrainingWeekCommand 
        { 
            get => RelayCommand.GetCommand(ref _editTrainingWeekCommand, (trainingWeek) => 
            {
                var backCommand = new ModalNavigateCommand<TrainingCourseFactoryViewModel>(_modalNavigationStore, () => this);
                _modalNavigationStore.Open(new TrainingWeekFactoryViewModel(backCommand, Exericise));
            });
        }

        public ICommand CreateCommand { get; }
    }
}
