using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoParcial2.Models
{
    public class ClienteData : ISClienteData
    {
        BD_LENG4TA_2DOPARCIALEntities DB = new BD_LENG4TA_2DOPARCIALEntities();
        public bool Actualizar(CLiente item)
        {
            CLiente tbl = new CLiente();
            tbl.Nombre = item.Nombre;
            tbl.Apellido = item.Apellido;
            tbl.Cedula = item.Cedula;
            DB.CLientes.Attach(tbl);
            DB.Entry(tbl).State = System.Data.Entity.EntityState.Modified;
            DB.SaveChanges();
            return true;
        }

        public CLiente Agregar(CLiente item)
        {

            if (item == null)
            {
                throw new NotFiniteNumberException();

            }
            else
            {
                CLiente tbl = new CLiente();
                tbl.Nombre = item.Nombre;
                tbl.Apellido = item.Apellido;
                tbl.Cedula = item.Cedula;
                DB.CLientes.Add(tbl);
                DB.SaveChanges();
                return tbl;

            }
            
        }

        public IEnumerable<CLiente> GetAll()
        {
            var record = from d in DB.CLientes select d;
            return record;
        }

        public CLiente Get(int id)
        {
            return DB.CLientes.Find((int)id);
        }

        public void Remover(int id)
        {
            CLiente tbl = DB.CLientes.First(d => d.cli_ID == (int)id);
            DB.CLientes.Remove(tbl);
            DB.SaveChanges();
             
        }

        public CLiente Obtener(int id)
        {
            throw new NotImplementedException();
        }

        public CLiente Get(CLiente item)
        {
            throw new NotImplementedException();
        }
    }
}