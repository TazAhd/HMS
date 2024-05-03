//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Doctor
    {
        public Doctor()
        {
            this.Appointments = new HashSet<Appointment>();
            this.Prescriptions = new HashSet<Prescription>();
        }
    
        public int DoctorID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ContactInformation { get; set; }
    
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Prescription> Prescriptions { get; set; }
    }
}
