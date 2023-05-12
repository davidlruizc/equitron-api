using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Domain;

namespace Core.Preferences.Domain.Model
{
    public class Preferences : BaseEntity
    {
        public Guid UserId { get; set; }
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
