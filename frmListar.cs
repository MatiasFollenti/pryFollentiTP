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
    public partial class frmListar : Form
    {
        clsAccesoDatos objAccesoDatos;
        public frmListar()
        {
            InitializeComponent();
            objAccesoDatos = new clsAccesoDatos();
            objAccesoDatos.TraerDatos(dgvMostrar);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvMostrar.Columns.Clear();
           

            if (cmbBuscar.SelectedIndex == 0)
            {
                objAccesoDatos.BuscarPorApellido(txtBuscar.Text.ToUpper(), dgvMostrar);

            }
            else
            {
                objAccesoDatos.BuscarPorCiudad(txtBuscar.Text.ToUpper(), dgvMostrar);
            }

        }

        private void btnListadoC_Click(object sender, EventArgs e)
        {
            dgvMostrar.Columns.Clear();
            objAccesoDatos.TraerDatos(dgvMostrar);
        }
    }
}
