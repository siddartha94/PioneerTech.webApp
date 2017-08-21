using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech.Models.models
{
    public class EmployeeDetailsModel
    {

        public int EmployeeID { get; set; }
        public string Employee_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public long Mobile_Number { get; set; }
        public string Address { get; set; }
        public string Current_Country { get; set; }
        public string Home_Country { get; set; }
        public int ZipCode { get; set; }
    }
}
