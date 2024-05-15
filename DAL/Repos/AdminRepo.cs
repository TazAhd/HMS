using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class AdminRepo : Repo, IRepo<Admin, int>
    {
        public Admin Create(Admin obj)
        {
            throw new NotImplementedException();
        }

       

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Admin> Get()
        {
            throw new NotImplementedException();
        }

        public Admin Get(int id)
        {
            throw new NotImplementedException();
        }

        public Admin Update(Admin obj)
        {
            throw new NotImplementedException();
        }
    }
}
