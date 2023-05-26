

using Core.Users.Domain.Services;
using Utilities;

namespace Core.Users.App.DTO
{
    public class AuthUserDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public AuthUserDTO(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public Domain.Model.Users ToModel(IUsersRepository repository)
        {
            var userInformation = repository.GetUserByEmail(Email);
            Security.VerifyPassword(Password, userInformation.Token);
            return Domain.Model.Users.Of(userInformation.Id, userInformation.Name, userInformation.Email, userInformation.Token);
        }
    }
}
