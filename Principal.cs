using miapp_2.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miapp_2
{
    public partial class Principal : Form
    {
        public Principal(usuario usu)
        {
            InitializeComponent();
            lblBienvenida.Text = "Bienvenido " + usu.NombreDeUsuario;
            lblBienvenida.Visible = true;

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaPersona ventana = new AltaPersona();
            ventana.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // esto me permite abrir el form recientemente creado desde otro from
            Usuarios ventana = new Usuarios();
            ventana.Show();
        }
    }
}
