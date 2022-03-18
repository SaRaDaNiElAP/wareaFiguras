using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wareaFiguras
{
    class clsCírculo
    {
        private double radio=0, pi = 3.1416, área=0;

        public clsCírculo (double radio)
        {
            this.radio = radio;
        }

        public double Area()
        {
            área = pi * Math.Pow(radio, 2);
            return área;
        }
    }
}
