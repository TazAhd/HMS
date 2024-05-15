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
    public class MedicalHistoryService
    {


        public static List<MedicalHistoryDTO> GetAllMedicalHistoryinfoByPatientId(int id)
        {
            var allMedicalHistory = DataFactory.MedicalHistoryData().Get().ToList();
            var data = allMedicalHistory.Where(e => e.PatientID == id);
            var returnList = new List<MedicalHistoryDTO>();
            foreach (var mh in data)
            {
                var returnModel = new MedicalHistoryDTO()
                {
                    HistoryID = mh.HistoryID,
                    PatientID = mh.PatientID,
                    MedicalRecord = mh.MedicalRecord,
                    DateTime = mh.DateTime,          
                };
                returnList.Add(returnModel);
            }
            return returnList;
        }

        public static List<MedicalHistoryDTO> GetAllMedicalHistories()
        {
            var data = DataFactory.MedicalHistoryData().Get();
            var returnList = new List<MedicalHistoryDTO>();
            foreach (var mh in data)
            {
                var returnModel = new MedicalHistoryDTO()
                {
                    HistoryID = mh.HistoryID,
                    PatientID = mh.PatientID,
                    MedicalRecord = mh.MedicalRecord,
                    DateTime = mh.DateTime
                };
                returnList.Add(returnModel);
            }
            return returnList;

        }


        public static MedicalHistoryDTO MedicalHistoryById(int id)
        {
            var data = DataFactory.MedicalHistoryData().Get(id);

            {
                var returnModel = new MedicalHistoryDTO()
                {
                    HistoryID = data.HistoryID,
                    PatientID = data.PatientID,
                    MedicalRecord = data.MedicalRecord,
                    DateTime = data.DateTime
                };
                return returnModel;
            }

        }


        public static MedicalHistoryDTO createMedicalHistory(MedicalHistoryDTO data)
        {
            if (data == null)
            {
                return data;
            }


            var objMedicalHistory = new MedicalHistory();
            objMedicalHistory.HistoryID = data.HistoryID;
            objMedicalHistory.PatientID = data.PatientID;
            objMedicalHistory.MedicalRecord = data.MedicalRecord;
            objMedicalHistory.DateTime = data.DateTime;
         
            var saveMedicalHistory = DataFactory.MedicalHistoryData().Create(objMedicalHistory);

            return data;

        }


        public static MedicalHistoryDTO updateMedicalHistory(MedicalHistoryDTO data)
        {
            if (data == null)
            {
                return data;
            }
            var objMedicalHistory = new MedicalHistory();
            objMedicalHistory.HistoryID = data.HistoryID;
            objMedicalHistory.PatientID = data.PatientID;
            objMedicalHistory.MedicalRecord = data.MedicalRecord;
            objMedicalHistory.DateTime = data.DateTime;
            var updateMedicalHistory = DataFactory.MedicalHistoryData().Update(objMedicalHistory);
            return data;

        }


        public static bool DeleteMedicalHistory(int id)
        {

            if (id == 0)
            {
                return false;
            }
            var deleteMedicalHistory = DataFactory.MedicalHistoryData().Delete(id);
            if (deleteMedicalHistory)
            {
                return true;

            }
            return false;
        }
    }
}
