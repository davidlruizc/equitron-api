using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Domain;

namespace Core.Exchange.Domain.Model
{
    public class Exchange : BaseEntity
    {
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
