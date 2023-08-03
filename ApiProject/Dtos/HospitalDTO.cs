using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiProject.Dtos
{
    public class HospitalDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hospitalmail { get; set; }
        //public string Password { get; set; }
        public List<MedicalRecordDTO> MedicalRecords {get; set;} = new List<MedicalRecordDTO>();

    }
    public class CreateHospitalModel
    {
        [Required(ErrorMessage = "This field is required to be filled")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        public string Address { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.EmailAddress)]
        public string Hospitalmail { get; set; }
        [Required(ErrorMessage = "This field is required to be filled")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class UpdateHospitalModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hospitalmail { get; set; }
    }

}