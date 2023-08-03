using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiProject.Dtos;
using Microsoft.IdentityModel.Tokens;

namespace ApiProject.Auth
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
         private readonly string _key;

        public JwtAuthenticationManager(string key)
        {
            _key = key;
        }

        public string GenerateToken(UserDTO user)
        {

            var tokenHandler = new JwtSecurityTokenHandler();

            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.FirstName),
            };
            foreach(var item in user.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, item.RoleName));
            }

            var tokenDescriptior = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                IssuedAt = DateTime.Now,
                Expires = DateTime.Now.AddDays(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), 
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptior);

            return tokenHandler.WriteToken(token);
        }
    }
}