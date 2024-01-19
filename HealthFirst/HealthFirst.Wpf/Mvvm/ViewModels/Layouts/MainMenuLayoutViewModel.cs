using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.Core.Stores;
using HealthFirst.WPF.Mvvm.ViewModels.Sidebar;
using System.Collections.ObjectModel;

namespace HealthFirst.WPF.Mvvm.ViewModels.Layouts
{
    public sealed class MainMenuLayoutViewModel : ViewModelBase, IMenuLayout
    {
        private readonly ViewModelBase _homeViewModel;
        private readonly ViewModelBase _trainingViewModel;
        private readonly ViewModelBase _foodViewModel;

        public INavigationStore _navigationStore;

        public ViewModelBase CurrentViewModel { get; private set; }
        public SidebarViewModel Sidebar { get; }

        public MainMenuLayoutViewModel()
        {
            Sidebar = new SidebarViewModel();
            Sidebar.SelectedItemChanged += OnLeftPanelSelectedItemChanged;

            InitDefaultLeftPanelTabs();
        }

        private void InitDefaultLeftPanelTabs() 
        {
            Sidebar.AddTabItem("Home", "Home", _homeViewModel);
            Sidebar.AddTabItem("Training", "Sport", _trainingViewModel);
            Sidebar.AddTabItem("Food", "Food", _foodViewModel);
            Sidebar.SelectFirst();
        }

        private void OnLeftPanelSelectedItemChanged(ViewModelBase content)
        {
            CurrentViewModel = content;
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
