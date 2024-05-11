using DAL.EF;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PatientRepo : Repo, IRepo<Patient, int>
    {
        public Patient Create(Patient obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Patient> Get()
        {
            var data = db.Patients.ToList();
            return data;
        }

        public Patient Get(int id)
        {
            var data = db.Patients.FirstOrDefault(e => e.PatientID == id);
            return data;
        }

        public Patient Update(Patient obj)
        {
            throw new NotImplementedException();
        }
    }
}
