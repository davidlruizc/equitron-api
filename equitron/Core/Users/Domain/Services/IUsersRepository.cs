namespace Core.Users.Domain.Services
{
	public interface IUsersRepository
	{
		public IList<Model.Users> GetUsers();
	}
}

