namespace HealthFirst.WPF.Mvvm.Core.Stores
{
    public class NavigationStore : INavigationStore
    {
        public event CurrentViewModelChangedEventHandler CurrentViewModelChanged;

        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel; set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
