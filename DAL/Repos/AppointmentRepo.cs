using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AppointmentRepo : Repo, IRepo<Appointment, int>
    {
        public Appointment Create(Appointment obj)
        {
            var objSave = new Appointment();
            if(obj == null)
            {
                return objSave;
            }

            objSave = obj;
            db.Appointments.Add(obj);
            db.SaveChanges();
            return objSave;
        }


        public bool Delete(int id)
        {
            var deleteObject = db.Appointments.FirstOrDefault(e => e.AppointmentID == id);
            if(deleteObject == null)
            {
                return false;
            }
            db.Appointments.Remove(deleteObject);
            db.SaveChanges();
            return true;
        }

        public List<Appointment> Get()
        {
            var data = db.Appointments.ToList();
            return data;
        }

        public Appointment Get(int id)
        {
            var data = db.Appointments.FirstOrDefault(e => e.AppointmentID == id);
            return data;
        }

        public Appointment Update(Appointment obj)
        {
            var updateObject = db.Appointments.FirstOrDefault(e => e.AppointmentID == obj.AppointmentID);
            if(updateObject == null)
            {
                return updateObject = new Appointment();
            }

            updateObject = obj;
            db.SaveChanges();
            return updateObject;
        }
    }
}
