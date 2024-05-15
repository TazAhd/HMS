using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class UserRepo : Repo, IRepo<User, int>
    {
        public User Create(User obj)
        {
            var objSave = new User();
            if (obj == null)
            {
                return objSave;
            }

            objSave = obj;
            db.Users.Add(obj);
            db.SaveChanges();
            return objSave;
        }

        

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            var data = db.Users.ToList();
            return data;
        }

        public User Get(int id)
        {
            var data = db.Users.FirstOrDefault(e => e.UserID == id);
            return data;
        }

        public User Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
