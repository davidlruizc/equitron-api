namespace Core.Preferences.Domain.ReadModels
{
    public class PreferencesReadModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public IList<Exchange.Domain.Model.Exchange> Exchanges { get; set; }
        public IList<Country.Domain.Model.Country> Countries { get; set; }
        public IList<Industry.Domain.Model.Industry> Industries { get; set; }
    }
}
