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


            string rutvalida = rut.Text;
            
            if(rutvalida.Length == 9)
            {
                rutvalida = "0" + rutvalida;
            }



        }
    }
}
