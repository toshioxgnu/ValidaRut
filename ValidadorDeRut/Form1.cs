using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorDeRut
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void validaRut_Click(object sender, EventArgs e)
        {
            int[] constantesValidacion = {3,2,7,6,5,4,3,2};
            double suma = 0 ;

            string rutvalida = rut.Text;
            
            if(rutvalida.Length == 9)
            {
                rutvalida = "0" + rutvalida;
            }

            for(int j = 0; j<constantesValidacion.Length; j++)
            {
                suma = suma + (Int16.Parse(rutvalida[j].ToString()) * constantesValidacion[j]);
                
            }

            double division = suma/11;
            int divisionentero = (int) division ;
            double resto = division - divisionentero;
            double resta = 11 - (11 * resto);
            int digito = (int) resta;

            if (digito == Int16.Parse(rutvalida[9].ToString()))
            {
                MessageBox.Show("Rut Correcto");
            }
            else
            {
                MessageBox.Show("Rut incorrecto, el digito debe ser :" + digito);
            }
        }
    }
}
