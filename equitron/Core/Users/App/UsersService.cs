using Core.Users.App.DTO;
using Core.Users.Domain.Model;
using Core.Users.Domain.Services;

namespace Core.Users.App
{
	public class UsersService
	{
		private readonly IUsersRepository repository;

		public UsersService(IUsersRepository repository)
		{
			this.repository = repository;
		}

		public IList<UsersDTO> GetUsers()
		{
			return repository.GetUsers().Select(UsersDTO.Of).ToList();
		}

		public UsersDTO CreateUser(CreateUserDTO dto)
		{
			var model = dto.ToModel();
			model.Initialize();
			repository.Save(model);
			repository.CommitChanges();
			return UsersDTO.Of(model);
		}
		
		public UsersDTO GetUser(Guid id)
		{
			return UsersDTO.Of(repository.GetUser(id));
		}

		public UsersDTO GetUserByEmail(string email)
		{
			return UsersDTO.Of(repository.GetUserByEmail(email));
		}

		public UsersDTO AuthUser(AuthUserDTO dto)
		{
			var model = dto.ToModel(repository);
			return UsersDTO.Of(model);
		}

		public CreateUserPreferenceDTO CreateUserPreferences(CreateUserPreferenceDTO dto)
		{
			foreach(var exchangeId in dto.UserExchanges)
			{
				var model = UserExchange.Of(dto.UserId, exchangeId);
				model.Initialize();
				repository.Save(model);
			}
			repository.CommitChanges();
			return CreateUserPreferenceDTO.Of(dto.UserId, dto.UserExchanges);
		}
    }
}

