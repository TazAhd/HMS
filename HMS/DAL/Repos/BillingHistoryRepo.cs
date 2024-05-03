using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BillingHistoryRepo : Repo, IRepo<BillingHistory, int>
    {
        public void Create(BillingHistory obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BillingHistory> Get()
        {
            throw new NotImplementedException();
        }

        public BillingHistory Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(BillingHistory obj)
        {
            throw new NotImplementedException();
        }
    }
}
