using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {

            public UserDTO()
            {
                this.Admins = new HashSet<AdminDTO>();
                this.Doctors = new HashSet<DoctorDTO>();
                this.Notifications = new HashSet<NotificationDTO>();
                this.Patients = new HashSet<PatientDTO>();
                this.Receptionists = new HashSet<ReceptionistDTO>();
            }

            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }

            public virtual ICollection<AdminDTO> Admins { get; set; }
            public virtual ICollection<DoctorDTO> Doctors { get; set; }
            public virtual ICollection<NotificationDTO> Notifications { get; set; }
            public virtual ICollection<PatientDTO> Patients { get; set; }
            public virtual ICollection<ReceptionistDTO> Receptionists { get; set; }
        
    }
}
