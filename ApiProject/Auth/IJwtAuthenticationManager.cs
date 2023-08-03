using ApiProject.Dtos;

namespace ApiProject.Auth
{
    public interface IJwtAuthenticationManager
    {
       public string GenerateToken (UserDTO user);
    }
}