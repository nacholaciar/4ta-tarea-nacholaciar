using miapp_2.entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            //validar para ejecutar/mostrar la ventana princial.cs
            if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                // user y pass son correctos
                // MessageBox.Show("Datos correctos");
                // Principal ventana = new Principal(usu);
                // ventana.Show();
                // this.Hide();
                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                // user y pass son incorrectos
                // MessageBox.Show("Datos incorrectos");
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                resultado = ValidarUsuario(nombreDeUsuario, password);

                if (resultado == true)
                {
                    usuario usu = new usuario(nombreDeUsuario, password);
                    Principal ventana = new Principal(usu);
                    ventana.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario inexistente");
                }


            }

        }

        

        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            bool resultado = false;

            // conectar con la base de datos
            string cadenConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlCommand cmd = new SqlCommand();
            SqlConnection cn = new SqlConnection(cadenConexion);

            string consulta = "SELECT * FROM usuarios WHERE NombreDeUsuario like '"+nombreDeUsuario+"'AND Password like'"+password+"'";

            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = consulta;

            cn.Open();
            cmd.Connection = cn;
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            if(tabla.Rows.Count == 1)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;

        }
    }
}
