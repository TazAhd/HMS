using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class ComplaintRepo : Repo, IRepo<Complaint, int>
    {
        public Complaint Create(Complaint obj)
        {
            throw new NotImplementedException();
        }

       

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Complaint> Get()
        {
            throw new NotImplementedException();
        }

        public Complaint Get(int id)
        {
            throw new NotImplementedException();
        }

        public Complaint Update(Complaint obj)
        {
            throw new NotImplementedException();
        }
    }
}
