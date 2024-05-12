using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class DoctorDTO
    {
        public int DoctorID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ContactInformation { get; set; }

        public virtual ICollection<AppointmentDTO> Appointments { get; set; }
        [JsonIgnore]
        public virtual UserDTO User { get; set; }
        public virtual ICollection<PrescriptionDTO> Prescriptions { get; set; }
    }
}
