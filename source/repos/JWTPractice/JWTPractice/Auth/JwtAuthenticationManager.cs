using JWTPractice.DTOS;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTPractice.Auth
{
    public class JwtAuthenticationManager
    {
        private readonly string _key;

        public JwtAuthenticationManager(string key)
        {
            _key = key;
        }

        public string GenerateToken(StudentDto student)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenkey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, student.Id.ToString()),
                    new Claim(ClaimTypes.Name, student.FirstName),
                    new Claim(ClaimTypes.Role, "Student")

                }),
                IssuedAt = DateTime.Now,
                Expires = DateTime.Now.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenkey),SecurityAlgorithms.HmacSha256Signature) 

            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
