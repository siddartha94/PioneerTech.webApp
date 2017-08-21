using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech.Models.models
{
    public class ProjectDetailsModel
    {
        public int Project_ID { get; set; }
        public string Client { get; set; }
        public string Location_tx { get; set; }
        public string Roles_SW { get; set; }
        public int EmployeeID { get; set; }
    }
}
