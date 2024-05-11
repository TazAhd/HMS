using BLL.DTOs;
using DAL;
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
    }
}
