using Utilities.Repository;

namespace Core.Users.Domain.Services
{
	public interface IUsersRepository : ICrudRepository
	{
		public IList<Model.Users> GetUsers();
		public Model.Users GetUser(Guid id);
		public Model.Users GetUserByEmail(string email);
	}
}