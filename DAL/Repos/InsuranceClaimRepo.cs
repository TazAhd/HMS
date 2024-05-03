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
        public void Create(InsuranceClaimRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Create(InsuranceClaim obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<InsuranceClaimRepo> Get()
        {
            throw new NotImplementedException();
        }

        public InsuranceClaimRepo Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(InsuranceClaimRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(InsuranceClaim obj)
        {
            throw new NotImplementedException();
        }

        List<InsuranceClaim> IRepo<InsuranceClaim, int>.Get()
        {
            throw new NotImplementedException();
        }

        InsuranceClaim IRepo<InsuranceClaim, int>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
