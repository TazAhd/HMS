using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PrescriptionDTO
    {
        public int PrescriptionID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public string Medications { get; set; }
        public string Dosage { get; set; }
        public string Instructions { get; set; }
        public Nullable<System.DateTime> DatePrescribed { get; set; }
        public string PrescriptionFile { get; set; }

        public virtual DoctorDTO Doctor { get; set; }
        public virtual PatientDTO Patient { get; set; }
    }
}
