using HealthFirst.WPF.Mvvm.Core.Commands;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.Core.Modal
{
    public abstract class ActionModalViewModelBase : ViewModelBase, IActionModelViewModel
    {
        public event Action<object> CloseCommandExecutedEvent;
        public event Action<object> ActionCommandExecutedEvent;


        #region Commands


        private RelayCommand _closeCommand;
        public ICommand CloseCommand
        {
            get => RelayCommand.GetCommand(ref _closeCommand, (obj) =>
            {
                CloseCommandExecutedEvent?.Invoke(obj);
            });
        }

        private RelayCommand _actionCommand;
        public ICommand ActionCommand
        {
            get => RelayCommand.GetCommand(ref _actionCommand, (obj) =>
            {
                ActionCommandExecutedEvent?.Invoke(obj);
                if (IsCloseAfterCommandExecuted)
                    CloseCommand.Execute(obj);
            });
        }


        #endregion Commands


        public bool IsCloseAfterCommandExecuted { get; set; } = true;
    }
}
