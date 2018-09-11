using RegistroLibros.DAL;
using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros.BLL
{
   public class TiposBLL
    {        
            /// <summary>
            /// Permite Guardar una entidad en la base de datos
            /// </summary>

            public static bool Guardar(Tipos tipo)
            {
                bool paso = false;
                //Creamos una instancia del contexto para poder conectar con la DB
                Contexto db = new Contexto();
                try
                {
                    if (db.Tipos.Add(tipo) != null)
                    {
                        db.SaveChanges();
                        paso = true;
                    }
                    db.Dispose();//Cerramos la conexion
                }
                catch (Exception)
                {
                    throw;
                }
                return paso;
            }

            /// <summary>
            /// Permite Modificar una entidad en la base de datos
            /// </summary>
            public static bool Modificar(Tipos tipo)
            {
                bool paso = false;
                Contexto db = new Contexto();
                try
                {
                    db.Entry(tipo).State = EntityState.Modified;
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
                    Tipos tipo = db.Tipos.Find(id);
                    db.Tipos.Remove(tipo);
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
            /// Permite Buscar una entidad en la base de datos
            /// </summary>
            public static Tipos Buscar(int id)
            {
                Contexto db = new Contexto();
                Tipos tipo = new Tipos();
                try
                {
                    tipo = db.Tipos.Find(id);
                    db.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }

                return tipo;
            }
            /// <summary>
            /// Permite extraer una lista de Tipos de la base de datos
            /// </summary>
            public static List<Tipos> GetList(Expression<Func<Tipos, bool>> expression)
            {
                List<Tipos> Tipos = new List<Tipos>();
                Contexto db = new Contexto();
                try
                {
                    Tipos = db.Tipos.Where(expression).ToList();
                    db.Dispose();
                }
                catch (Exception)
                {
                    throw;
                }
                return Tipos;
            }

        }
    }
