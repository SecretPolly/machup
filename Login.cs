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


using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.IO;
using System.Net;
using System.Collections.Specialized;


namespace entregable
{
    
    public partial class Login : Form
    {
        private HttpAuthorization Authorization = null;

        private string CurrentPath = "";

        private long UploadingFileLength = 0;

        private Stream DownloadReader = null;
        private FileStream DownloadFileStream = null;
        private BinaryWriter DownloadWriter = null;
        private byte[] DownloadReadBuffer = new byte[4096];

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(0, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
            }
            else
            {
                // create authorization header
                this.Authorization = new HttpAuthorization(AuthorizationType.Bearer, Properties.Settings.Default.AccessToken);

                // get files
                //this.GetFiles();
            }
        }

        /*private void GetFiles()
        {
            throw new NotImplementedException();
        }*/

        private void GetAccessToken()
        {
            var login = new DropboxLogin("bayrht5hltabnbb", "q6xl6zyr9s61huh", "https://oauthproxy.nemiro.net/", false, false);
            login.Owner = this;
            login.ShowDialog();

            if (login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessTokenValue;
                Properties.Settings.Default.Save();

                this.Authorization = new HttpAuthorization(AuthorizationType.Bearer, login.AccessTokenValue);

                //this.GetFiles();
            }
            else
            {
                MessageBox.Show("error...");
            }
        }

        public int xClick = 0, yClick = 0;
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Size = new Size(698, 700);
                panel1.Visible = false;
                panel1.Left = 698;
                panel2.Visible = false;
                panel2.Left = 35;
                panel2.Visible = true;
                panel2.Refresh();
            
                bunifuSeparator1.Visible = false;
                bunifuSeparator2.Visible = true;
                rbMestros.Checked = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Size = new Size(698, 578);
                panel2.Visible = false;
                panel2.Left = 698;
                panel3.Visible = false;
                panel1.Visible = false;
                panel1.Left = 35;
                panel1.Visible = true;
                panel1.Refresh();
                bunifuSeparator2.Visible = false;
                bunifuSeparator1.Visible = true;
        }

        private void rbAlumnos_CheckedChanged(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            this.Size = new Size(698, 720);
            panel2.Visible = false;
            panel2.Left = 720;
            panel3.Visible = false;
            panel3.Left = 35;
            panel3.Visible = true;
            panel3.Refresh();
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
            }
        }
       
        private void btnaceptarrm_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root";
            conexion.Open();
            string sentencia = "INSERT INTO docente(id_Docente,username_Docente,email_Docente,password_Docente,pais_Docente)VALUES(@1,@2,@3,@4,@5)";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@1", txtidrm.Text);
            comando.Parameters.AddWithValue("@2", txtnombrerm.Text);
            comando.Parameters.AddWithValue("@3", txtmailrm.Text);
            comando.Parameters.AddWithValue("@4", txtcontrarm.Text);
            comando.Parameters.AddWithValue("@5", cbpaisrm.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agrego correctamente");
            txtidrm.Text = "";
            txtmailrm.Text = "";
            txtnombrerm.Text = "";
            txtcontrarm.Text = "";
            cbpaisrm.Text = "";
        }
        private void btnaceptarra_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root";
            conexion.Open();
            string sentencia = "INSERT INTO alumno(username_Alumno,nombre_Alumno,email_Alumno,escolaridad,area,edad,sexo,contraseña_Alumno,pais_Alumno)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9)";
            MySqlCommand comando = new MySqlCommand(sentencia, conexion);
            comando.Parameters.AddWithValue("@1", txtidra.Text);
            comando.Parameters.AddWithValue("@2",txtnombrera.Text);
            comando.Parameters.AddWithValue("@3",txtmailra.Text);
            comando.Parameters.AddWithValue("@4",txtEscora.Text);
            comando.Parameters.AddWithValue("@5",txtareara.Text);
            comando.Parameters.AddWithValue("@6",txtedadra.Text);
            comando.Parameters.AddWithValue("@7",txtedadra.Text);
            comando.Parameters.AddWithValue("@8",txtContrara.Text);
            comando.Parameters.AddWithValue("@9",cbpaisra.Text);
            comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("Se agrego correctamente");
            txtidra.Text = "";
            txtnombrera.Text = "";
            txtmailra.Text= "";
            txtEscora.Text = "";
            txtareara.Text = "";
            txtedadra.Text = "";
            txtedadra.Text = "";
            txtContrara.Text = "";
            cbpaisra.Text = "";
        }

        private bool validar(string mail, string pass)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root; SslMode=none";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from docente where email_Docente=@email and password_Docente=@password";
            cmd.Parameters.AddWithValue("@email", mail);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = conexion;
            MySqlDataReader login = cmd.ExecuteReader();
            if(login.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }

        }
        private bool validarAlumno(string mail, string pass)
        {
            MySqlConnection conexion = new MySqlConnection();
            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root; SslMode=none";
            conexion.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from alumno where email_Alumno=@email and contraseña_Alumno=@password";
            cmd.Parameters.AddWithValue("@email", mail);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = conexion;
            MySqlDataReader login = cmd.ExecuteReader();
            if (login.Read())
            {
                conexion.Close();
                return true;
            }
            else
            {
                conexion.Close();
                return false;
            }

        }
        private void btnaceptaris_Click(object sender, EventArgs e)
        {
            
            string email = txtmailis.Text;
            string pass = txtcontrais.Text;
            if(email == "" || pass == "")
            {
                MessageBox.Show("No puede haber campos vacios");
                return;
            }
            bool r = validar(email, pass);
            bool r2 = validarAlumno(email, pass);
            if (r)
            {
                MessageBox.Show("Bienvenido maestro: "+email);
                Form1 nueva = new Form1();
                this.Hide();
                nueva.ShowDialog();
                this.Show();

            }
            else if(r2)
            {
                MessageBox.Show("Bienvenido alumno: "+email);
                Busqueda_Objeto nueva = new Busqueda_Objeto();
                this.Hide();
                ///nueva.btnUpdATE.Visible = false;
                nueva.btnEliminar.Visible = false;
                nueva.BtnAgregar.Visible = false;
                nueva.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
            txtmailis.Text = "";
            txtcontrais.Text = "";

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmailis_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbMestros.Checked = true;
            this.Size = new Size(698, 700);
            panel3.Visible = false;
            panel3.Left = 698;
            panel2.Visible = false;
            panel2.Left = 35;
            panel2.Visible = true;
            panel2.Refresh();
        }
    }
}
