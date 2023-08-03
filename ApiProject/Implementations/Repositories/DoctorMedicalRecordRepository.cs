using System.Linq;
using ApiProject.Dtos;
using ApiProject.Interfaces;
using ApiProject.Interfaces.IRepositories;

namespace ApiProject.Implementations.Repositories
{
    public class DoctorMedicalRecordRepository : IDoctorMedicalRecordRepository
    {
        private readonly MyContext _context;

        public DoctorMedicalRecordRepository(MyContext context)
        {
            _context = context;
        }

        public MedicalRecordDTO ViewAssignedDoctor(int DoctorId)
        {
            var md =  _context.DoctorMedicalRecords
            .Where(x => x.MedicalRecord.DoctorId == DoctorId && x.MedicalRecord.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned)
            .FirstOrDefault();
            
            return new MedicalRecordDTO
            {
                DoctorId = md.DoctorId,
                DoctorName = $" Dr. {md.Doctor.FirstName}  {md.Doctor.LastName}",
                DoctorPhoto = md.Doctor.DoctorPhoto,
                DoctorAreaOfSpec = md.Doctor.AreaOfSpec
            };
        }

        public MedicalRecordDTO ViewAssignedPatient(int PatientId)
        {

             var md =  _context.DoctorMedicalRecords
             .Where(x => x.MedicalRecord.PatientId == PatientId && x.MedicalRecord.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned)
             .FirstOrDefault();          
            return new MedicalRecordDTO
            {
                PatientId = md.MedicalRecord.PatientId,
                PatientName = $"{md.MedicalRecord.Patient.FirstName} {md.MedicalRecord.Patient.LastName}",
                PatientPhoto = md.MedicalRecord.Patient.PatientPhoto
            };
        }
    }
}