using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial2.Models
{
    interface ISTipoProducto
    {
        IEnumerable<tipo> GetAll();
        tipo Obtener(int id);
        tipo Get(tipo item);

        void Remover(int id);
        bool Actualizar(tipo item);
    }
}
