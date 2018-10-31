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
using System.Web;

using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.Net;
using System.Collections.Specialized;

using Dropbox.Api;
using System.IO;

namespace entregable
{
    public partial class Busqueda_Objeto : Form
    {
        private const string V = "name";
        private HttpAuthorization Authorization = null;
        private string CurrentPath = "";

        public string palabra_a_buscar;
        static string conString = "Server=localhost;Database=mashup_proyecto;Uid=root;Pwd=;SslMode=none";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        int idw = 0;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        private Stream DownloadReader = null;
        private FileStream DownloadFileStream = null;
        private BinaryWriter DownloadWriter = null;
        private byte[] DownloadReadBuffer = new byte[4096];        



        public Busqueda_Objeto()
        {
            

            InitializeComponent();
            bunifuCustomDataGrid1.ColumnCount = 9;
            bunifuCustomDataGrid1.Columns[0].Name = "Codigo del articulo";
            bunifuCustomDataGrid1.Columns[1].Name = "Codigo del tema";
            bunifuCustomDataGrid1.Columns[2].Name = "Nombre del objeto";
            bunifuCustomDataGrid1.Columns[3].Name = "Fecha";
            bunifuCustomDataGrid1.Columns[4].Name = "Autor";
            bunifuCustomDataGrid1.Columns[5].Name = "Descripcion";
            bunifuCustomDataGrid1.Columns[6].Name = "Tipo";
            bunifuCustomDataGrid1.Columns[7].Name = "Peso (KB)";


            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.MultiSelect = false;
        }
        public int xClick = 0, yClick = 0;

        private void populate(String id, String codigo_tema, String N_Objeto, String fecha, String autor, String Cgb, String tipo, String descripcion)
        {

            bunifuCustomDataGrid1.Rows.Add(id, codigo_tema, N_Objeto, fecha, autor, Cgb, tipo, descripcion);
            
        }

        /*private void GetFiles()
        {
            OAuthUtility.PostAsync
            (
              "https://api.dropboxapi.com/2/files/list_folder",
              new HttpParameterCollection
              {
          new
          {
            path = this.CurrentPath,
            include_media_info = true
          }
              },
              contentType: "application/json",
              authorization: this.Authorization,
              callback: this.GetFiles_Result
            );
        }*/
        private void retrieve()
        {

            this.Authorization = new HttpAuthorization(AuthorizationType.Bearer, Properties.Settings.Default.AccessToken);
            OAuthUtility.PostAsync
            (
              "https://api.dropboxapi.com/2/files/list_folder",
              new HttpParameterCollection
              {
          new
          {
            path = this.CurrentPath,
            include_media_info = true
          }
              },
              contentType: "application/json",
              authorization: this.Authorization,
              callback: this.GetFiles_Result
            );
            
        }
        

        private void GetFiles_Result(RequestResult result)
        {
            

            //SQL STMT
            string sql = "SELECT * FROM registro_objetos";
            cmd = new MySqlCommand(sql, con);

            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(this.GetFiles_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                bunifuCustomDataGrid1.Rows.Clear();
                
                //OPEN CON,RETRIEVE,FILL DGVIEW
                try
                {
                    
                    con.Open();
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    //LOOP THRU DT
                    int i = 0;
                    int x = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
                    }

                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.HeaderText = "Descargar";
                    btn.Name = "download";
                    btn.Text = "Descargar";
                    btn.UseColumnTextForButtonValue = true;
                    //Hook our button up to our generic button handler
                    //btn.Click += new EventHandler(btn_Click);
                    //bunifuCustomDataGrid1.Controls.Add(btn);
                    bunifuCustomDataGrid1.Columns.Add(btn);

                    con.Close();
                    //CLEAR DT
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show(result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            


            
        }

        public void buscar(string valor)
        {
            bunifuCustomDataGrid1.Rows.Clear();
            string query = "SELECT * FROM registro_objetos WHERE CONCAT(`ID_CONTENIDO`,`ID_TEMA`,`NOMBRE_OBJETO`,`FECHA`,`AUTOR`,`DESCRIPCION`,`CANTIDAD_MB`,`TIPO`) like '%" + valor + "%'";
            cmd = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(cmd);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString());
            }
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Descargar";
            btn.Name = "download";
            btn.Text = "Descargar";
            btn.UseColumnTextForButtonValue = true;
            //Hook our button up to our generic button handler
            //btn.Click += new EventHandler(btn_Click);
            //bunifuCustomDataGrid1.Controls.Add(btn);
            bunifuCustomDataGrid1.Columns.Add(btn);

            dt.Rows.Clear();
        }
        public void update(int ID_CONTENIDO, int ID_TEMA, string NOMBRE_OBJETO, string FECHA, string AUTOR, string DESCRIPCION, String TIPO)
        {
            Update nueva = new Update();
            nueva.ShowDialog();
            if (nueva.txtctema.Text != "")
            {
                string sql = "UPDATE registro_objetos SET ID_CONTENIDO='" + Convert.ToInt32(nueva.txtcdarticulo.Text)
                + "',ID_TEMA='" + Convert.ToInt32(nueva.txtctema.Text)
                + "',NOMBRE_OBJETO='" + nueva.txtnobjeto.Text
                + "',FECHA='" + nueva.bunifuDatepicker1.Value.ToString() +
                "',AUTOR='" + nueva.txtautor.Text +
                "',DESCRIPCION='" + nueva.txtdescripcion.Text +
                "',TIPO='" + nueva.txttipo.Text +

                "'WHERE ID_CONTENIDO=" + ID_CONTENIDO + "";
                cmd = new MySqlCommand(sql, con);
                try
                {
                    con.Open();
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.UpdateCommand = con.CreateCommand();
                    adapter.UpdateCommand.CommandText = sql;
                    if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("updated");
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();

                }
            }
            else
                MessageBox.Show("Error hay campos vacios", "campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nueva.Close();
            
           
        }
        private void Busqueda_Objeto_MouseMove(object sender, MouseEventArgs e)
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
            
            searchDataGrid nueva = new searchDataGrid(this);
            nueva.ShowDialog();
            buscar(palabra_a_buscar);
           
        }
        public string LabelText
        {
            get { return palabra_a_buscar; }
            set { palabra_a_buscar = value; }
        }

        private void Busqueda_Objeto_Load(object sender, EventArgs e)
        {
            buscar("");
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Form1 nueva = new Form1();
            nueva.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            searchDataGrid nueva = new searchDataGrid(this);
            nueva.label1.Text = "Eliminar";
            nueva.bunifuCustomLabel1.Text = "Ingrese el ID del objeto a eliminar";
            nueva.ShowDialog();
            buscar(palabra_a_buscar);
            if (palabra_a_buscar != null)
            {
                string sql = ("DELETE FROM registro_objetos where ID_CONTENIDO = " + palabra_a_buscar + "");
                MySqlCommand eliminar = new MySqlCommand(sql, con);
                eliminar.ExecuteScalar();
                MessageBox.Show("REGISTRO ELIMINDADO");

            }
            else
                MessageBox.Show("Error");

            con.Close();

        }

        private void btnUpdATE_Click(object sender, EventArgs e)
        {
            int id_tema = 0;
            String aux2 = "";
            String aux3 = "";
            String aux4 = "";
            String aux5 = "";
            String aux6 = "";
            int id = Convert.ToInt32(bunifuCustomDataGrid1.Rows[idw].Cells[0].Value.ToString());
            update(id, id_tema,aux2,aux3,aux4,aux5,aux6);
            retrieve();
        }

        private void bunifuCustomDataGrid1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idw = Convert.ToInt32(bunifuCustomDataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Authorization = new HttpAuthorization(AuthorizationType.Bearer, Properties.Settings.Default.AccessToken);

            DataGridView dvg = (DataGridView)sender;

           if(e.ColumnIndex == 9 && e.RowIndex != -1)
            {
                // Inicializar variables
                string id = (string)dvg["Codigo del articulo", e.RowIndex].Value.ToString();
                string ext;
                string file;
                int id_int = Convert.ToInt32(id);

                //Conexión a la base de datos
                MySqlConnection conexion = new MySqlConnection();
                conexion.ConnectionString = "server=localhost; pasword=;" + "database=MASHUP_PROYECTO; User id= root; SslMode=none";
                conexion.Open();
                string sql = "select Ext_archivo,Nom_Origen from registro_objetos where ID_CONTENIDO = " + id;
                MySqlCommand query = new MySqlCommand(sql, conexion);
                MySqlDataReader myReader = query.ExecuteReader();
                myReader.Read();

                //construcción del nombre del archivo a descargar
                ext = myReader["Ext_Archivo"].ToString();
                file = id + ext;
                


                SaveFileDialog save = new SaveFileDialog();
                //this.save.FileName = Path.GetFileName(file["path_display"].ToString());
                save.FileName = myReader["Nom_Origen"].ToString();
                conexion.Close();
                if (save.ShowDialog() != System.Windows.Forms.DialogResult.OK) { return; }
                string path2 = save.FileName;
                
                // token = Properties.Settings.Default.AccessToken
                /*var dbx = new DropboxClient(Properties.Settings.Default.AccessToken);


                using (var response = dbx.Files.DownloadAsync("/8.gif"))
                {
                    (await response.getGetContentAsStreamAsync()).CopyTo(fileStream);
                }
                MessageBox.Show(response.);*/
                this.DownloadFileStream = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                this.DownloadWriter = new BinaryWriter(this.DownloadFileStream);


                var req = WebRequest.Create("https://content.dropboxapi.com/2/files/download");
                req.Method = "POST";

                req.Headers.Add(HttpRequestHeader.Authorization, this.Authorization.ToString());
                req.Headers.Add("Dropbox-API-Arg", UniValue.Create(new { path = "/" + file  }).ToString());

                req.BeginGetResponse(result =>
                {
                    var resp = req.EndGetResponse(result);

                    // get response stream
                    this.DownloadReader = resp.GetResponseStream();

                    // read async
                    this.DownloadReader.BeginRead(this.DownloadReadBuffer, 0, this.DownloadReadBuffer.Length, this.DownloadReadCallback, null);
                }, null);

                //MessageBox.Show((e.RowIndex+1).ToString() + " Row clicked");
            }
        }

        private void DownloadReadCallback(IAsyncResult result)
        {
            var bytesRead = this.DownloadReader.EndRead(result);

            if (bytesRead > 0)
            {
                if (this.DownloadFileStream.CanWrite)
                {
                    // write to file
                    this.DownloadWriter.Write(this.DownloadReadBuffer.Take(bytesRead).ToArray());

                    // read next part
                    this.DownloadReader.BeginRead(this.DownloadReadBuffer, 0, this.DownloadReadBuffer.Length, DownloadReadCallback, null);
                }
            }
            else
            {
                this.DownloadFileStream.Close();

            }
        }

        private void bunifuCustomDataGrid1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Vista nueva = new Vista();
            this.Hide();
            nueva.ShowDialog();
            this.Show();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            retrieve();
        }
    }
}
