using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wareaFiguras
{
    class clsTriángulo
    {
        private double Base = 0, Altura = 0, área = 0;

        public clsTriángulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public double Area()
        {
            área = (Base * Altura) / 2;
            return área;
        }
    }
}
