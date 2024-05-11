using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NotificationRepo : Repo, IRepo<Notification, int>
    {
        public Notification Create(Notification obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> Get()
        {
            throw new NotImplementedException();
        }

        public Notification Get(int id)
        {
            throw new NotImplementedException();
        }

        public Notification Update(Notification obj)
        {
            throw new NotImplementedException();
        }
    }
}
