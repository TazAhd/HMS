using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class AppointmentDTO
    {
        public int AppointmentID { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<System.DateTime> AppointmentDateTime { get; set; }
        public string Status { get; set; }

        public virtual DoctorDTO Doctor { get; set; }
        public virtual PatientDTO Patient { get; set; }
    }
}
