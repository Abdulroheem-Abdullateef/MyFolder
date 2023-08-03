using JWTPractice.DTOS;

namespace JWTPractice.Auth
{
    public interface IJwtAuthenticationManager
    {
        public string GenerateToken(StudentDto student);
        public string GenerateUser(TeacherDto teacher);
    }
}
