using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MedicalHistoryDTO
    {
        public int HistoryID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public string MedicalRecord { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }

        public virtual PatientDTO Patient { get; set; }
    }
}
