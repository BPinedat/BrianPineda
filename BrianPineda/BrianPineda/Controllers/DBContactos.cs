using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace BrianPineda.Controllers
{
    public class DBContactos
    {
        readonly SQLiteAsyncConnection _conexion;
        // Constructor Vacio
        public DBContactos()
        { }

        // Constructor con parametros
        public DBContactos(String dbpath)
        {
            // Creando una conexion a base de datos sqlite a partir del path de la base de datos
            _conexion = new SQLiteAsyncConnection(dbpath);

            // Crear las tablas correspondientes en la base de datos de sqlite
            _conexion.CreateTableAsync<Moldes.Contactos>().Wait();
        }

        // CRUD - Aplicaciones 
        // Create

        public Task<int > Storecontac(Moldes.Contactos contac)
        {
            if (contac.Id != 0)
            {
                return _conexion.UpdateAsync(contac);
            }
            else
            {
                return _conexion.InsertAsync(contac);
            }
        }
        // Read

        public Task<List<Moldes.Contactos>> listarcontactos()
        {
            return _conexion.Table<Moldes.Contactos>().ToListAsync();
        }

        public Task<Moldes.Contactos> GetContactos(int pid)
        {
            return _conexion.Table<Moldes.Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> deletecontactos(Moldes.Contactos emple)
        {
            return _conexion.DeleteAsync(emple);
        }
    }
}
