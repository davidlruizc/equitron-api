
namespace Utilities
{
    public class Security
    {
        public static string HashPassword(string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            return passwordHash;
        }

        public static void VerifyPassword(string password, string passwordHash)
        {
            bool isValid = BCrypt.Net.BCrypt.Verify(password, passwordHash);
            if (!isValid)
            {
                throw new Exception("Invalid password");
            }
        }
    }
}
