using Core.Preferences.Domain.ReadModels;
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

        public static PreferencesDTO Of(Domain.Model.Preferences model)
        {
            return new PreferencesDTO(model.Id, model.Symbol, model.UserId);
        }

        public static PreferencesDTO Of(PreferencesReadModel model)
        {
            return new PreferencesDTO(model.Id, model.Symbol, model.UserId);
        }

        public Domain.Model.Preferences ToModel()
        {
            return Domain.Model.Preferences.Of(Id, Symbol, UserId);
        }
    }
}
