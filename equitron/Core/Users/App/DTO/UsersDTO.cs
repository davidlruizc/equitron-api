namespace Core.Users.App.DTO
{
	public class UsersDTO
	{
		public string Name { get; set; }
		public string Token { get; set; }

		private UsersDTO(string Name, string Token)
		{
			Name = Name;
			Token = Token;
		}

		public UsersDTO Of(Domain.Model.Users model)
		{
			return new UsersDTO(model.Name, model.Token);
		}
	}
}

