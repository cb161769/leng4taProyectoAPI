using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial2.Models
{
    interface ISNarca
    {

        IEnumerable<Marca> GetAll();
        Marca Obtener(int id);
        Marca Get(int id);

        void Remover(int id);
        bool Actualizar(Marca item);
    }
}
