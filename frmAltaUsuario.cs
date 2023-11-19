using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFollentiTP
{
    public partial class frmAltaUsuario : Form
    {
        clsAccesoDatos objBD;
        public frmAltaUsuario()
        {
            InitializeComponent();
            objBD = new clsAccesoDatos();  
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCUIT.Text);
            objBD.CargarUsuario(cod, txtNombre.Text, txtApellido.Text, dtpFecha.Value,
                                txtCiudad.Text, txtDireccion.Text, txtTelefono.Text);
            
        }
    }
}
