using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMamondezLP_SP1
{
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtToneladas.Text != "" && lstCultivo.SelectedIndex != -1 && lstLocalidad.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }

            StreamWriter produccion = new StreamWriter("./Produccion.txt", true);
            produccion.WriteLine(txtToneladas.Text);
            MessageBox.Show("Toneladas cargadas con éxito.");
            produccion.Close();
            lstCultivo.SelectedIndex = -1;
            lstLocalidad.SelectedIndex = -1;
            txtToneladas.Text = "";

        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            if (txtToneladas.Text != "" && lstCultivo.SelectedIndex != -1 && lstLocalidad.SelectedIndex != -1)
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }



            StreamReader lectorLocalidad = new StreamReader("./Localidades.txt");
            StreamReader lectorCultivos = new StreamReader("./Cultivos.txt");
            char varSeparador = Convert.ToChar(",");

            while (!lectorCultivos.EndOfStream)
            {
                string[] vecnombreCultivos = lectorCultivos.ReadLine().Split(varSeparador);
                lstCultivo.Items.Add(vecnombreCultivos[1]);

            }




            lectorCultivos.Close();

            while (!lectorLocalidad.EndOfStream)
            {
                string[] vecnombreLocalidad = lectorLocalidad.ReadLine().Split(varSeparador);
                lstLocalidad.Items.Add(vecnombreLocalidad[1]);

            }
            lectorLocalidad.Close();
        }
    }
}
