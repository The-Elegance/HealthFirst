namespace HealthFirst.WPF.Mvvm.Core.Modal
{
    public interface IModalAbstractFactory<T> where T : IModalViewModel
    {
        T Create();
    }
}
