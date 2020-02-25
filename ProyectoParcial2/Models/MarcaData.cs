using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoParcial2.Models
{
    public class MarcaData : ISNarca
    {
        BD_LENG4TA_2DOPARCIALEntities DB = new BD_LENG4TA_2DOPARCIALEntities();
        public bool Actualizar(Marca item)
        {
            Marca tbl = new Marca();
            tbl.Nombre = item.Nombre;
            
            DB.Marcas.Attach(tbl);
            DB.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return true;
        }

        public Marca Get(Marca item)
        {
            throw new NotImplementedException();
        }

        public Marca Get(int id)
        {
            return DB.Marcas.Find((int)id);
        }

        public IEnumerable<Marca> GetAll()
        {
            var record = from d in DB.Marcas select d;
            return record;
        }

        public Marca Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public void Remover(int id)
        {
            Marca tbl = DB.Marcas.First(d => d.mar_id == (int)id);
            DB.Marcas.Remove(tbl);
            DB.SaveChanges();
        }
        public Marca Agregar(Marca item)
        {
            if (item == null)
            {
                throw new NotFiniteNumberException();

            }
            else
            {
                Marca tbl = new Marca();
                tbl.Nombre = item.Nombre;
                DB.Marcas.Add(tbl);
                DB.SaveChanges();
                return tbl;
            }
        }
    }
}