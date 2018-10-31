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
    public partial class searchDataGrid : Form
    {

        public int xClick = 0, yClick = 0;
        public searchDataGrid()
        {
            InitializeComponent();
        }
        private Busqueda_Objeto mainform = null;

        public searchDataGrid(Form callingForm)
        {
            mainform = callingForm as Busqueda_Objeto;
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtpalabrabuscada.Text == "")
            {
                MessageBox.Show("No puede estar el campo vacio","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                this.mainform.palabra_a_buscar = txtpalabrabuscada.Text.ToString();
                this.Close();
            }
            

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtpalabrabuscada_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void searchDataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
            }
        }
    }
}
