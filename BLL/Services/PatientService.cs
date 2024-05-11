using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PatientService
    {
        public static List<PatientDTO> GetAllpatients()
        {
            var data = DataFactory.PatientData().Get();
            var resultList = new List<PatientDTO>();
            foreach (var pat in data)
            {
                var returnModel = new PatientDTO()
                {
                    PatientID = pat.PatientID,
                    Name = pat.Name,
                    Age = pat.Age,
                    Gender = pat.Gender,
                    ContactInformation = pat.ContactInformation,
                };
                resultList.Add(returnModel);
            }
            return resultList;
        }

        public static PatientDTO patientById(int id)
        {
            var data = DataFactory.PatientData().Get(id);

            {
                var returnModel = new PatientDTO()
                {
                    PatientID = data.PatientID,
                    Name = data.Name,
                    Age = data.Age,
                    Gender = data.Gender,
                    ContactInformation = data.ContactInformation,
                };
                return returnModel;
            }

        }
    }
}
    