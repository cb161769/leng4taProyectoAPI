using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProyectoParcial2.Models;

namespace ProyectoParcial2.Controllers
{
    public class MarcAPIController : ApiController
    {
        static readonly MarcaData marcaData = new MarcaData();
        public IEnumerable<Marca> Get()
        {
            return marcaData.GetAll();
        }
        public Marca GetID(int id)
        {
            return marcaData.Get(id);
        }
        public Marca Agregar(Marca item)
        {
            return marcaData.Agregar(item);
        }
        public void Eliminar(int id)
        {
            marcaData.Remover(id);
        }
        public bool Actualizar(Marca item)
        {
            return marcaData.Actualizar(item);

        }
    }
}
