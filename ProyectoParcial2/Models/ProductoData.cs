using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoParcial2.Models
{
    public class ProductoData : ISProducto
         
    {
        BD_LENG4TA_2DOPARCIALEntities DB = new BD_LENG4TA_2DOPARCIALEntities();

        public bool Actualizar(producto item)
        {
            producto tbl = new producto();
            tbl.nombre = item.nombre;
            tbl.Marca = item.Marca;
            tbl.precio = item.precio;
            tbl.tipo = item.tipo;
            DB.Entry(DB).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return true;
        }

        public producto Get(producto item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<producto> GetAll()
        {
            var record = from d in DB.productoes select d;
            return record;
        }

        public producto Get(int id)
        {
            return DB.productoes.Find((int)id);
        }

        public void Remover(int id)
        {

            producto tbl = DB.productoes.First(d => d.prod_id == (int)id);
            DB.productoes.Remove(tbl);
            DB.SaveChanges();
        }

        public producto Obtener(int id)
        {
            throw new NotImplementedException();
        }
        public producto Agregar(producto item)
        {
            if (item == null)
            {
                throw new NotFiniteNumberException();

            }
            else
            {
                producto tbl = new producto();
                tbl.nombre = item.nombre;
                tbl.Marca = item.Marca;
                tbl.precio = item.precio;
                tbl.tipo = item.tipo;
                DB.productoes.Add(tbl);
                DB.SaveChanges();
                return tbl;

            }
        }
    }
}