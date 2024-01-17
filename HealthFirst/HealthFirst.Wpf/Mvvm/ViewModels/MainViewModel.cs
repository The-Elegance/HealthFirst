using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Stores;

namespace HealthFirst.WPF.Mvvm.ViewModels
{
    public sealed class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; private set; }

        public MainViewModel(INavigationStore navigationStore) 
        {
            navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
