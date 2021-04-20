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

                MessageBox.Show("Ingrese nombre de usuario y password");
            }
            else
            {
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                try
                {
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
                catch (Exception ex)
                {

                    MessageBox.Show("Error al consultar usuario"+ex.Message);
                }


            }

        }

        

        private bool ValidarUsuario(string nombreDeUsuario, string password)
        {
            string cadenConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenConexion);

            try
            {
                bool resultado = false;

                // conectar con la base de datos
                SqlCommand cmd = new SqlCommand();

                // string consulta = "SELECT * FROM usuarios WHERE NombreDeUsuario like '" + nombreDeUsuario + "'AND Password like'" + password + "'";
                string consulta = "SELECT * FROM usuarios WHERE NombreDeUsuario like @nombreUsu AND Password like @pass";

                cmd.Parameters.Clear(); // limpiar todos los parametros del objeto cmd
                cmd.Parameters.AddWithValue("@nombreUsu", nombreDeUsuario);
                cmd.Parameters.AddWithValue("@pass", password);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
                return resultado;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                // cierre de conexion de la bd
                cn.Close();
            }

        }
    }
}
