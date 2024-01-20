using HealthFirst.WPF.Mvvm.Core.Commands;
using HealthFirst.WPF.Mvvm.Core.Modal;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.Modal.TrainingCourseFactory
{
    public sealed class Exericise 
    {
        public uint Id { get; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }

        /// <summary>
        /// Sets count of exercies. 
        /// </summary>
        public uint SetsCount { get; set; }
        /// <summary>
        /// Repetition count of exercies.
        /// </summary>
        public uint RepsCount { get; set; }
        /// <summary>
        /// Time of rest between sets in seconds.
        /// </summary>
        public TimeSpan RestTime { get; set; }

        public Exericise(uint id)
        {
            Id = id;
        }
    }

    public sealed class TrainingDay
    {
        public uint Id { get; }
        public uint Number { get; }
        public string Title { get; set; }
        public bool IsRestDay { get; set; }
        public ObservableCollection<Exericise> SelectedExericies { get; } = new ObservableCollection<Exericise>();
        public ObservableCollection<Exericise> AvailableExercies { get; }

        public TrainingDay(uint id, IList<Exericise> availableExercies)
        {
            Id = id;
            Number = id + 1;
            Title = $"Day {id}";

            AvailableExercies = new ObservableCollection<Exericise>(availableExercies);
        }
    }

    public sealed class TrainingWeekFactoryViewModel : ModalViewModelBase
    {
        public ICommand BackCommand { get; }

        private RelayCommand _selectDayCommand;
        public ICommand SelectDayCommand 
        {
            get => RelayCommand.GetCommand(ref _selectDayCommand, (obj) => 
            {
                if (int.TryParse(obj.ToString(), out int res)) 
                {
                    SelectedDay = TrainingDays[res - 1];
                    OnPropertyChanged(nameof(SelectedDay));
                }
            });
        }

        private RelayCommand _selectExerciseCommand;
        public ICommand SelectExerciseCommand 
        {
            get => RelayCommand.GetCommand(ref _selectExerciseCommand, (obj) => 
            {
                var ex = obj as Exericise;

                SelectedDay.AvailableExercies.Remove(ex);
                SelectedDay.SelectedExericies.Add(ex);

                ex.IsSelected = true;
                OnPropertyChanged(nameof(ex.IsSelected));
            });
        }

        private RelayCommand _unselectExerciseCommand;
        public ICommand UnselectExerciseCommand
        {
            get => RelayCommand.GetCommand(ref _unselectExerciseCommand, (obj) =>
            {
                var ex = obj as Exericise;

                SelectedDay.SelectedExericies.Remove(ex);
                SelectedDay.AvailableExercies.Add(ex);
               
                ex.IsSelected = false;
                OnPropertyChanged(nameof(ex.IsSelected));
            });
        }

        public TrainingDay SelectedDay { get; private set; }

        public IList<TrainingDay> TrainingDays { get; }

        public TrainingWeekFactoryViewModel(ICommand backCommand, IList<Exericise> avaiableExericise)
        {
            BackCommand = backCommand;

            TrainingDays = new ObservableCollection<TrainingDay>(
                Enumerable.Range(0, 7)
                .Select(wd => new TrainingDay((uint)wd, avaiableExericise))
                .ToList()
                );
            SelectedDay = TrainingDays[0];
        }
    }
}
