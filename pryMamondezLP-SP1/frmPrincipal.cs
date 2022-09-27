using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMamondezLP_SP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidades objVentanaLocalidad = new frmLocalidades();
            objVentanaLocalidad.ShowDialog();
        }

        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos objVentanaCultivos = new frmCultivos();
            objVentanaCultivos.ShowDialog();
        }

        private void produccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion objVentanaProduccion = new frmProduccion();
            objVentanaProduccion.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
