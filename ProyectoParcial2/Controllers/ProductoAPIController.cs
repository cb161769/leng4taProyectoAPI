using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Controllers
{
    public class ProductoAPIController : ApiController
    {
        static readonly ProductoData productoData = new ProductoData();
        public IEnumerable<producto> Get()
        {
            return productoData.GetAll();
        }
        public producto GetID(int id)
        {
            return productoData.Get(id);
        }
        public producto Agregar(producto item)
        {
            return productoData.Agregar(item);
        }
        public void Eliminar(int id)
        {
            productoData.Remover(id);
        }
        public bool Actualizar(producto item)
        {
            return productoData.Actualizar(item);

        }
    }
}
