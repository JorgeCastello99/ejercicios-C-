using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    class Circulo : Figura
    {
        public Circulo(int radio)
        {
            Lado1 = radio;
        }
        public override float area()
        {
            return 3.141516F * Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return 3.141516F * 2 * Lado1;
        }
    }
}
