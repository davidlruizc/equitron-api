using System;
using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class UserExchange : BaseEntity
	{
		public Guid UserId { get; set; }
		public Guid ExchangeId { get; set; }

		private UserExchange(Guid id, Guid userId, Guid exchangeId)
		{
			Id = id;
			UserId = userId;
			ExchangeId = exchangeId;
		}

		internal void Initialize()
		{
            InitializeBase();
		}

		public static UserExchange Of(Guid userId, Guid exchangeId)
		{
			return new UserExchange(Guid.Empty, userId, exchangeId);
		}
	}
}

