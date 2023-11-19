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
    public partial class frmPrincipal : Form
    {
        clsAccesoDatos objAccesoDatos;
        
        public frmPrincipal()
        {
            InitializeComponent();
            objAccesoDatos = new clsAccesoDatos();
            objAccesoDatos.ConectarBD();
            if (objAccesoDatos.EstadoConexion == "Conectado")
            {
                lblEstado.Text = objAccesoDatos.EstadoConexion;
                lblEstado.BackColor = Color.LightGreen;
            }
            else
            {
                lblEstado.Text = objAccesoDatos.EstadoConexion;
                lblEstado.BackColor = Color.Red;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
            
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAltaUsuario frmAltaUsuario = new frmAltaUsuario();
            frmAltaUsuario.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListar frmListar = new frmListar();
            frmListar.ShowDialog();
        }
    }
}
