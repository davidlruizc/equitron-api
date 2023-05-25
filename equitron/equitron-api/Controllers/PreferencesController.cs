using Core.Preferences.App;
using Core.Preferences.App.DTO;
using Microsoft.AspNetCore.Mvc;

namespace equitron_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        private readonly PreferencesService service;

        public PreferencesController(PreferencesService service)
        {
            this.service = service;
        }

        [HttpGet("get-preferences-by-user/{id}")]
        public IEnumerable<PreferencesDTO> GetPreferencesByUser(Guid id)
        {
            return service.GetPreferenceByUser(id);
        }

        [HttpPost("create-preference")]
        public PreferencesDTO CreatePreference(PreferencesDTO dto)
        {
            return service.CreatePreference(dto);
        }
    }
}
