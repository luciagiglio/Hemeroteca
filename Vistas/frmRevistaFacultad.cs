using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hemeroteca.Controladores;

namespace Hemeroteca.Vistas
{
    public partial class frmRevistaFacultad : Form
    {
        public frmRevistaFacultad()
        {
            InitializeComponent();
            revistaFacultadBindingSource.DataSource = pRevistaFacultad.GetAll();
        }

        private void revistaFacultadDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            frmRevista frm = new frmRevista();
            frm.ShowDialog();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
