using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ReceptionistDTO
    {
        public int ReceptionistID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        public virtual UserDTO User { get; set; }
    }
}
