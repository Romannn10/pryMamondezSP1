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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }
        public char separador = Convert.ToChar(",");

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String IDCultivo= mskNumeroCultivo.Text;
            string NombreCultivo = txtNombreCultivo.Text;
            bool bandera = false; //booleano para que no se repita el numero

            //Corrobora si existe el archivo y sino lo crea
            StreamWriter Cultivo = new StreamWriter("./Cultivos.txt", true);
            Cultivo.Close();

            StreamReader srControladorCultivos = new StreamReader("./Cultivos.txt");
            while (!srControladorCultivos.EndOfStream)
            {
                //le guardamos al vector cultivos una linea del archivo con el separador (coma)
                string[] vecCultivos = srControladorCultivos.ReadLine().Split(separador);

                if (IDCultivo == vecCultivos[0])
                {
                    MessageBox.Show("Numero Repetido");
                    bandera = true;
                }
            }
            srControladorCultivos.Close();

            if (bandera == false)
            {
                StreamWriter Cultivos = new StreamWriter("./Cultivos.txt", true);

                Cultivos.WriteLine(IDCultivo + "," + NombreCultivo);

                Cultivos.Close();

                MessageBox.Show("Cultivo cargado con éxito.");

                Cultivos.Close();
                txtNombreCultivo.Text = "";
                mskNumeroCultivo.Text = "";
            }

        }

        private void frmCultivos_Load(object sender, EventArgs e)
        {

        }
    }
}
