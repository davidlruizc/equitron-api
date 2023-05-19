using Core.Preferences.Domain.ReadModels;
using Core.Preferences.Domain.Services;
using Infrastructure.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Repository;

namespace Infrastructure.Repositories
{
    public class PreferencesRepository : EntityFrameworkRepository<EquitronContext>, IPreferencesRepository
    {
        public PreferencesRepository(EquitronContext dbContext) : base(dbContext)
        {
        }
        
        public IList<PreferencesReadModel> GetUserPreferences(Guid id)
        {
            var query = from preference in dbContext.Preferences
                        where preference.UserId == id
                        select new PreferencesReadModel
                        {
                            Id = preference.Id,
                            UserId = preference.UserId,
                            Symbol = preference.Symbol
                        };
            return query.ToList();
        }
    }
}
