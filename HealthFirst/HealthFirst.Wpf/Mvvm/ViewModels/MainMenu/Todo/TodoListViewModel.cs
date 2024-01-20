using HealthFirst.App.Models.Todo;
using HealthFirst.App.Services;
using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Commands;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.Modal.TodoItemFactory;
using System.IO;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.ViewModels.MainMenu.Todo
{
    public sealed class TodoListViewModel : ViewModelBase
    {
        private readonly IModalNavigationStore _modalNavigationStore;

        public TodoListModel Model { get; }


        #region Commands


        private RelayCommand _toInProgressCommand;
        public ICommand ToInProgressCommand
        {
            get => RelayCommand.GetCommand(ref _toInProgressCommand, (item) =>
            {
                Model.ToInProgress(item as TodoItemModel);
            });
        }

        private RelayCommand _toNotStartedCommand;
        public ICommand ToNotStartedCommand
        {
            get => RelayCommand.GetCommand(ref _toNotStartedCommand, (item) =>
            {
                Model.ToNotStarted(item as TodoItemModel);
            });
        }

        private RelayCommand _toCompletedCommand;
        public ICommand ToCompletedCommand
        {
            get => RelayCommand.GetCommand(ref _toCompletedCommand, (item) =>
            {
                Model.ToCompleted(item as TodoItemModel);
            });
        }

        private RelayCommand _deleteCommand;
        public ICommand DeleteCommand 
        {
            get => RelayCommand.GetCommand(ref _deleteCommand, (item) => 
            {
                Model.Delete(item as TodoItemModel);
            });
        }

        private RelayCommand _addTodoItemCommand;
        public ICommand OpenTodoItemFactoryCommand 
        {
            get => RelayCommand.GetCommand(ref _addTodoItemCommand, () => 
            {
                _modalNavigationStore.Open(new TodoItemFactoryViewModel((tes) => { Model.AddItem(tes); }));
            });
        }


        private RelayCommand _saveTodoListModelCommand;
        public ICommand SaveTodoListModelCommand 
        {
            get => RelayCommand.GetCommand(ref _saveTodoListModelCommand, () => 
            {
                Model.SaveTodo();
            });
        }

        #endregion Commands


        public TodoListViewModel(IModalNavigationStore modalNavigationStore)
        {
            _modalNavigationStore = modalNavigationStore;
            if (File.Exists("N:\\VirtualStand\\Data\\todolist.json"))
                Model = new TodoService().GetTodoListModel();
            else
                Model = new TodoListModel();
        }
    }
}
