using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApiProject.Implementations.Repositories
{
    public class MedicalRecordRepository : IMedicalRecordRepository
    {
        private readonly MyContext _context;
        public MedicalRecordRepository(MyContext context)
        {
            _context = context;
        }
        public List<MedicalRecordDTO> MedicalCases(int DoctorId)
        {
            return _context.MedicalRecords.Where(r => r.DoctorId == DoctorId).Select(host => new MedicalRecordDTO
            {
                PatientComplain = host.PatientComplain,
            }).ToList();
        }
        public MedicalRecordDTO Create(MedicalRecord MedicalRecord)
        {
            _context.MedicalRecords.Add(MedicalRecord);
            _context.SaveChanges();
            return new MedicalRecordDTO
            {
                Id = MedicalRecord.Id,
                Diagnosis = MedicalRecord.Diagnosis,
                Prescription = MedicalRecord.Prescription,
                PatientComplain = MedicalRecord.PatientComplain,
                DoctorReport = MedicalRecord.DoctorReport,
                Refferral = MedicalRecord.Refferral,
                // HospitalId = MedicalRecord.Hospital.Id,
                // HospitalName = MedicalRecord.Hospital.Name
            };
        }
        public void Delete(MedicalRecord MedicalRecord)
        {
            _context.MedicalRecords.Remove(MedicalRecord);
            _context.SaveChanges();
        }
        public bool ExistById(int id)
        {
            return _context.MedicalRecords.Any(e => e.Id == id);
        }
        public MedicalRecord Get(int id)
        {
            return _context.MedicalRecords.SingleOrDefault(x => x.Id == id);
        }
        public List<MedicalRecordDTO> GetAll()
        {
            return _context.MedicalRecords.Select(host => new MedicalRecordDTO
            {
                Id = host.Id,
                Diagnosis = host.Diagnosis,
                Prescription = host.Prescription,
                PatientComplain = host.PatientComplain,
                DoctorReport = host.DoctorReport,
                Refferral = host.Refferral,
                HospitalId = host.Hospital.Id,
                HospitalName = host.Hospital.Name,
                DateVisited = host.DateVisited,
                PatientName = $"{host.Patient.LastName}  {host.Patient.FirstName}",
                DoctorName = $"{host.Doctor.LastName}  {host.Doctor.FirstName}",
            }).ToList();
        }
        public IEnumerable<MedicalRecord> GetSelectedMedicalrecords(IList<int> ids)
        {
            return _context.MedicalRecords.Where(r => ids.Contains(r.Id)).ToList();
        }
        public List<MedicalRecordDTO> InitializedMedicalCases()
        {
            return _context.MedicalRecords
            .Where(r => r.MedicalRecordStatus == Enums.MedicalRecordStatus.Initialize)
            .Select(host => new MedicalRecordDTO
            {
                Id = host.Id,
                PatientName = $"{host.Patient.FirstName} {host.Patient.LastName}",
                PatientComplain = host.PatientComplain,
                DoctorId = host.DoctorId,
                // HospitalId = host.Hospital.Id,
                // HospitalName = host.Hospital.Name
            }).ToList();
        }
        public List<MedicalRecordDTO> RefferalNeededCases()
        {
            return _context.MedicalRecords.Where(c => c.Refferral == Enums.Refferral.Needed).Select(host => new MedicalRecordDTO
            {
                Id = host.Id,
                PatientName = $"{host.Patient.FirstName} {host.Patient.LastName}",
                DoctorName = $" Dr. {host.Doctor.FirstName} {host.Doctor.LastName}",
                Diagnosis = host.Diagnosis,
                Prescription = host.Prescription,
                PatientComplain = host.PatientComplain,
                DoctorReport = host.DoctorReport,
                Refferral = host.Refferral,
                // HospitalId = host.Hospital.Id,
                // HospitalName = host.Hospital.Name

            }).ToList();
        }
        public List<MedicalRecordDTO> RefferalNotNeededCases()
        {
            return _context.MedicalRecords.Where(c => c.Refferral == Enums.Refferral.NotNeeded).Select(host => new MedicalRecordDTO
            {
                Id = host.Id,
                PatientName = $"{host.Patient.FirstName} {host.Patient.LastName}",
                DoctorName = $" Dr. {host.Doctor.FirstName} {host.Doctor.LastName}",
                Diagnosis = host.Diagnosis,
                Prescription = host.Prescription,
                PatientComplain = host.PatientComplain,
                DoctorReport = host.DoctorReport,
                Refferral = host.Refferral,
                // HospitalId = host.Hospital.Id,
                // HospitalName = host.Hospital.Name

            }).ToList();
        }
        public MedicalRecordDTO ReturnById(int Id)
        {
            var host = _context.MedicalRecords.FirstOrDefault(r => r.Id == Id);
            return new MedicalRecordDTO
            {
                Id = host.Id,
                DoctorName = $" Dr. {host.Doctor.FirstName} {host.Doctor.LastName}",
                PatientName = $"{host.Patient.FirstName}  {host.Patient.LastName}",
                Diagnosis = host.Diagnosis,
                Prescription = host.Prescription,
                PatientComplain = host.PatientComplain,
                DoctorReport = host.DoctorReport,
                Refferral = host.Refferral,
                DateVisited = host.DateVisited,
                HospitalId = host.Hospital.Id,
                HospitalName = host.Hospital.Name
            };
        }
        public List<MedicalRecordDTO> TreatedMedicalCases()
        {
            return _context.MedicalRecords
            .Where(r => r.MedicalRecordStatus == Enums.MedicalRecordStatus.Treated)
            .Select(host => new MedicalRecordDTO
            {
                Id = host.Id,
                DoctorName = $"{host.Doctor.FirstName} {host.Doctor.LastName}",
                PatientName = $"{host.Patient.FirstName}  {host.Patient.LastName}",
                Diagnosis = host.Diagnosis,
                Prescription = host.Prescription,
                PatientComplain = host.PatientComplain,
                DoctorReport = host.DoctorReport,
                Refferral = host.Refferral,
                HospitalId = host.Hospital.Id,
                HospitalName = host.Hospital.Name,
                DateVisited = host.DateVisited
            }).ToList();
        }
        public MedicalRecord Update(MedicalRecord MedicalRecord)
        {
            _context.MedicalRecords.Update(MedicalRecord);
            _context.SaveChanges();
            return MedicalRecord;
        }

        public List<MedicalRecordDTO> AssignedMedicalCases()
        {
            return _context.MedicalRecords
           .Where(r => r.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned)
           .Select(host => new MedicalRecordDTO
           {
               Id = host.Id,
               PatientName = $"{host.Patient.FirstName} {host.Patient.LastName}",
               DoctorName = $" Dr. {host.Doctor.FirstName} {host.Doctor.LastName}",
               Diagnosis = host.Diagnosis,
               Prescription = host.Prescription,
               PatientComplain = host.PatientComplain,
               DoctorReport = host.DoctorReport,
               Refferral = host.Refferral,
            //    HospitalId = host.Hospital.Id,
            //    HospitalName = host.Hospital.Name
           }).ToList();
        }

        public MedicalRecord GetByPatientId(int patientId)
        {
            return _context.MedicalRecords
            .FirstOrDefault(c => c.PatientId == patientId && c.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned);

        }

        public List<MedicalRecordDTO> AssignedMedicalCases(int DoctorId)
        {
            return _context.MedicalRecords.Where(c => c.DoctorId == DoctorId && c.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned).Select(medic => new MedicalRecordDTO
            {
                Id = medic.Id,
                DoctorName = $" Dr. {medic.Doctor.FirstName} {medic.Doctor.LastName}",
                PatientName = $"{medic.Patient.FirstName} {medic.Patient.LastName}",
                Diagnosis = medic.Diagnosis,
                Prescription = medic.Prescription,
                PatientComplain = medic.PatientComplain,
                DoctorReport = medic.DoctorReport,
                Refferral = medic.Refferral,
                DateVisited = medic.DateVisited,
                // HospitalId = medic.Hospital.Id,
                // HospitalName = medic.Hospital.Name
            }).ToList();
        }

        public List<MedicalRecordDTO> TreatedMedicalCases(int DoctorId)
        {
            return _context.MedicalRecords.Where(st => st.DoctorId == DoctorId && st.MedicalRecordStatus == Enums.MedicalRecordStatus.Treated)
            .Select(medic => new MedicalRecordDTO
            {
                Id = medic.Id,
                DoctorName = $" Dr. {medic.Doctor.FirstName} {medic.Doctor.LastName}",
                PatientName = $"{medic.Patient.FirstName} {medic.Patient.LastName}",
                Diagnosis = medic.Diagnosis,
                Prescription = medic.Prescription,
                PatientComplain = medic.PatientComplain,
                DoctorReport = medic.DoctorReport,
                Refferral = medic.Refferral,
                DateVisited = medic.DateVisited,
                HospitalId = medic.Hospital.Id,
                HospitalName = medic.Hospital.Name
            }).ToList();
        }

        public List<MedicalRecordDTO> AssignedHospital(int HospitalId)
        {

            return _context.MedicalRecords.Where(a => a.HospitalId == HospitalId && a.Refferral == Enums.Refferral.Needed && a.MedicalRecordStatus == Enums.MedicalRecordStatus.Treated)
            .Select(medic => new MedicalRecordDTO
            {
                Id = medic.Id,
                DoctorName = $" Dr. {medic.Doctor.FirstName} {medic.Doctor.LastName}",
                PatientName = $"{medic.Patient.FirstName} {medic.Patient.LastName}",
                Diagnosis = medic.Diagnosis,
                Prescription = medic.Prescription,
                PatientComplain = medic.PatientComplain,
                DoctorReport = medic.DoctorReport,
                Refferral = medic.Refferral,
                DateVisited = medic.DateVisited,
                HospitalId = medic.Hospital.Id,
                HospitalName = medic.Hospital.Name
            }).ToList();
        }

        public List<MedicalRecordDTO> GetAllByPatientId(int patientId)
        {
            return _context.MedicalRecords.Where(st => st.PatientId == patientId && st.MedicalRecordStatus == Enums.MedicalRecordStatus.Treated)
            .Select(medic => new MedicalRecordDTO
            {
                Id = medic.Id,
                DoctorName = $" Dr. {medic.Doctor.FirstName} {medic.Doctor.LastName}",
                PatientName = $"{medic.Patient.FirstName} {medic.Patient.LastName}",
                Diagnosis = medic.Diagnosis,
                Prescription = medic.Prescription,
                PatientComplain = medic.PatientComplain,
                DoctorReport = medic.DoctorReport,
                Refferral = medic.Refferral,
                DateVisited = medic.DateVisited,
                HospitalId = medic.Hospital.Id,
                HospitalName = medic.Hospital.Name
            }).ToList();
        }

        public MedicalRecordDTO GetComplainByPatientId(int PatientId)
        {
            var res = _context.MedicalRecords
            .Where(st => st.PatientId == PatientId && st.MedicalRecordStatus == Enums.MedicalRecordStatus.Assigned).
            FirstOrDefault();
            return new MedicalRecordDTO
            {
                Id = res.Id,
                PatientComplain = res.PatientComplain,
            };

        }
    }
}