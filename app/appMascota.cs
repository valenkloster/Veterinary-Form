using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class appMascota
    {
        public Enti.entiMascota Traer(int ID_Cliente)
        {
            return Repo.repoMascota.Traer(ID_Cliente);
        }
        public List<Enti.entiMascota> Traer_mascota(int ID_Cliente)
        {
            return Repo.repoMascota.Traer_mascota(ID_Cliente);
        }
        public int Agregar(Enti.entiMascota r)
        {
            return Repo.repoMascota.Agregar(r);
        }
        public int Borrar(int ID)
        {
            return Repo.repoMascota.Borrar(ID);
        }
        public int Actualizar(Enti.entiMascota r)
        {
            return Repo.repoMascota.Actualizar(r);
        }
    }
}
