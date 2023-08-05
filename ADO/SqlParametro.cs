using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersManagement.ADO
{
    public sealed class SqlParametro    {
        public string Nombre { get; set; }
        public object Valor { get;set; }
        public bool Salida { get; set; }

        public SqlParametro(string nombre, object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;
            this.Salida = false;
        }

        public SqlParametro(string nombre)
        {
            this.Nombre = nombre;
            this.Salida = true;
        }


    }
}
