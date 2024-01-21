using HealthFirst.WPF.Mvvm.Core.Stores;

namespace HealthFirst.WPF.Mvvm.Core.Commands
{
    public sealed class NavigateCommand<T> : CommandBase where T : ViewModelBase
    {
        private readonly INavigationStore _navigationStore;
        private readonly Func<T> _createViewModel;

        public NavigateCommand(INavigationStore navigationStore, Func<T> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }

    public sealed class NavigateCommand : CommandBase
    {
        private readonly Action<ViewModelBase> _changeCurrentViewModel;
        private readonly Func<ViewModelBase> _createViewModel;

        public NavigateCommand(Action<ViewModelBase> changeCurrentViewModel, Func<ViewModelBase> createViewModel)
        {
            _changeCurrentViewModel = changeCurrentViewModel;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _changeCurrentViewModel?.Invoke(_createViewModel());
        }
    }
}
