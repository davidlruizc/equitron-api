using System;
using Utilities.Domain;

namespace Core.Country.Domain.Model
{
	public class Country : BaseEntity
	{
		public string Name { get; set; }
		public string ShortName { get; set; }
	}
}

