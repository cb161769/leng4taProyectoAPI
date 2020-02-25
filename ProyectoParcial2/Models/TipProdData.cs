using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoParcial2.Models
{
    public class TipProdData : ISTipoProducto
    {
        BD_LENG4TA_2DOPARCIALEntities DB = new BD_LENG4TA_2DOPARCIALEntities();
        public bool Actualizar(tipo item)
        {
            tipo tbl = new tipo();
            tbl.nombre = item.nombre;

            DB.Entry(DB).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return true;
        }

        public producto Get(producto item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tipo> GetAll()
        {
            var record = from d in DB.tipoes select d;
            return record;
        }

        public tipo Get(int id)
        {
            return DB.tipoes.Find((int)id);
        }

        public void Remover(int id)
        {

            tipo tbl = DB.tipoes.First(d => d.tipoPRod_id == (int)id);
            DB.tipoes.Remove(tbl);
            DB.SaveChanges();
        }

        public tipo Obtener(int id)
        {
            throw new NotImplementedException();
        }
        public tipo Agregar(tipo item)
        {
            if (item == null)
            {
                throw new NotFiniteNumberException();

            }
            else
            {
                tipo tbl = new tipo();
                tbl.nombre = item.nombre;

                DB.tipoes.Add(tbl);
                DB.SaveChanges();
                return tbl;

            }
        }

        public tipo Get(tipo item)
        {
            throw new NotImplementedException();
        }
    }
}