using HealthFirst.WPF.Mvvm.Core.Modal;

namespace HealthFirst.WPF.Mvvm.ViewModels.Modal
{
    class ModalViewModelFactory : IModalAbstractFactory<AddTrainingCourseViewModel>
    {
        public AddTrainingCourseViewModel Create()
        {
            return new AddTrainingCourseViewModel();
        }
    }
}
