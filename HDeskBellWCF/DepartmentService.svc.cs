using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HDeskBellWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DepartmentService.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class DepartmentService : IDepartmentService
    {        

        public Department GetDepartment(int id)
        {
            // TODO: retrieve the real product info from DB using EF
            Department department = new Department();
            department.DepartmentId = id;
            department.DName = "fake department name";
            return department;
        }
    }
}
