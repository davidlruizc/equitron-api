using Utilities.Domain;

namespace Core.Users.Domain.Model
{
	public class Users : BaseEntity
    {
		public string Name { get; set; }
		public string Token { get; set; }

		private Users(Guid id, string name, string token)
		{
			Id = id;
            Name = name;
            Token = token;
        }

        internal void Initialize()
        {
            InitializeBase();
        }

        public static Users Of(Guid id, string Name, string Token)
		{
			return new Users(id, Name, Token);
		}
	}
}