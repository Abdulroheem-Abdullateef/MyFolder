namespace ApiProject.Entities
{
    public class DoctorMedicalRecord : BaseEntity
    {
        public int DoctorId {get; set;}
        public Doctor Doctor {get; set;}
        public int MedicalRecordId {get; set;}
        public MedicalRecord MedicalRecord {get; set;}
    }
}