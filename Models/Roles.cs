using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.Models
{
    public class Roles
    {
        public int RoleID { get; set; }
        public string RoleTitle { get; set; }
        public string RoleDescription { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public ModeRol Mode { get; set; }
    }

    public enum ModeRol
    {
        Create = 1,
        Read,
        Update,
        Delete
    }
}
