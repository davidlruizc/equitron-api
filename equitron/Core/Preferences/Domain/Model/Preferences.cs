using Utilities.Domain;

namespace Core.Preferences.Domain.Model
{
    public class Preferences : BaseEntity
    {
        public Guid UserId { get; set; }
        public IList<Exchange.Domain.Model.Exchange> Exchanges { get; set; }
        public IList<Country.Domain.Model.Country> Country { get; set; }
        public IList<Industry.Domain.Model.Industry> Industry { get; set; }
        public string Symbol { get; set; }

        private Preferences(Guid id,  string symbol, Guid userId)
        {
            Id = id;
            Symbol = symbol;
            UserId = userId;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Preferences Of(Guid id, string symbol, Guid userId)
        {
            return new Preferences(id, symbol, userId);
        }
    }
}
