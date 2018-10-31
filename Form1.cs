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
using Dropbox.Api;
using System.IO;
using Dropbox.Api.Files;

using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.Net;
using System.Collections.Specialized;


namespace entregable
{
    public partial class Form1 : Form
    {
        string oldName;
        string extension;
        string newFile;

        private HttpAuthorization Authorization = null;
        private string CurrentPath = "";

        public Form1()
        {
            InitializeComponent();
        }
        public int xClick = 0, yClick = 0;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            txtdescripcion.MaxLength = 1000;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Busqueda_Objeto nueva = new Busqueda_Objeto();
            this.Hide();
            nueva.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        /*private void upload_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx";
            open.Title = "Archivos";
            if (open.ShowDialog() == DialogResult.OK)
            {
                archivoText.Text = open.FileName;
            }
            open.Dispose();
        }*/

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string id_articulo;
            string nombre_original;
            MySqlConnection conexion = new MySqlConnection();

            conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root; SslMode=none";
            conexion.Open();

            string sql = "select ID_CONTENIDO + 1 as id from registro_objetos order by ID_CONTENIDO desc limit 1";
            MySqlCommand query = new MySqlCommand(sql, conexion);
            MySqlDataReader myReader = query.ExecuteReader();
            myReader.Read();
            id_articulo = myReader["id"].ToString();
            conexion.Close();
            

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
            //nombre_original = open.FileName;
            oldName = Path.GetFileName(open.FileName);
            extension = Path.GetExtension(open.FileName);


            // send file

            newFile = open.FileName.Replace(oldName, id_articulo + extension);
            File.Copy(open.FileName, newFile,true);
            var fs = new FileStream(newFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            //renombrar archivo
            
            

            long fileSize = fs.Length;
            string fileName = fs.Name;
            // get file length for progressbar

            var fileInfo = UniValue.Empty;
            fileInfo["path"] = (String.IsNullOrEmpty(this.CurrentPath) ? "/" : "") + Path.Combine(this.CurrentPath, Path.GetFileName(newFile)).Replace("\\", "/");
            //MessageBox.Show(fileInfo["path"].ToString());
            fileInfo["mode"] = "add";
            fileInfo["autorename"] = true;
            fileInfo["mute"] = false;
            this.Authorization = new HttpAuthorization(AuthorizationType.Bearer, Properties.Settings.Default.AccessToken);

            OAuthUtility.PostAsync
            (
              "https://content.dropboxapi.com/2/files/upload",
              new HttpParameterCollection
              {
          { fs } // content of the file
              },
              headers: new NameValueCollection { { "Dropbox-API-Arg", fileInfo.ToString() } },
              contentType: "application/octet-stream",
              authorization: this.Authorization,
              // handler of result
              callback: this.Upload_Result
              // handler of uploading
              //streamWriteCallback: this.Upload_Processing
            );



            MySqlConnection conexion2 = new MySqlConnection();

            conexion2.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root; SslMode=none";
            conexion2.Open();

            string sentencia = "INSERT INTO REGISTRO_OBJETOS(ID_TEMA,NOMBRE_OBJETO,FECHA,AUTOR,DESCRIPCION,CANTIDAD_MB,TIPO,Ext_Archivo,Nom_Origen)VALUES(@1,@2,@3,@4,@5,@6,@7,@8,@9)";
            
            MySqlCommand comando = new MySqlCommand(sentencia, conexion2);

            //comando.Parameters.AddWithValue("@1", txtcdarticulo.Text);
            comando.Parameters.AddWithValue("@1", txtctema.Text);
            comando.Parameters.AddWithValue("@2", txtnobjeto.Text);
            comando.Parameters.AddWithValue("@3", bunifuDatepicker1.Value.ToString());
            comando.Parameters.AddWithValue("@4", txtautor.Text);
            comando.Parameters.AddWithValue("@5", txtdescripcion.Text);
            comando.Parameters.AddWithValue("@6", fileSize/1024);
            comando.Parameters.AddWithValue("@7", txttipo.Text);
            comando.Parameters.AddWithValue("@8", extension);
            comando.Parameters.AddWithValue("@9", oldName);
            comando.ExecuteNonQuery();
            conexion2.Close();
            //txtcdarticulo.Text = "";
            txtctema.Text = "";
            txtnobjeto.Text = "";
            bunifuDatepicker1.Text = "";
            txtautor.Text = "";
            txtdescripcion.Text = "";
            //archivoText.Text = "";
            txttipo.Text = "";

            
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }

        private void txtautor_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcdarticulo_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtctema_OnValueChanged(object sender, EventArgs e)
        {

        }

        /*private void Upload_Processing(object sender, StreamWriteEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<object, StreamWriteEventArgs>(this.Upload_Processing), sender, e);
                return;
            }

            progressBar1.Value = Math.Min(Convert.ToInt32(Math.Round((e.TotalBytesWritten * 100.0) / this.UploadingFileLength)), 100);
        }*/

        private void Upload_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(this.Upload_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                MessageBox.Show("El articulo se ha guardado exitosamente");
                //borrar archivo temporal
                File.Delete(newFile);
            }
            else
            {
                if (result["error_summary"].HasValue)
                {
                    MessageBox.Show("Hubo un error al subir el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al subir el archivo", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        


    }

        /*
        private void archivoText_OnValueChanged(object sender, EventArgs e)
        {

        }*/

        /*async Task Upload(DropboxClient dbx, string folder, string file)
        {

            var updated = await dbx.Files.UploadAsync(
                folder + "/" + file
                //WriteMode.Overwrite.Instance
                );
            Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
            
        }*/
    

}
