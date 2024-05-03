using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ReceptionistRepo : Repo, IRepo<Receptionist, int>
    {
        public void Create(Receptionist obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Receptionist> Get()
        {
            throw new NotImplementedException();
        }

        public Receptionist Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Receptionist obj)
        {
            throw new NotImplementedException();
        }
    }
}
