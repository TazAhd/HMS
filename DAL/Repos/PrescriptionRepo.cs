using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PrescriptionRepo : Repo, IRepo<Prescription, int>
    {
        public Prescription Create(Prescription obj)
        {
            var objSave = new Prescription();
            if (obj == null)
            {
                return objSave;
            }

            objSave = obj;
            db.Prescriptions.Add(obj);
            db.SaveChanges();
            return objSave;
            
        }

        public bool Delete(int id)
        {
            var deleteObject = db.Prescriptions.FirstOrDefault(e => e.PrescriptionID == id);
            if (deleteObject == null)
            {
                return false;
            }
            db.Prescriptions.Remove(deleteObject);
            db.SaveChanges();
            return true;
        }

        public List<Prescription> Get()
        {
            var data = db.Prescriptions.ToList();
            return data;
        }

        public Prescription Get(int id)
        {
            var data = db.Prescriptions.FirstOrDefault(e => e.PrescriptionID == id);
            return data;
        }

        public Prescription Update(Prescription obj)
        {
            var upDateObject = db.Prescriptions.FirstOrDefault(e => e.PrescriptionID == obj.PrescriptionID);
            if (upDateObject == null)
            {
                return null;
            }

            upDateObject.Medications = obj.Medications;
            upDateObject.Dosage = obj.Dosage;
            upDateObject.Instructions = obj.Instructions;
            upDateObject.DatePrescribed = obj.DatePrescribed;
            upDateObject.PrescriptionFile = obj.PrescriptionFile;
            db.SaveChanges();
            return obj;
        }

    }
}
