using ProyectoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoParcial2.Controllers
{
    public class TipoAPIController : ApiController
    {
        static readonly TipProdData tipoData = new TipProdData();
        public IEnumerable<tipo> Get()
        {
            return tipoData.GetAll();
        }
        public tipo GetID(int id)
        {
            return tipoData.Get(id);
        }
        public tipo Agregar(tipo item)
        {
            return tipoData.Agregar(item);
        }
        public void Eliminar(int id)
        {
            tipoData.Remover(id);
        }
        public bool Actualizar(tipo item)
        {
            return tipoData.Actualizar(item);

        }
    }
}
