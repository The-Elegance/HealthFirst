using HealthFirst.WPF.Mvvm.Core.Modal;

namespace HealthFirst.WPF.Mvvm.Core.Stores
{
    public interface IModalNavigationStore
    {
        IModalViewModel CurrentViewModel { get; }
        void Open(IModalViewModel viewModel);
        void RegisterModalViewModel(Type viewModel, Func<IModalViewModel> factory);
        void UnregisterModalViewModel(Type viewModel);
        void OpenRegisteredModal(Type type);
        void Close(object obj);
    }
}