using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsySalud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //inicializo las variables

            Decimal a = 0;
            Decimal b = 0;
            Decimal calculo = 0;

            a = Convert.ToDecimal(txtAltura.Text);
            b = Convert.ToDecimal(txtPeso.Text);

            calculo = b / (a * a);
            txtResultado.Text = Convert.ToString(calculo);

            if ( calculo < 18) {

            }






        }
    }
}
