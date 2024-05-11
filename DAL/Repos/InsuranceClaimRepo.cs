using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class InsuranceClaimRepo : Repo, IRepo<InsuranceClaim, int>
    {
        public InsuranceClaim Create(InsuranceClaim obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<InsuranceClaim> Get()
        {
            throw new NotImplementedException();
        }

        public InsuranceClaim Get(int id)
        {
            throw new NotImplementedException();
        }

        public InsuranceClaim Update(InsuranceClaim obj)
        {
            throw new NotImplementedException();
        }
    }
}
