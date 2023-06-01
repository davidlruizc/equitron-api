using System;
namespace Core.Users.App.DTO
{
	public class CreateUserPreferenceDTO
	{
		public Guid UserId { get; set; }
		public IList<Guid> UserExchanges { get; set; }

		public CreateUserPreferenceDTO(Guid userId, IList<Guid> userExchanges)
		{
			UserId = userId;
			UserExchanges = userExchanges;
		}

		public static CreateUserPreferenceDTO Of(Guid userId, IList<Guid> userExchanges)
		{
			return new CreateUserPreferenceDTO(userId, userExchanges);

        }
    }
}

