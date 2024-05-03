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
        public void Create(MedicalHistoryRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Create(MedicalHistory obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MedicalHistoryRepo> Get()
        {
            throw new NotImplementedException();
        }

        public MedicalHistoryRepo Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(MedicalHistoryRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(MedicalHistory obj)
        {
            throw new NotImplementedException();
        }

        List<MedicalHistory> IRepo<MedicalHistory, int>.Get()
        {
            throw new NotImplementedException();
        }

        MedicalHistory IRepo<MedicalHistory, int>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
