using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroLibros.Entidades
{
    public class Tipos
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }

        public int Cantidad { get; set; }

    }
}
