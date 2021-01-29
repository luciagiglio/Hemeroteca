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
    public partial class frmEditarDireccion : Form
    {
       
        public frmEditarDireccion(Direccion d)
        {
            
            InitializeComponent();
            
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
