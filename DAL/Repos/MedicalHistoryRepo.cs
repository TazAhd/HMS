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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}
