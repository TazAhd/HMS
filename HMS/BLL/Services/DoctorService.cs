using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorService
    {
        public static List<DoctorDTO> GetAlldoctors()
        {
            var data = DataFactory.DoctorData().Get();
            var returnList = new List<DoctorDTO>();
            foreach(var doc in data)
            {
                var returnModel = new DoctorDTO()
                {
                    DoctorID = doc.DoctorID,
                    Name = doc.Name,
                    Specialization = doc.Specialization,
                    ContactInformation = doc.ContactInformation
                };
                returnList.Add(returnModel);
            }
            return returnList;
        }

        public static DoctorDTO doctorById(int id)
        {
            var data = DataFactory.DoctorData().Get(id);
            var returnModel = new DoctorDTO();
            if (data == null)
            {
                return returnModel;
            }
            returnModel.DoctorID = data.DoctorID;
            returnModel.Name = data.Name;
            returnModel.Specialization = data.Specialization;
            returnModel.ContactInformation = data.ContactInformation;

            return returnModel;

        }


    }
}
