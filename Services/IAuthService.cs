using YmyPixels.Entities;

namespace YmyPixels.Services;

public interface IAuthService
{
    Task<User> Authenticate(string discordCode);
    string ValidateToken(string token, string claim);
}