using Core.Preferences.Domain.ReadModels;

namespace Core.Preferences.App.DTO
{
    public class PreferencesDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public IList<Exchange.Domain.Model.Exchange> Exchanges { get; set; }
        public IList<Country.Domain.Model.Country> Countries { get; set; }
        public IList<Industry.Domain.Model.Industry> Industries { get; set; }

        private PreferencesDTO(Guid id, Guid userId, IList<Exchange.Domain.Model.Exchange> exchanges, IList<Country.Domain.Model.Country> countries, IList<Industry.Domain.Model.Industry> industries)
        {
            Id = id;
            UserId = userId;
            Exchanges = exchanges;
            Countries = countries;
            Industries = industries;
        }

        public static PreferencesDTO Of(Domain.Model.Preferences model)
        {
            return new PreferencesDTO(model.Id, model.UserId, model.Exchanges, model.Countries, model.Industries);
        }

        public static PreferencesDTO Of(PreferencesReadModel model)
        {
            return new PreferencesDTO(model.Id, model.UserId, model.Exchanges, model.Countries, model.Industries);
        }

        public Domain.Model.Preferences ToModel()
        {
            return Domain.Model.Preferences.Of(Id, UserId, Exchanges, Countries, Industries);
        }
    }
}
