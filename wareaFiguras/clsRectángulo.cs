using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wareaFiguras
{
    class clsRectángulo
    {
        private double Base = 0, Altura = 0, Área = 0;

        public clsRectángulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public double Area()
        {
            Área = Base * Altura;
            return Área;
        }

    }
}
