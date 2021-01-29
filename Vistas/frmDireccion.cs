using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hemeroteca.Entidades;
using Hemeroteca.Controladores;

namespace Hemeroteca.Vistas
{
    public partial class frmDireccion : Form
    {
        public frmDireccion()
        {
            InitializeComponent();

            direccionBindingSource.DataSource = pDireccion.GetAll();
            

        }

        private void BtNuevo_Click(object sender, EventArgs e)
        {
            frmEditarDireccion vamp = new frmEditarDireccion(null);
            vamp.ShowDialog();
            direccionBindingSource.DataSource = pDireccion.GetAll();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            frmEditarDireccion vamp = new frmEditarDireccion((Direccion)direccionBindingSource.Current);
            vamp.ShowDialog();
            direccionBindingSource.DataSource = pDireccion.GetAll();
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminar registro de Direccion", "¿Esta seguro de eliminar el registro?", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                pDireccion.Delete((Direccion)direccionBindingSource.Current);
                direccionBindingSource.DataSource = pDireccion.GetAll();
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            this.direccionBindingSource.DataSource = pDireccion.Buscar(txNombre.Text);


        }

        private void direccionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
