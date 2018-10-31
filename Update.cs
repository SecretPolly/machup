using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entregable
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtcMB_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void upload_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = " Archivos|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx";
            open.Title = "Archivos";
            if(open.ShowDialog() == DialogResult.OK)
            {
                rutaTexto.Text = open.FileName;
            }
            open.Dispose();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        
        private void bunifuMetroTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
