using System;
using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class UserCountry : BaseEntity
	{
		public Guid UserId { get; set; }
		public Guid CountryId { get; set; }

		public UserCountry(Guid id, Guid userId, Guid countryId)
		{
			Id = id;
			UserId = userId;
			CountryId = countryId;
		}

		internal void Initialize()
		{
			InitializeBase();
		}

		public static UserCountry Of(Guid userId, Guid countryId)
		{
			return new UserCountry(Guid.Empty, userId, countryId);
		}
    }
}

