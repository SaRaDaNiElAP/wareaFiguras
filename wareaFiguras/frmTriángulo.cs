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
    public partial class frmTriángulo : Form
    {
        Graphics Gráfico;
        public frmTriángulo()
        {
            InitializeComponent();
            Gráfico = CreateGraphics();
        }

        private void btntriangulo_Click(object sender, EventArgs e)
        {
            try
            {
                float Base = float.Parse(txtbase.Text);
                float Altura = float.Parse(txtaltura.Text);

                clsTriángulo triángulo = new clsTriángulo(Base, Altura);
                SolidBrush brocha = new SolidBrush(Color.Red);
                PointF punto1 = new PointF(200, 250);
                PointF punto2 = new PointF(200 + Base, 250);
                PointF punto3 = new PointF((200 + Base / 2), 250 - Altura);
                PointF[] puntos = { punto1, punto2, punto3 };
                Gráfico.FillPolygon(Brushes.Red, puntos);

                txtarea.Text = Convert.ToString(triángulo.Area());
            }
            catch (Exception)
            {

                MessageBox.Show("Digite un valor válido");
            }

        }
    }
}
