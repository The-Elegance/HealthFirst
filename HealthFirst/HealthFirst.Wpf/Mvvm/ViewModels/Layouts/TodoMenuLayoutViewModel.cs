using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Todo;

namespace HealthFirst.WPF.Mvvm.ViewModels.Layouts
{
    public class TodoMenuLayoutViewModel : ViewModelBase, ILayoutViewModel
    {
        private readonly NavigationStore _navigationStore;
        private readonly ModalNavigationStore _modalNavigationStore;

        public ViewModelBase CurrentViewModel { get => _navigationStore.CurrentViewModel; }

        public TodoMenuLayoutViewModel(ModalNavigationStore modalNavigationStore)
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;

            _navigationStore.CurrentViewModel = new TodoListViewModel(modalNavigationStore);

            _modalNavigationStore = modalNavigationStore;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
