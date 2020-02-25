using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoParcial2.Models
{
    interface ISClienteData
    {
         IEnumerable<CLiente> GetAll();
        CLiente Get(int id);

        CLiente Get(CLiente item);


        void Remover(int id);
        bool Actualizar(CLiente item);
    }
}
