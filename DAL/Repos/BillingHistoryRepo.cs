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
        public BillingHistory Create(BillingHistory obj)
        {
            throw new NotImplementedException();
        }

       
        public bool Delete(int id)
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

        public BillingHistory Update(BillingHistory obj)
        {
            throw new NotImplementedException();
        }
    }
}
