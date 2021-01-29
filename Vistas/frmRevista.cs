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
using Hemeroteca.Entidades;

namespace Hemeroteca.Vistas
{
    public partial class frmRevista : Form
    {
        public frmRevista()
        {
            InitializeComponent();
        
            revistaBindingSource.DataSource = pRevista.GetAll();
        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRevista vamp = new frmEditarRevista(null);
            vamp.ShowDialog();
            revistaBindingSource.DataSource = pRevista.GetAll();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            frmEditarRevista vamp = new frmEditarRevista((Revista)revistaBindingSource.Current);
            vamp.ShowDialog();
            revistaBindingSource.DataSource = pRevista.GetAll();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar registro de revista", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pRevista.Delete((Revista)revistaBindingSource.Current);
                revistaBindingSource.DataSource = pRevista.GetAll();
            }
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RevistaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btFacultad_Click(object sender, EventArgs e)
        {
            // frmFacultad  = new frmFacultad();
            frmRevistaFacultad vamp = new frmRevistaFacultad();
            vamp.ShowDialog();
            revistaBindingSource.DataSource = pRevista.GetAll();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.revistaBindingSource.DataSource = pRevista.Buscar(txNombreRevista.Text);
        }
    }
}
