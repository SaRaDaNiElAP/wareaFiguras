using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Sara Daniela Parra Betancur, Natalia Úsuga Manco, Maicol Arroyave Álvarez
/// 18/03/22
/// Áreas Figuras
/// </summary>

namespace wareaFiguras
{
    public partial class frmareaFiguras : Form
    {
        public frmareaFiguras()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuadrado cuadrado = new frmCuadrado();
            cuadrado.Show();
        }

        private void rectánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRectangulo rectangulo = new frmRectangulo();
            rectangulo.Show();
        }

        private void círculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCírculo círculo = new frmCírculo();
            círculo.Show();
        }

        private void triánguloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTriángulo triángulo = new frmTriángulo();
            triángulo.Show();
        }
    }
}
