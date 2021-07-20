using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enti
{
    public class entiReserva
    {
        public int ID_Reserva { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Servicio { get; set; }
        public bool Estado { get; set; }
        public String Detalle { get; set; }
        public DateTime Fecha_reserva { get; set; }
        public DateTime Fecha_mod { get; set; }
    }
}
