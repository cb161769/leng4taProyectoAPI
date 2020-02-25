using ProyectoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace ProyectoParcial2.Controllers
{
    public class ClienteAPIController : ApiController
    {
        static readonly ClienteData clienteData = new ClienteData();
        public IEnumerable<CLiente> Get()
        {
            return clienteData.GetAll();
        }
        public CLiente GetID(int id)
        {
            return clienteData.Get(id);
        }
        public CLiente Agregar( CLiente item)
        {
            return clienteData.Agregar(item);
        }
        public void Eliminar(int id)
        {
            clienteData.Remover(id);
        }
        public bool Actualizar(CLiente item)
        {
            return clienteData.Actualizar(item);

        }
    }
}
