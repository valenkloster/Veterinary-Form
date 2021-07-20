using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class appServicios
    {
        public List<Enti.entiServicio> Traer()
        {
            return Repo.repoServicio.Traer();
        }
        public Enti.entiServicio Traer(int ID)
        {
            return Repo.repoServicio.Traer(ID);
        }
    }
}
