using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Library.Service;

public interface TokenService
{
    JwtSecurityToken GetToken(List<Claim> authClaims);
    string RefreshToken(JwtSecurityToken token);
}