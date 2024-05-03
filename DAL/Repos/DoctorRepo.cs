using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class DoctorRepo : Repo, IRepo<Doctor, int>
    {
        public void Create(Doctor obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Doctor> Get()
        {
            var data = db.Doctors.ToList();
            return data;
        }

        public Doctor Get(int id)
        {
            var data = db.Doctors.FirstOrDefault(e => e.DoctorID == id);
            return data;
        }

        public void Update(Doctor obj)
        {
            throw new NotImplementedException();
        }
    }
}
