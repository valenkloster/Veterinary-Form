using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class appCliente
    {
        public Enti.entiCliente Traer(string Email)
        {
            return Repo.repoCliente.Traer(Email);
        }
        public Enti.entiCliente Traer(string Email,string Clave)
        {
            return Repo.repoCliente.Traer(Email,Clave);
        }
        public int Agregar(Enti.entiCliente r)
        {
            return Repo.repoCliente.Agregar(r);
        }
        public int Actualizar(Enti.entiCliente r)
        {
            return Repo.repoCliente.Actualizar(r);
        }
        public int Borrar(int ID)
        {
            return Repo.repoCliente.Borrar(ID);
        }
        public int CambiarClave(Enti.entiCliente c)
        {
            return Repo.repoCliente.CambiarClave(c);
        }
    }
}
