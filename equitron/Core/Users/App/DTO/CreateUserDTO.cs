using Utilities;

namespace Core.Users.App.DTO
{
    public class CreateUserDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set;}

        public CreateUserDTO(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public Domain.Model.Users ToModel()
        {
            var id = Guid.NewGuid();
            var passwordHash = Security.HashPassword(Password);
            return Domain.Model.Users.Of(id, Name, Email, passwordHash);
        }
    }
}
