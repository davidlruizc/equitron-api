using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class Users : BaseEntity
    {
		public string Name { get; set; }
		public string Email { get; set; }
		public string Token { get; set; }

		private Users(Guid id, string name, string email, string token)
		{
			Id = id;
            Name = name;
            Token = token;
			Email = email;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Users Of(Guid id, string Name, string Email, string Token)
		{
			return new Users(id, Name, Email, Token);
		}
	}
}