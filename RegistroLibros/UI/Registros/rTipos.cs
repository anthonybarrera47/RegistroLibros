using RegistroLibros.BLL;
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

namespace RegistroLibros.UI.Registros
{
    public partial class rTipos : Form
    {
        public rTipos()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Tipos tipo = new Tipos()
            {
                TipoId = 0,
                Descripcion = descripcionTextBox.Text,
                Cantidad=0
            };

            if (TiposBLL.Guardar(tipo))
                MessageBox.Show("Guardo");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var tipo = TiposBLL.Buscar((int)tipoIdNumericUpDown.Value);
            if (tipo!=null)
            {
                descripcionTextBox.Text = tipo.Descripcion;
                cantidadTextBox.Text = tipo.Cantidad.ToString();
            }
        }
    }
}
