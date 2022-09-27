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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        //Separador de cadena
        public char Separador = Convert.ToChar(",");

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String IDLocalidad = mskNumeroLocalidad.Text;
            string NombreLocalidad = txtNombreLocalidad.Text;
            bool bandera = false;

            //Corrobora si existe el archivo y sino lo crea
            StreamWriter localidad = new StreamWriter("./Localidades.txt",true);
            localidad.Close();

            StreamReader srControladorLocalidades = new StreamReader("./Localidades.txt");
            while (!srControladorLocalidades.EndOfStream)
            {

                string[] vecLocalidades = srControladorLocalidades.ReadLine().Split(Separador);

                if (IDLocalidad == vecLocalidades[0])
                {
                    MessageBox.Show("Numero Repetido");
                    bandera = true;
                }
            }
            srControladorLocalidades.Close();

            if (bandera == false)
            {
                StreamWriter localidades = new StreamWriter("./Localidades.txt", true);

                localidades.WriteLine(IDLocalidad + "," + NombreLocalidad);

                localidades.Close();

                MessageBox.Show("Localidad cargado con éxito.");

                localidades.Close();
                txtNombreLocalidad.Text = "";
                mskNumeroLocalidad.Text = "";
            }
        }

        private void frmLocalidades_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskNumeroLocalidad.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void mskNumeroLocalidad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskNumeroLocalidad.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtNumeroLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreLocalidad.Text != "" && mskNumeroLocalidad.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }
    }
}
