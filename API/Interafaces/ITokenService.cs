using API.Entities;

namespace API.Interafaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}