using System;
namespace Core.Users.App.DTO
{
	public class CreateUserPreferenceDTO
	{
		public Guid UserId { get; set; }
		public IList<Guid> UserExchanges { get; set; }
        public IList<Guid> UserCountries { get; set; }
        public IList<Guid> UserIndustries { get; set; }

        public CreateUserPreferenceDTO(Guid userId, IList<Guid> userExchanges, IList<Guid> userCountries, IList<Guid> userIndustries)
		{
			UserId = userId;
			UserExchanges = userExchanges;
			UserCountries = userCountries;
			UserIndustries = userIndustries;
		}

		public static CreateUserPreferenceDTO Of(Guid userId, IList<Guid> userExchanges, IList<Guid> userCountries, IList<Guid> userIndustries)
		{
			return new CreateUserPreferenceDTO(userId, userExchanges, userCountries, userIndustries);

        }
    }
}

