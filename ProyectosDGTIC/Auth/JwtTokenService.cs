using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Sigetic.Service.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProyectosDGTIC.Auth
{
    public class JwtTokenService : IUserTwoFactorTokenProvider<AppUser>
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JwtTokenOptions _options;

        public JwtTokenService(
            JwtTokenOptions options,
            RoleManager<IdentityRole> roleManager
        )
        {
            _roleManager = roleManager;
            _options = options;
        }

        public virtual async Task<string> GenerateAsync(string purpose, UserManager<AppUser> userManager, AppUser user)
        {
            var currentUser = user as AppUser;

            var credencials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Key)),
                SecurityAlgorithms.HmacSha256
            );

            var claims = await userManager.GetClaimsAsync(user);

            claims.Add(new Claim(ClaimTypes.Name, currentUser?.UserName));
            //claims.Add(new Claim(ClaimTypes.NameIdentifier, currentUser?.FullName));
            claims.Add(new Claim(ClaimTypes.Email, currentUser?.Email));
            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, _options.Subject));
            claims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));

            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            claims.Add(new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()));

            var roles = await userManager.GetRolesAsync(user);

            foreach (var rol in roles)
                claims.Add(new Claim(ClaimTypes.Role, rol));

            var durationMinutesToken =
                /// _roleManager.Roles.Where(w => roles.Contains(w.Name)).Max(m => m.DurationMinutesToken) ??/
                _options.DurationMinutes;

            var expirationTime = DateTime.UtcNow.AddMinutes(durationMinutesToken);

            var token = new JwtSecurityToken(
                _options.Issuer,
                _options.Audience,
                claims,
                expires: expirationTime,
                signingCredentials: credencials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public Task<bool> ValidateAsync(string purpose, string token, UserManager<AppUser> manager, AppUser user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<AppUser> manager, AppUser user)
        {
            return Task.FromResult(false);
        }
    }
}
