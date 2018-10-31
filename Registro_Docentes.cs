using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace entregable
{
    public partial class Registro_Docentes : Form
    {
        public Registro_Docentes()
        {
            InitializeComponent();
            cbPais.SelectedIndex = 127;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root";
            conexion.Open();
            string sentencia = "INSERT INTO docente(id_Docente,username_Docente,email_Docente,password_Docente,pais_Docente)VALUES(@1,@2,@3,@4,@5)";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@1", txtNombreUsuario.Text);
            comando.Parameters.AddWithValue("@2", txtNombreDocente.Text);
            comando.Parameters.AddWithValue("@3", txtMail.Text);
            comando.Parameters.AddWithValue("@4", txtPassword.Text);
            comando.Parameters.AddWithValue("@5", cbPais.Text);

            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agrego correctamente");
            foreach (Control text in this.Controls)
            {
                if (text is TextBox)
                {
                    text.Text = "";
                }
            }
        }
    }
}
