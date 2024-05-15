using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PrescriptionService
    {
        public static List<PrescriptionDTO> GetAllPrescriptioninf()
        {
            var data = DataFactory.PrescriptionData().Get();
            var returnList = new List<PrescriptionDTO>();
            foreach (var doc in data)
            {
                var returnModel = new PrescriptionDTO()
                {
                    PrescriptionID = doc.PrescriptionID,
                    PatientID = doc.PatientID,
                    DoctorID = doc.DoctorID,
                    Medications = doc.Medications,
                    Dosage = doc.Dosage,
                    Instructions = doc.Instructions,
                    DatePrescribed = doc.DatePrescribed,
                    PrescriptionFile = doc.PrescriptionFile
                };
                returnList.Add(returnModel);
            }
            return returnList;
        }

        public static PrescriptionDTO PrescriptionById(int id)
        {
            var data = DataFactory.PrescriptionData().Get(id);

            {
                var returnModel = new PrescriptionDTO()
                {
                    PrescriptionID = data.PrescriptionID,
                    PatientID = data.PatientID,
                    DoctorID = data.DoctorID,
                    Medications = data.Medications,
                    Dosage = data.Dosage,
                    Instructions = data.Instructions,
                    DatePrescribed = data.DatePrescribed,
                    PrescriptionFile = data.PrescriptionFile
                };
                return returnModel;
            }

        }

        public static PrescriptionDTO createPrescription(PrescriptionDTO data)
        {
            if (data == null)
            {
                return data;
            }


            var objPrescription = new Prescription();
            objPrescription.PatientID = data.PatientID;
            objPrescription.DoctorID = data.DoctorID;
            objPrescription.Medications = data.Medications;
            objPrescription.Dosage = data.Dosage;
            objPrescription.Instructions = data.Instructions;
            objPrescription.DatePrescribed = data.DatePrescribed;
            objPrescription.PrescriptionFile = data.PrescriptionFile;
            var savePrescription = DataFactory.PrescriptionData().Create(objPrescription);

            return data;

        }

         
        public static PrescriptionDTO updatePrescription(PrescriptionDTO data)
        {
            if (data == null)
            {
                return data;
            }
            var objPrescription = new Prescription();
            objPrescription.PrescriptionID = data.PrescriptionID;
            objPrescription.PatientID = data.PatientID;
            objPrescription.DoctorID = data.DoctorID;
            objPrescription.Medications = data.Medications;
            objPrescription.Dosage = data.Dosage;
            objPrescription.Instructions = data.Instructions;
            objPrescription.DatePrescribed = data.DatePrescribed;
            objPrescription.PrescriptionFile = data.PrescriptionFile;
            var updatePrescription = DataFactory.PrescriptionData().Update(objPrescription);
            return data;

        }


        public static bool DeletePrescription(int id)
        {

            if (id == 0)
            {
                return false;
            }
            var deletePrescription = DataFactory.PrescriptionData().Delete(id);
            if (deletePrescription)
            {
                return true;

            }
            return false;
        }


        public static List<PrescriptionDTO> GetAllPrescriptioninfoByPatientId(int id)
        {
            var allPrescription = DataFactory.PrescriptionData().Get().ToList();
            var data = allPrescription.Where(e => e.PatientID == id);
            var returnList = new List<PrescriptionDTO>();
            foreach (var doc in data)
            {
                var returnModel = new PrescriptionDTO()
                {
                    PrescriptionID = doc.PrescriptionID,
                    PatientID = doc.PatientID,
                    DoctorID = doc.DoctorID,
                    Medications = doc.Medications,
                    Dosage = doc.Dosage,
                    Instructions = doc.Instructions,
                    DatePrescribed = doc.DatePrescribed,
                    PrescriptionFile = doc.PrescriptionFile
                };
                returnList.Add(returnModel);
            }
            return returnList;
        }
    }
}
