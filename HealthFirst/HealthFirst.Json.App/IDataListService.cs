namespace HealthFirst.Json.App
{
    public interface IDataListService<T>
    {
        void Write(IEnumerable<T> items);
        IEnumerable<T> Read();
    }
}
