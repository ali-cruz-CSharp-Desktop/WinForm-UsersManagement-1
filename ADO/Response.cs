using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.ADO
{
    public class Response
    {
        public string Status { get; set; }
        public bool Exito { get; set; }
        public string Message { get; set; }
        public dynamic Result { get; set; }

        public Response()
        {
            this.Status = "success";
        }

    }
}
