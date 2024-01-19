using HealthFirst.WPF.Mvvm.Core.Modal;

namespace HealthFirst.WPF.Mvvm.Core.Stores
{
    public sealed class ModalNavigationStore : IModalNavigationStore
    {
        private static readonly Dictionary<Type, Func<IModalViewModel>> _modalAbstractFactoriesByType = new();


        public event CurrentViewModelChangedEventHandler CurrentViewModelChanged;


        private IModalViewModel _currentViewModel;
        public IModalViewModel CurrentViewModel
        {
            get => _currentViewModel; private set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public void Open(IModalViewModel viewModel)
        {
            CurrentViewModel = viewModel;
            CurrentViewModel.CloseCommandExecutedEvent += Close;
        }

        public void RegisterModalViewModel(Type type, Func<IModalViewModel> factory)
        {
            if (_modalAbstractFactoriesByType.ContainsKey(type.GetType()))
                throw new ArgumentException($"{type} уже существует в словаре абстрактных фабрик модального окна");

            _modalAbstractFactoriesByType.Add(type.GetType(), factory);
        }

        public void OpenRegisteredModal(Type type)
        {
            if (!_modalAbstractFactoriesByType.ContainsKey(type.GetType()))
                throw new ArgumentException($"{type} не существует в словаре абстрактных фабрик модального окна");

            Open(_modalAbstractFactoriesByType[type.GetType()].Invoke());
        }

        public void Close(object obj)
        {
            CurrentViewModel.CloseCommandExecutedEvent -= Close;
            CurrentViewModel = null;
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public void UnregisterModalViewModel(Type type)
        {
            if (_modalAbstractFactoriesByType.ContainsKey(type.GetType()))
                throw new ArgumentException($"{type} не существует в словаре абстрактных фабрик модального окна");
        }
    }
}
