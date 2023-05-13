using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Preferences.App.DTO
{
    public class PreferencesDTO
    {
        public Guid Id { get; set; }
        public string Symbol { get; set; }
        public Guid UserId { get; set; }

        private PreferencesDTO(Guid id, string symbol, Guid userId)
        {
            Id = id;
            Symbol = symbol;
            UserId = userId;
        }

        public PreferencesDTO Of(Domain.Model.Preferences model)
        {
            return new PreferencesDTO(model.Id, model.Symbol, model.UserId);
        }
    }
}
