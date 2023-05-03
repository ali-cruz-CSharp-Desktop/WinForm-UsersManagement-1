using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.Models
{
    public class Users
    {
        public string UserName { get; set; }

        public string OldPassword { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public ModeUser Mode { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public enum ModeUser
        {
            Create = 1,
            Read,
            Update,
            Delete
        }
    }
}
