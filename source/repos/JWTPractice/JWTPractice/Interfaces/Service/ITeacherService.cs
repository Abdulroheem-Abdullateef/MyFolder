using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JWTPractice.DTOS;

namespace JWTPractice.Interfaces.Service
{
   public interface ITeacherService
    {
        Task<BaseResponse<TeacherDto>> CreateTeacher(CreateTeacherRequestModel model);
        Task<BaseResponse<TeacherDto>> UpdateTeacher(int id, UpdateTeacherRequestModel model);
        Task<BaseResponse<TeacherDto>> GetTeacher(int id);
        Task<BaseResponse<List<TeacherDto>>> GetAllTeacher();
        Task<BaseResponse<TeacherDto>> DeleteTeacher(int id);
        Task<BaseResponse<TeacherDto>> LoginTeacher(LoginTeacherDto model);
    }
}
