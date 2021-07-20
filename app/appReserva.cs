using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class appReserva
    {
        public Enti.entiReserva Traer(int ID_Cliente)
        {
            return Repo.repoReserva.Traer(ID_Cliente);
        }
        public  List<Enti.entiReserva> Traer_reserva(int ID_Cliente)
        {
            return Repo.repoReserva.Traer_reserva(ID_Cliente);
        }
        public Enti.entiReserva Traer(DateTime Fecha_reserva)
        {
            return Repo.repoReserva.Traer(Fecha_reserva);
        }
        public int Agregar(Enti.entiReserva r)
        {
            return Repo.repoReserva.Agregar(r);
        }
        public int Actualizar(Enti.entiReserva r)
        {
            return Repo.repoReserva.Actualizar(r);
        }
        public int Borrar(DateTime FechadeReserva)
        {
            return Repo.repoReserva.Borrar(FechadeReserva);
        }
    }
}
