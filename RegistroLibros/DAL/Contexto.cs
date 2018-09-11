using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Libros> libro { get; set; }
        public DbSet<Tipos> Tipos { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
