using HealthFirst.WPF.Mvvm.Core;
using System.Windows;

namespace HealthFirst.WPF.Views.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(ViewModelBase dataObject)
        {
            InitializeComponent();
            DataContext = dataObject;
        }
    }
}