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
    public partial class frmCírculo : Form
    {
        Graphics Gráfico;
        public frmCírculo()
        {
            InitializeComponent();
            Gráfico = CreateGraphics();
        }

        private void btncirculo_Click(object sender, EventArgs e)
        {
            try
            {
                float radio = float.Parse(txtradio.Text);

                clsCírculo círculo = new clsCírculo(radio);
                Gráfico.FillEllipse(Brushes.Chocolate, 167, 167, radio, radio);

                txtárea.Text = Convert.ToString(círculo.Area());

            }
            catch (Exception)
            {

                MessageBox.Show("Digite un valor válido");
            }
        }
    }
}
