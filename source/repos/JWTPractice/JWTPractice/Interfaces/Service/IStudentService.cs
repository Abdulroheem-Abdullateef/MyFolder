using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTPractice.DTOS;

namespace JWTPractice.Interfaces.Service
{
    public interface IStudentService
    {
    
       Task<BaseResponse<StudentDto>> CreateStudent(CreateStudentRequestModel model);
       Task<BaseResponse<StudentDto>> UpdateStudent(int id,UpdateStudentRequestModel model);
       Task<BaseResponse<List<StudentDto>>>GetAllStudent();
       Task<BaseResponse<StudentDto>> GetStudentById(int id);
       Task<BaseResponse<StudentDto>> DeleteStudent(int id);
       Task<BaseResponse<StudentDto>> LoginStudent(LoginStudentDto model);
    }
}
