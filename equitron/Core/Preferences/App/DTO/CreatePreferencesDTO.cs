
namespace Core.Preferences.App.DTO
{
    public class CreatePreferencesDTO
    {
        public Guid UserId { get; set; }
        public IList<Guid> Exchanges { get; set; }
        public IList<Guid> Countries { get; set; }
        public IList<Guid> Industries { get; set; }

        public CreatePreferencesDTO(Guid userId, IList<Guid> exchanges, IList<Guid> countries, IList<Guid> industries)
        {
            UserId = userId;
            Exchanges = exchanges;
            Countries = countries;
            Industries = industries;
        }

        public Domain.Model.Preferences ToModel()
        {
            var id = Guid.NewGuid();
            return Domain.Model.Preferences.Of(id, UserId, Exchanges, Countries, Industries);
        }
    }
}
