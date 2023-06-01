using Utilities.Domain;

namespace Core.Preferences.Domain.Model
{
    public class Preferences : BaseEntity
    {
        public Guid UserId { get; set; }
        public IList<Exchange.Domain.Model.Exchange> Exchanges { get; set; }
        public IList<Country.Domain.Model.Country> Countries { get; set; }
        public IList<Industry.Domain.Model.Industry> Industries { get; set; }

        private Preferences(Guid id, Guid userId, IList<Exchange.Domain.Model.Exchange> exchanges, IList<Country.Domain.Model.Country> countries, IList<Industry.Domain.Model.Industry> industries)
        {
            Id = id;
            UserId = userId;
            Exchanges = exchanges;
            Countries = countries;
            Industries = industries;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Preferences Of(Guid id, Guid userId, IList<Exchange.Domain.Model.Exchange> exchanges, IList<Country.Domain.Model.Country> countries, IList<Industry.Domain.Model.Industry> industries)
        {
            return new Preferences(id, userId, exchanges, countries, industries);
        }
    }
}
