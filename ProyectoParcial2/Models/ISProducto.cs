using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial2.Models
{
    interface ISProducto
    {
        IEnumerable<producto> GetAll();
        producto Obtener(int id);
        producto Get(producto item);

        void Remover(int id);
        bool Actualizar(producto item);
    }
}

