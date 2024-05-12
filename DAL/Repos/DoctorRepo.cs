using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DoctorRepo : Repo, IRepo<Doctor, int>
    {
        public Doctor Create(Doctor obj)
        {
            var objSave = new Doctor();
            if(obj == null)
            {
                return objSave;
            }

            objSave = obj;
            db.Doctors.Add(obj);
            db.SaveChanges();
            return objSave;
        }

        public bool Delete(int id)
        {
            var delteObject = db.Doctors.FirstOrDefault(e => e.DoctorID == id);
            if(delteObject == null)
            {
                return false;
            }

            db.Doctors.Remove(delteObject);
            db.SaveChanges();
            return true;
        }

        public List<Doctor> Get()
        {
            var data = db.Doctors.ToList();
            return data;
        }

        public Doctor Get(int id)
        {
            var data = db.Doctors.FirstOrDefault(e => e.DoctorID == id);
            return data;
        }

        public Doctor Update(Doctor obj)
        {
            var upDateObject = db.Doctors.FirstOrDefault(e => e.DoctorID == obj.DoctorID);
            if (upDateObject == null)
            {
                return null;
            }

            upDateObject.Name = obj.Name;
            upDateObject.Specialization = obj.Specialization;
            upDateObject.ContactInformation = obj.ContactInformation;
            db.SaveChanges();
            return obj;

        }
    }
}
