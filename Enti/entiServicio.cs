using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti
{
    public class entiServicio
    {
        public int ID { get; set; }
        public String Nombre { get; set; }
        public bool Estado { get; set; }
        public float Precio { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha_ingreso { get; set; }
        public DateTime Fecha_mod { get; set; }
    }
}
