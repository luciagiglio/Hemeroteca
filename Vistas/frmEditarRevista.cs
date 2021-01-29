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
    public partial class frmEditarRevista : Form
    {
       // int i;
        public frmEditarRevista(Revista r)
        {
            InitializeComponent();

            direccionComboBox.DataSource = pDireccion.GetAll();
            direccionComboBox.ValueMember = "Id";
            direccionComboBox.DisplayMember = "Calle" + "Ciudad";
            

            if (r == null)
            {
                revistaBindingSource.Add(new Revista());
            }
            else
            {
                revistaBindingSource.DataSource = r;
                
            }

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            Revista r = (Revista)revistaBindingSource.DataSource;
            if (r.Id == 0)
                pRevista.Insert(r, (Direccion)direccionComboBox.SelectedItem);
            else
                pRevista.Update(r, (Direccion)direccionComboBox.SelectedItem);
            Close();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
