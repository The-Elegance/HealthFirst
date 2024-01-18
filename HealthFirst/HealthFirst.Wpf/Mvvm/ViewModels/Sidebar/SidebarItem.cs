using HealthFirst.WPF.Mvvm.Core;

namespace HealthFirst.WPF.Mvvm.ViewModels.Sidebar
{
    public sealed class LeftPanelMenuItem : ObservableObjectBase, IComparable<LeftPanelMenuItem>
    {
        public event Action<LeftPanelMenuItem> SelectedChanged;

        public uint Id { get; set; }
        public string TextKey { get; set; }
        public string IconKey { get; set; }

        public double IconWidth { get; set; }
        public double IconHeight { get; set; }

        public ViewModelBase Content { get; set; }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected; set
            {
                _isSelected = value;

                if (_isSelected)
                {
                    SelectedChanged?.Invoke(this);
                }
                OnPropertyChanged();
            }
        }

        public int CompareTo(LeftPanelMenuItem other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
