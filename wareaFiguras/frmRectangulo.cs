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
    public partial class frmRectangulo : Form
    {
        Graphics Gráfico;

        public frmRectangulo()
        {
            InitializeComponent();
            Gráfico = CreateGraphics();
        }

        private void btnrectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                float Base = float.Parse(txtbase.Text);
                float Altura = float.Parse(txtaltura.Text);

                clsRectángulo rectángulo = new clsRectángulo(Base, Altura);
                Gráfico.FillRectangle(Brushes.Indigo, Base, Altura, Base, Altura);


                txtarea.Text = Convert.ToString(rectángulo.Area());

            }
            catch (Exception)
            {

                MessageBox.Show("Digite valores válidos");
            }
        }
    }
}
