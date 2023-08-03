using System;
using System.Collections.Generic;
using ApiProject.Dtos;
using ApiProject.Entities;
using ApiProject.Interfaces.IRepositories;
using ApiProject.Interfaces.IServices;
namespace ApiProject.Implementations.Services
{
    public class MedicalRecordService : IMedicalRecordService
    {
        private readonly IMedicalRecordRepository _medicalrepo;
        private readonly IPatientRepository _patientrepo;
        private readonly IDoctorRepository _doctorrepo;
        private readonly IHospitalRepository _hospitalrepo;
        private readonly IDoctorMedicalRecordRepository _doctorMedicalRecordrepo;

        public MedicalRecordService(IMedicalRecordRepository medicalrepo, IPatientRepository patientrepo, IDoctorRepository doctorrepo, IHospitalRepository hospitalrepo, IDoctorMedicalRecordRepository doctorMedicalRecordrepo)
        {
            _medicalrepo = medicalrepo;
            _patientrepo = patientrepo;
            _doctorrepo = doctorrepo;
            _hospitalrepo = hospitalrepo;
            _doctorMedicalRecordrepo = doctorMedicalRecordrepo;
        }

        public BaseResponse<List<MedicalRecordDTO>> MedicalCases(int DoctorId)
        {
             var medical = _medicalrepo.MedicalCases(DoctorId);
            if ( medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Cases has been assigned yet",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Here are the lists of cases assigned",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<MedicalRecordDTO> AssignPatientToDoctor(int MedicalRecordId, AssignDoctorRequestModel model)
        {
            var doctor = _doctorrepo.Get(model.DoctorId);
            if (doctor == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "Doctor does not exist",
                    Suceeded = false,
                    
                };
            };
            doctor.AvailabilityStatus = false;
            var medicalrecord = _medicalrepo.Get(MedicalRecordId);            
            medicalrecord.DoctorId = model.DoctorId;
            medicalrecord.Doctor = doctor;
            medicalrecord.MedicalRecordStatus = Enums.MedicalRecordStatus.Assigned;
            _medicalrepo.Update(medicalrecord);
            _doctorrepo.Update(doctor);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Doctor succesfully Assigned",
                Suceeded = true,
                Data = new MedicalRecordDTO
                {
                    Id = medicalrecord.Id                  
                    
                }
            };
        }

        public BaseResponse<bool> Delete(int id)
        {
            var medical = _medicalrepo.Get(id);
            if (medical == null)
            {
                return new BaseResponse<bool>
                {
                    Message = "MedicalRecord not exist",
                    Suceeded = false,
                    Data = false
                };
            }
            _medicalrepo.Delete(medical);
            return new BaseResponse<bool>
            {
                Message = "MedicalRecord successfully Deleted",
                Suceeded = true,
                Data = true
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> GetAll()
        {
            var medical = _medicalrepo.GetAll();
            if (medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Hospital Found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Hospital successfully retrieved",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<IList<MedicalRecordDTO>> GetMedicalRecords()
        {
            throw new System.NotImplementedException();
        }

        public BaseResponse<List<MedicalRecordDTO>> InitializedMedicalCases()
        {
            var medical = _medicalrepo.InitializedMedicalCases();
            if ( medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Cases has been assigned yet",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Here are the lists of cases assigned",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> RefferalNeededCases()
        {
            var medical = _medicalrepo.RefferalNeededCases();
            if(medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No reffered cases of medicalrecord are found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Reffered cases of medicalrecords exist",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> RefferalNotNeededCases()
        {
            var medical = _medicalrepo.RefferalNotNeededCases();
            if(medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No  non-reffered cases of medicalrecord are found",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Non-Reffered cases of medicalrecords exist",
                Suceeded = true,
                Data = medical
            };;
        }

        public BaseResponse<MedicalRecordDTO> Register(int patientId, CreateMedicalRecordModel model)
        {
            var user = _patientrepo.Get(patientId);
            if (user == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "Your data not found",
                    Suceeded = false,
                    Data = null
                };
            }
            var medicalrecord = new MedicalRecord
            {
                PatientComplain = model.PatientComplain,
                PatientId = patientId,
                Patient = user,
                DateVisited = DateTime.UtcNow,
                MedicalRecordStatus = Enums.MedicalRecordStatus.Initialize
            };
            var hosp = _medicalrepo.Create(medicalrecord);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Successfully created",
                Suceeded = true,
                Data = hosp
            };
        }

        public BaseResponse<MedicalRecordDTO> ReturnById(int id)
        {
            var res = _medicalrepo.ExistById(id);
            if (res == false)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "Medical record doesn't exist",
                    Suceeded = false
                };
            }
            var hosp = _medicalrepo.ReturnById(id);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Medical record successfully retrieved",
                Suceeded = true,
                Data = hosp
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> TreatedMedicalCases()
        {
            var medical = _medicalrepo.TreatedMedicalCases();
            if ( medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Cases has been Treated yet",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Here are the lists of cases Treated",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<MedicalRecordDTO> TreatedRefferedCases(int MedicalRecordId, int DoctorId, TreatedRefferedPatientCasesModel model)
        {
            var medical = _medicalrepo.Get(MedicalRecordId);
            var doctor = _doctorrepo.Get(DoctorId);
            if (medical == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "The medical record does not exist",
                    Suceeded = false                    
                };
            }
            doctor.AvailabilityStatus = true;            
            var medicalrecord = _medicalrepo.Get(MedicalRecordId);
            medicalrecord.Diagnosis = model.Diagnosis;
            medicalrecord.Prescription = model.Prescription;           
            medicalrecord.DoctorReport = model.DoctorReport;
            medicalrecord.MedicalRecordStatus = Enums.MedicalRecordStatus.Treated;
            medicalrecord.Refferral = model.Refferral;
            _doctorrepo.Update(doctor);
            _medicalrepo.Update(medicalrecord);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Medical record successfully updates",
                Suceeded = true,
                Data = new MedicalRecordDTO
                {
                    Id = medical.Id,
                    DoctorName = $"{medical.Doctor.FirstName} {medical.Doctor.LastName}",
                    Diagnosis = medical.Diagnosis,
                    Prescription = medical.Prescription,
                    PatientComplain = medical.PatientComplain,
                    DoctorReport = medical.DoctorReport,
                    Refferral = medical.Refferral, 
                    // HospitalId = medical.Hospital.Id,
                    // HospitalName = medical.Hospital.Name
                }
            };
        }

        public BaseResponse<MedicalRecordDTO> GetByPatientId(int patientId)
        {                       
            var pat = _medicalrepo.GetByPatientId(patientId);
            if (pat == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "No record of this patient found",
                    Suceeded = false
                };
            }                      
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Record Successfully found",
                Suceeded = true,
                Data = new MedicalRecordDTO
                {
                    Id = pat.Id,
                    DoctorName = $"{pat.Doctor.FirstName} {pat.Doctor.LastName}",
                    Diagnosis = pat.Diagnosis,
                    Prescription = pat.Prescription,
                    PatientComplain = pat.PatientComplain,
                    DoctorReport = pat.DoctorReport,
                    Refferral = pat.Refferral, 
                    HospitalId = pat.Hospital.Id,
                    HospitalName = pat.Hospital.Name                   
                }
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> AssignedMedicalCases(int DoctorId)
        {
              var docs = _doctorrepo.ExistById(DoctorId);
            if (docs == false)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "The medicalrecord does not exist",
                    Suceeded = false
                };
            } 
            var doctor = _medicalrepo.AssignedMedicalCases(DoctorId);
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "The medicalrecord exist",
                Suceeded = true,
                Data = doctor
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> TreatedMedicalCases(int DoctorId)
        {
             var docs = _doctorrepo.ExistById(DoctorId);
            if (docs == false)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "The medicalrecord does not exist",
                    Suceeded = false
                };
            } 
            var doctor = _medicalrepo.TreatedMedicalCases(DoctorId);
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "The medicalrecord exist",
                Suceeded = true,
                Data = doctor
            }; 
        }

        public BaseResponse<List<MedicalRecordDTO>> AssignedMedicalCases()
        {
            var medical = _medicalrepo.AssignedMedicalCases();
            if ( medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Cases has been Treated yet",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Here are the lists of cases Treated",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<MedicalRecordDTO> AssignPatientToHospital(int MedicalRecordId, AssignHospitalRequestModel request)
        {
            var hospital = _hospitalrepo.Get(request.HospitalId);
            if (hospital == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "Hospital does not exist",
                    Suceeded = false                   
                };
            }
            var medical = _medicalrepo.Get(MedicalRecordId);
            medical.HospitalId = request.HospitalId;
            medical.Hospital = hospital;
            _medicalrepo.Update(medical);
            // _hospitalrepo.Update(hospital);
            // Console.WriteLine($"Service1 {MedicalRecordId}");
            // Console.WriteLine($"Service2 {request.HospitalId}");
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Hospital is successfully assigned to patient",
                Suceeded = true,
                Data = new MedicalRecordDTO
                {
                    Id = medical.Id,
                    PatientName = $"{medical.Patient.FirstName} {medical.Patient.LastName}",                    
                    DoctorName = $" Dr. {medical.Doctor.FirstName} {medical.Doctor.LastName}",
                    Diagnosis = medical.Diagnosis,
                    Prescription = medical.Prescription,
                    PatientComplain = medical.PatientComplain,
                    DoctorReport = medical.DoctorReport,
                    Refferral = medical.Refferral,
                    HospitalId = medical.Hospital.Id,
                    HospitalName = medical.Hospital.Name    
                }
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> AssignedHospital(int HospitalId)
        {
            var hospital = _hospitalrepo.ExistById(HospitalId);
            if (hospital == false)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "The medicalrecord does not exist",
                    Suceeded = false
                };
            } 
            var hospitals = _medicalrepo.AssignedHospital(HospitalId);
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "The medicalrecord exist",
                Suceeded = true,
                Data = hospitals
            };
        }

        public BaseResponse<List<MedicalRecordDTO>> GetAllByPatientId(int patientId)
        {
            var medical = _medicalrepo.GetAllByPatientId(patientId);
            if ( medical == null)
            {
                return new BaseResponse<List<MedicalRecordDTO>>
                {
                    Message = "No Cases has been Treated yet",
                    Suceeded = false
                };
            }
            return new BaseResponse<List<MedicalRecordDTO>>
            {
                Message = "Here are the lists of cases Treated",
                Suceeded = true,
                Data = medical
            };
        }

        public BaseResponse<MedicalRecordDTO> ViewAssignedDoctor(int DoctorId)
        {
            var docs = _medicalrepo.ExistById(DoctorId);
            if (docs == false)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "The Record does not exist",
                    Suceeded = false
                };
            }
            var theDoctor = _doctorMedicalRecordrepo.ViewAssignedDoctor(DoctorId);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "This is the Assigned Doctor",
                Suceeded = true,
                Data = theDoctor
            };
        }

        public BaseResponse<MedicalRecordDTO> ViewAssignedPatient(int PatientId)
        {
            var docs = _patientrepo.ExistById(PatientId);
            if (docs == false)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "The Record does not exist",
                    Suceeded = false
                };
            }
            var thePatient = _doctorMedicalRecordrepo.ViewAssignedPatient(PatientId);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "This is the Assigned Doctor",
                Suceeded = true,
                Data = thePatient
            };
        }

        public BaseResponse<MedicalRecordDTO> GetComplainByPatientId(int PatientId)
        {
            var docs = _patientrepo.Get(PatientId);
            if(docs == null)
            {
                return new BaseResponse<MedicalRecordDTO>
                {
                    Message = "Patient does not exists",
                    Suceeded = false,

                };
            }
            var patients = _medicalrepo.GetComplainByPatientId(PatientId);
            return new BaseResponse<MedicalRecordDTO>
            {
                Message = "Patient exist in our record",
                Suceeded = true,
                Data = patients
            };
        }
    }
}