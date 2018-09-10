using RegistroLibros.DAL;
using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace RegistroLibros.BLL
{
    /// <summary>
    /// En esta clase debemos programar toda la logica de negocios
    /// </summary>
    public class LibrosBLL
    {
        /// <summary>
        /// Permite Guardar una entidad en la base de datos
        /// </summary>

        public static bool Guardar(Libros libro)
        {
            bool paso = false;
            //Creamos una instancia del contexto para poder conectar con la DB
            Contexto db = new Contexto();
            try
            {
                if(db.libro.Add(libro)!=null)
                {
                    db.SaveChanges();
                    paso = true;
                }
                db.Dispose();//Cerramos la conexion
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }

        /// <summary>
        /// Permite Modificar una entidad en la base de datos
        /// </summary>
        public static bool Modificar(Libros libro)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                db.Entry(libro).State = EntityState.Modified;
                if (db.SaveChanges() > 0)
                {
                    paso = true;
                }
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// Permite Eliminar una entidad en la base de datos
        /// </summary>
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                Libros libro = db.libro.Find(id);
                db.libro.Remove(libro);
                if(db.SaveChanges()>0)
                {
                    paso = true;
                }
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return paso;
        }
        /// <summary>
        /// Permite Buscar una entidad en la base de datos
        /// </summary>
        public static Libros Buscar(int id)
        {
            Contexto db = new Contexto();
            Libros libro = new Libros();
            try
            {
                libro = db.libro.Find(id);
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }

            return libro;
        }
        /// <summary>
        /// Permite extraer una lista de libros de la base de datos
        /// </summary>
        public static List<Libros> GetList(Expression<Func<Libros, bool>> expression)
        {
            List<Libros> libros = new List<Libros>();
            Contexto db = new Contexto();
            try
            {
                libros = db.libro.Where(expression).ToList();
                db.Dispose();
            }catch(Exception)
            {
                throw;
            }
            return libros; 
        }
    }
}
