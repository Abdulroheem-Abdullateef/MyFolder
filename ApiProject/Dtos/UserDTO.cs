using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ApiProject.Entities;

namespace ApiProject.Dtos
{
    public class UserDTO
    {
        public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}        
        public string Email {get; set;}
        public string Password {get; set;}    
        public IList<RoleDTO> Roles {get;set;} = new List<RoleDTO>();    
       
    }
    public class CreateUserModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}        
        public string Email {get; set;}
        public string Password {get; set;}     
    }
    public class UpdateUserModel
    {
        public string FirstName {get; set;}
        public string LastName {get; set;} 
        public string Password {get; set;}     
    }
    public class UserLogInModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email {get; set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password {get; set;}  
    }
    
    public class LoginResponseDto : BaseResponse<UserDTO>
    {
        public string Token {get;set;}
    }
}