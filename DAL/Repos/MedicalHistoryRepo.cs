using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class MedicalHistoryRepo : Repo, IRepo<MedicalHistory, int>
    {
        public MedicalHistory Create(MedicalHistory obj)
        {
            var objSave = new MedicalHistory();
            if (obj == null)
            {
                return objSave;
            }

            objSave = obj;
            db.MedicalHistories.Add(obj);
            db.SaveChanges();
            return objSave;
        }


        public bool Delete(int id)
        {
            var deleteObject = db.MedicalHistories.FirstOrDefault(e => e.HistoryID == id);
            if (deleteObject == null)
            {
                return false;
            }
            db.MedicalHistories.Remove(deleteObject);
            db.SaveChanges();
            return true;
        }

        public List<MedicalHistory> Get()
        {
            var data = db.MedicalHistories.ToList();
            return data;
        }

        public MedicalHistory Get(int id)
        {
            var data = db.MedicalHistories.FirstOrDefault(e => e.HistoryID == id);
            return data;
        }

        public MedicalHistory Update(MedicalHistory obj)
        {
            var upDateObject = db.MedicalHistories.FirstOrDefault(e => e.HistoryID == obj.HistoryID);
            if (upDateObject == null)
            {
                return null;
            }

            upDateObject.MedicalRecord = obj.MedicalRecord;
            upDateObject.DateTime = obj.DateTime;
            
            db.SaveChanges();
            return obj;
        }
    }
}
