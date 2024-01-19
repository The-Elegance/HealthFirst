using HealthFirst.WPF.Mvvm.Core.Commands;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.Core.Modal
{
    public abstract class ModalViewModelBase : ViewModelBase, IModalViewModel
    {
        public event Action<object> CloseCommandExecutedEvent;


        #region Commands


        private RelayCommand _closeCommand;
        public ICommand CloseCommand
        {
            get => RelayCommand.GetCommand(ref _closeCommand, (obj) =>
            {
                CloseCommandExecutedEvent?.Invoke(obj);
            });
        }


        #endregion Commands
    }
}
