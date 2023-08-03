using KpiNew.Dto;

namespace KpiNew.Auth
{
    public interface IJwtAuthenticationManager
    {
        public string GenerateToken(UserDto user);

    }
}
