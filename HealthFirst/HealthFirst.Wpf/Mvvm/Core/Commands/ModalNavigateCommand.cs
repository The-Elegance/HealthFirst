using HealthFirst.WPF.Mvvm.Core.Modal;
using HealthFirst.WPF.Mvvm.Core.Stores;

namespace HealthFirst.WPF.Mvvm.Core.Commands
{
    public sealed class ModalNavigateCommand<T> : CommandBase where T : IModalViewModel
    {
        private readonly IModalNavigationStore _navigationStore;
        private readonly Func<T> _createViewModel;

        public ModalNavigateCommand(IModalNavigationStore navigationStore, Func<T> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navigationStore.Open(_createViewModel());
        }
    }
}
