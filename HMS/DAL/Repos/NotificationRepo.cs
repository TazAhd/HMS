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
        public void Create(NotificationRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Create(Notification obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<NotificationRepo> Get()
        {
            throw new NotImplementedException();
        }

        public NotificationRepo Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(NotificationRepo obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Notification obj)
        {
            throw new NotImplementedException();
        }

        List<Notification> IRepo<Notification, int>.Get()
        {
            throw new NotImplementedException();
        }

        Notification IRepo<Notification, int>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
