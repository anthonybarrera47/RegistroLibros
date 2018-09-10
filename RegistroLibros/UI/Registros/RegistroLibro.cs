using RegistroLibros.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroLibros.BLL;

namespace RegistroLibros.UI.Registros
{
    public partial class RegistroLibro : Form
    {
        public RegistroLibro()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDNumericoUpDowm.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            SiglasTextBox.Text = string.Empty;
            TipoIdNumericUpDowm.Value = 0;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Libros LLenaLibro()
        {
            Libros libro = new Libros();
            libro.LibroId = Convert.ToInt32(IDNumericoUpDowm.Value);
            libro.Descripcion = DescripcionTextBox.Text;
            libro.Siglas = SiglasTextBox.Text;
            libro.TipoId = Convert.ToInt32(TipoIdNumericUpDowm.Value);
            return libro;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Libros libro;
            bool paso = false;

            libro = LLenaLibro();
            if (!GuardarValidad())
                return;
            if (IDNumericoUpDowm.Value == 0)
                paso = LibrosBLL.Guardar(libro);
            else
            {
                if(!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modificar un libro no existente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = LibrosBLL.Modificar(libro);

                Limpiar();

                if (paso)
                    MessageBox.Show("Guardado!!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se Guardo el libro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool GuardarValidad()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(DescripcionTextBox.Text) || string.IsNullOrWhiteSpace(SiglasTextBox.Text) || TipoIdNumericUpDowm.Value == 0)
            {
                if(string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
                {
                    MessageBox.Show("El Campo Descripcion no puede estar vacio");
                }
                if(string.IsNullOrWhiteSpace(SiglasTextBox.Text))
                {
                    MessageBox.Show("El Campo Siglas no puede estar vacio");
                }
                if(TipoIdNumericUpDowm.Value == 0)
                {
                    MessageBox.Show("El campo TipoID no puede ser 0");
                }
                paso = false;
            }
            return paso;
        }
       
        private void LlenaCampos(Libros libro)
        {
            IDNumericoUpDowm.Value = libro.LibroId;
            DescripcionTextBox.Text = libro.Descripcion;
            SiglasTextBox.Text = libro.Siglas;
            TipoIdNumericUpDowm.Value = libro.TipoId;

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            int id;
            Libros libro = new Libros();
            int.TryParse(IDNumericoUpDowm.Text, out id);
            libro = LibrosBLL.Buscar(id);

            if (libro != null)
            {
                MessageBox.Show("Libro Encontrada", "Exito",MessageBoxButtons.OK);
                LlenaCampos(libro);
            }
            else
            {
                MessageBox.Show("Libro no encontrado","Fallo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDNumericoUpDowm.Text, out id);
            if (!EliminarValidar())
                return;
            if (LibrosBLL.Eliminar(id))
                MessageBox.Show("Libro Eliminado", "Exito", MessageBoxButtons.OK);
            else
                MessageBox.Show("No se pudo eliminar el libro", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool EliminarValidar()
        {
            bool paso = true;

            if (DescripcionTextBox.Text == string.Empty || SiglasTextBox.Text == string.Empty || TipoIdNumericUpDowm.Value == 0)
            {
                if (DescripcionTextBox.Text == string.Empty)
                {
                    MessageBox.Show("El Campo Descripcion no puede estar vacio");
                }
                if (SiglasTextBox.Text == string.Empty)
                {
                    MessageBox.Show("El Campo Siglas no puede estar vacio");
                }
                if (TipoIdNumericUpDowm.Value == 0)
                {
                    MessageBox.Show("El campo TipoID no puede ser 0");
                }
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Libros libros = LibrosBLL.Buscar((int)IDNumericoUpDowm.Value);
            return (libros != null);
        }

    }
}
