using RegistroLibros.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroLibros
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

       
        private void RegistroItem_Click(object sender, EventArgs e)
        {
            RegistroLibro rl = new RegistroLibro();
            rl.ShowDialog();
        }
    }
}
