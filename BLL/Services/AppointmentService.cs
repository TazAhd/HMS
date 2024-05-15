using BLL.DTOs;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AppointmentService
    {
        public static List<AppointmentDTO> GetAllappointments()
        {
            var data = DataFactory.AppoinmentData().Get();
            var returnList = new List<AppointmentDTO>();
            foreach(var app in data)
            {
                var returnModel = new AppointmentDTO()
                {
                    AppointmentID = app.AppointmentID,
                    DoctorID = app.DoctorID,
                    PatientID = app.PatientID,
                    AppointmentDateTime = app.AppointmentDateTime,
                    Status = app.Status
                };
                returnList.Add(returnModel);
            }
            return returnList;
            
        }

        public static AppointmentDTO appointmentById(int id)
        {
            var data = DataFactory.AppoinmentData().Get(id);

            {
                var returnModel = new AppointmentDTO()
                {
                    AppointmentID = data.AppointmentID,
                    DoctorID = data.DoctorID,
                    PatientID = data.PatientID,
                    AppointmentDateTime = data.AppointmentDateTime,
                    Status = data.Status
                };
                return returnModel;
            }

        }


        public static bool DeleteAppoinment(int id)
        {

            if (id == 0)
            {
                return false;
            }
            var deleteAppointment = DataFactory.AppoinmentData().Delete(id);
            if (deleteAppointment)
            {
                return true;

            }
            return false;
        }

    }
}
