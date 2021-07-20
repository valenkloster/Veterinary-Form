using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti
{
    public class entiMascota
    {
        public int ID_Mascota { get; set; }
        public int ID_Cliente { get; set; }
        public String Nombre { get; set; }
        public bool Estado { get; set; }
        public String TipoAnimal { get; set; }
        public String Raza { get; set; }
        public String Detalle { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_mod { get; set; }
    }
}
