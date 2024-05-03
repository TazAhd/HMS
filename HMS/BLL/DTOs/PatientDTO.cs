using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PatientDTO
    {
        public PatientDTO()
        {
            this.Appointments = new HashSet<AppointmentDTO>();
            this.BillingHistories = new HashSet<BillingHistoryDTO>();
            this.Complaints = new HashSet<ComplaintDTO>();
            this.InsuranceClaims = new HashSet<InsuranceClaimDTO>();
            this.MedicalHistories = new HashSet<MedicalHistoryDTO>();
            this.Prescriptions = new HashSet<PrescriptionDTO>();
        }

        public int PatientID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public string ContactInformation { get; set; }

        public virtual ICollection<AppointmentDTO> Appointments { get; set; }
        public virtual ICollection<BillingHistoryDTO> BillingHistories { get; set; }
        public virtual ICollection<ComplaintDTO> Complaints { get; set; }
        public virtual ICollection<InsuranceClaimDTO> InsuranceClaims { get; set; }
        public virtual ICollection<MedicalHistoryDTO> MedicalHistories { get; set; }
        public virtual UserDTO User { get; set; }
        public virtual ICollection<PrescriptionDTO> Prescriptions { get; set; }
    }
}
