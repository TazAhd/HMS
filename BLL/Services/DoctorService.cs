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
            returnModel.UserID = data.UserID;
            returnModel.DoctorID = data.DoctorID;
            returnModel.Name = data.Name;
            returnModel.Specialization = data.Specialization;
            returnModel.ContactInformation = data.ContactInformation;

            return returnModel;

        }

        public static UserDTO createDoctor(UserDTO data)
        {
            if (data == null)
            {
                return data;
            }



            var objToSave = new User();

            objToSave.Username = data.Username;
            objToSave.Password = data.Password;
            objToSave.Role = data.Role;

            var saveUser = DataFactory.UserData().Create(objToSave);
            if(saveUser == null)
            {
                return data;
            }
            var doctorData = data.Doctors.First();
            var objDoctor = new Doctor();
            objDoctor.UserID = saveUser.UserID;
            objDoctor.Name = doctorData.Name;
            objDoctor.Specialization = doctorData.Specialization;
            objDoctor.ContactInformation = doctorData.ContactInformation;
            var saveDoctor = DataFactory.DoctorData().Create(objDoctor);

            return data;



        }

        public static DoctorDTO updateDoctor(DoctorDTO data)
        {
            if (data == null)
            {
                return data;
            }
            var objDoctor = new Doctor();
            objDoctor.DoctorID = data.DoctorID;
            objDoctor.UserID = data.UserID;
            objDoctor.Name = data.Name;
            objDoctor.Specialization = data.Specialization;
            objDoctor.ContactInformation = data.ContactInformation;
            var updateDoctor = DataFactory.DoctorData().Update(objDoctor);
            return data;

        }

        public static bool DeleteDoctor(int id)
        {

            if (id == 0)
            {
                return false;
            }
            var deleteDoctor = DataFactory.DoctorData().Delete(id);
            if(deleteDoctor)
            {
                return true;

            }
            return false;
        }




    }
}
