using JWTAuthAuthentication.Models;
using System.Security.Claims;

namespace Api_autenticacao_JWT.Extentions
{
    public static class RoleClaimExtention
    {
        public static IEnumerable<Claim> GetClaims(this User user)
        {
            var result = new List<Claim>
            {
                new(ClaimTypes.Name, user.Name),
                new(ClaimTypes.Email, user.Email),
                new(ClaimTypes.Role, user.Roles.Name)
            };
            return result;
        } 
    }
}
