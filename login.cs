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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario usu = new usuario(txtUsuario.Text, txtContraseña.Text);
            //MessageBox.Show("Hola" + usu.NombreDeUsuario + " " + usu.Passw);


            string usuCorrecto = "ignacio";
            string passwordCorrecto = "1234";

            //validar para ejecutar/mostrar la ventana princial.cs
            if (txtUsuario.Text.Equals(usuCorrecto) && txtContraseña.Text.Equals(passwordCorrecto))
            {
                // user y pass son correctos
                MessageBox.Show("Datos correctos");
                Principal ventana = new Principal(usu);
                ventana.Show();
                this.Hide();
            }
            else
            {
                // user y pass son incorrectos
                MessageBox.Show("Datos incorrectos");
            }
        }
    }
}
