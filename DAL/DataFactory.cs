using DAL.EF;
using DAL.Interface;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataFactory
    {
        public static IRepo<Admin, int> AdminData()
        {
            return new AdminRepo();
        }
        public static IRepo<Appointment, int> AppoinmentData()
        {
            return new AppointmentRepo();
        }
        public static IRepo<BillingHistory, int> BillingHistoryData()
        {
            return new BillingHistoryRepo();
        }public static IRepo<Complaint, int> ComplaintData()
        {
            return new ComplaintRepo();
        }public static IRepo<Doctor, int> DoctorData()
        {
            return new DoctorRepo();
        }public static IRepo<InsuranceClaim, int> InsuranceClaimData()
        {
            return new InsuranceClaimRepo();
        }public static IRepo<MedicalHistory, int> MedicalHistoryData()
        {
            return new MedicalHistoryRepo();
        }public static IRepo<Notification, int> NotificationData()
        {
            return new NotificationRepo();
        }public static IRepo<Patient, int> PatientData()
        {
            return new PatientRepo();
        }public static IRepo<Prescription, int> PrescriptionData()
        {
            return new PrescriptionRepo();
        }public static IRepo<Receptionist, int> ReceptionistData()
        {
            return new ReceptionistRepo();
        }public static IRepo<User, int> UserData()
        {
            return new UserRepo();
        }
    }
}
