using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class Users : BaseEntity
    {
		public string Name { get; set; }
		public string Token { get; set; }
	}
}