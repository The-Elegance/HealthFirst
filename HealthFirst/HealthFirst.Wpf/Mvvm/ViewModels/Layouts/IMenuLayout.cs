using HealthFirst.WPF.Mvvm.Core;
using HealthFirst.WPF.Mvvm.ViewModels.Sidebar;

namespace HealthFirst.WPF.Mvvm.ViewModels.Layouts
{
    interface IMenuLayout : ILayoutViewModel
    {
        SidebarViewModel Sidebar { get; }
    }
}
