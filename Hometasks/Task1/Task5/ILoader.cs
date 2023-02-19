namespace Task5
{
    public interface ILoader<T> where T : class
    {
        void Save(bool append, T value);
        void Save(bool append, ICollection<T> value);
        Task<ICollection<Magazine>> Load();
    }
}