using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wareaFiguras
{
    class clsCuadrado
    {
        private int lado=0, area = 0;

        public clsCuadrado(int lado)
        {
            this.lado = lado;
            
        }

        public int obtenlado()
        {
            return lado;
        }

        public int Area()
        {
            area = lado * lado;
            return area;
        }
    }
}
