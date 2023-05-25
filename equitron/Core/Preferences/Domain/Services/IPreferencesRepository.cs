using Core.Preferences.Domain.ReadModels;
using Utilities.Repository;

namespace Core.Preferences.Domain.Services
{
    public interface IPreferencesRepository : ICrudRepository
    {
        public IList<PreferencesReadModel> GetUserPreferences(Guid id);
    }
}
