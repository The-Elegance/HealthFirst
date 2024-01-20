using HealthFirst.App.Models.Todo;
using HealthFirst.WPF.Mvvm.Core.Commands;
using HealthFirst.WPF.Mvvm.Core.Modal;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.Modal.TodoItemFactory
{
    public sealed class TodoItemFactoryViewModel : ModalViewModelBase
    {
        public TodoItemModel Model { get; }

        private readonly Action<TodoItemModel> _addItemModel;

        public TodoItemFactoryViewModel(Action<TodoItemModel> addItemModel)
        {
            Model = new TodoItemModel();
            _addItemModel = addItemModel;
        }

        public RelayCommand _addItemCommand;
        public ICommand AddItemCommand 
        {
            get => RelayCommand.GetCommand(ref _addItemCommand, () => 
            { 
                _addItemModel?.Invoke(Model);
                CloseCommand?.Execute(null);
            });
        }
    }
}
