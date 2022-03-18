using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wareaFiguras
{
    public partial class frmCuadrado : Form
    {
        Graphics Gráfico;
        public frmCuadrado()
        {
            InitializeComponent();
            Gráfico = CreateGraphics();
        }

        private void btncuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                int lado = int.Parse(txtlado.Text);

                clsCuadrado cuadrado = new clsCuadrado(lado);
                Gráfico.FillRectangle(Brushes.Aqua, cuadrado.obtenlado(), cuadrado.obtenlado(), cuadrado.obtenlado(), cuadrado.obtenlado());

                txtarea.Text = Convert.ToString(cuadrado.Area());
            }
            catch (Exception)
            {

                MessageBox.Show("Digite valores válidos");
            }

        }


    }
}
