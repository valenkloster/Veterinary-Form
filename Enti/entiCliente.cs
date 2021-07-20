using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti
{
    public class entiCliente
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Email { get; set; }
        public bool Estado { get; set; }
        public String Clave { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_mod { get; set; }
    }
}
