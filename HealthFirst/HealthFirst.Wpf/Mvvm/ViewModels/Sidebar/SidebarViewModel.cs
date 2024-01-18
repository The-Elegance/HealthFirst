using HealthFirst.WPF.Mvvm.Core;
using System.Collections.ObjectModel;

namespace HealthFirst.WPF.Mvvm.ViewModels.Sidebar
{
    public class SidebarViewModel : ViewModelBase
    {
        public event Action<ViewModelBase> SelectedItemChanged;


        #region Properties


        private ObservableCollection<LeftPanelMenuItem> _items = new ObservableCollection<LeftPanelMenuItem>();
        public IEnumerable<LeftPanelMenuItem> Items { get => _items; }


        private LeftPanelMenuItem _selectedItem;
        public LeftPanelMenuItem SelectedItem
        {
            get => _selectedItem; set
            {
                _selectedItem = value;
                SelectedItemChanged?.Invoke(value.Content);
                OnPropertyChanged();
            }
        }


        #endregion Properties


        #region Constructors


        public SidebarViewModel()
        {

        }


        #endregion Constructors


        #region Public Methods


        public void AddTabItem(string titleKey, string iconKey, ViewModelBase content, int id = -1, double iconWidth = 20, double iconHeight = 20)
        {
            if (id == -1 || id < 0)
            {
                id = _items.Count + 1;
            }

            var newTabItem = new LeftPanelMenuItem
            {
                Id = (uint)id,
                TextKey = titleKey,
                IconKey = iconKey,
                Content = content,
                IconWidth = iconWidth,
                IconHeight = iconHeight
            };

            newTabItem.SelectedChanged += OnSelectedTabItemChanged;

            _items.Add(newTabItem);
        }

        public void AddTabItem(LeftPanelMenuItem tabItem)
        {
            tabItem.SelectedChanged += OnSelectedTabItemChanged;
            _items.Add(tabItem);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void AddTabItems(IEnumerable<LeftPanelMenuItem> em)
        {

        }

        public void SelectFirst()
        {
            _items[0].IsSelected = true;
        }

        public void SelectLast()
        {
            _items[_items.Count - 1].IsSelected = false;
        }


        #endregion Public Methods


        #region Private Methods


        private void OnSelectedTabItemChanged(LeftPanelMenuItem instance)
        {
            SelectedItem = instance;
        }


        #endregion Private Methods
    }
}
