namespace Core.Users.App.DTO
{
	public class UsersDTO
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Token { get; set; }

		public UsersDTO(Guid id, string name, string email, string token)
		{
			Id = id;
			Name = name;
			Token = token;
			Email = email;
		}


		public static UsersDTO Of(Domain.Model.Users model)
		{
			return new UsersDTO(model.Id, model.Name, model.Email, model.Token);
		}

		public Domain.Model.Users ToModel()
		{
            return Domain.Model.Users.Of(Id, Name, Email, Token);
        }
	}
}

