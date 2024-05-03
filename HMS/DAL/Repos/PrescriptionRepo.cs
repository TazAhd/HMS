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
        public void Create(Prescription obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prescription> Get()
        {
            throw new NotImplementedException();
        }

        public Prescription Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Prescription obj)
        {
            throw new NotImplementedException();
        }
    }
}
