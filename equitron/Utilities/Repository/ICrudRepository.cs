namespace Utilities.Repository
{
    public interface ICrudRepository
    {
        void Save<TE>(TE entity) where TE : class;
        void Delete<TE>(object entity) where TE : class;
    }
}
