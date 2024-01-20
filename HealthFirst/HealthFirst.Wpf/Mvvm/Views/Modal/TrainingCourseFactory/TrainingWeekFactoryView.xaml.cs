using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HealthFirst.WPF.Mvvm.Views.Modal.TrainingCourseFactory
{
    /// <summary>
    /// Логика взаимодействия для TrainingWeekFactoryView.xaml
    /// </summary>
    public partial class TrainingWeekFactoryView : UserControl
    {
        public TrainingWeekFactoryView()
        {
            InitializeComponent();
        }

        private void Border_MouseMove(object sender, MouseEventArgs e)
        {
            var ellipse = sender as Border;
            if (ellipse != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(ellipse, ellipse.DataContext.ToString(), DragDropEffects.All);
            }
        }
    }
}
