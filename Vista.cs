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
    public partial class Vista : Form
    {
        static string conString = "Server=localhost;Database=mashup_proyecto;Uid=root;Pwd=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        DataGridView dgv;
        public Vista()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.ColumnCount = 2;
            bunifuCustomDataGrid1.Columns[0].Name = "Código alumno";
            bunifuCustomDataGrid1.Columns[1].Name = "País";
            bunifuCustomDataGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            bunifuCustomDataGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bunifuCustomDataGrid1.MultiSelect = false;
        }
        public int xClick = 0, yClick = 0;

        private void populate(String username_Alumno, String pais_Alumno)
        {
            bunifuCustomDataGrid1.Rows.Add(username_Alumno, pais_Alumno);
        }
        private void retrieve()
        {
            bunifuCustomDataGrid1.Rows.Clear();

            //SQL STMT
            string sql = "SELECT * FROM vw_Names";
            cmd = new MySqlCommand(sql, con);

            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                con.Open();

                adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dt);

                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString());
                }

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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            retrieve();
        }
    }
}
