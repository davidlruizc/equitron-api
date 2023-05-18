using Core.Preferences.App.DTO;
using Core.Preferences.Domain.Services;

namespace Core.Preferences.App
{
    public class PreferencesService
    {
        private readonly IPreferencesRepository repository;

        public PreferencesService(IPreferencesRepository repository)
        {
            this.repository = repository;
        }

        public IList<PreferencesDTO> GetPreferenceByUser(Guid id)
        {
            return repository.GetUserPreferences(id).Select(x => PreferencesDTO.Of(x)).ToList();
        }

        public PreferencesDTO CreatePreference(PreferencesDTO dto)
        {
            var model = dto.ToModel();
            model.Initialize();
            repository.Save(model);
            return PreferencesDTO.Of(model);
        }
    }
}
