using Core.Users.App.DTO;
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
	}
}

