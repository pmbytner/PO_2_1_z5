using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal class Romb : IRomb
    {
        private double
            bok = 0,
            kąt = PI / 2
            ;

        public double Bok { get => bok; set => bok = value; }
        public double Kąt { get => kąt; set => kąt = value; }

        public double Obwód => IRomb.ObliczObwód(this);
        public double Pole => IRomb.ObliczPole(this);
        public double Średnica => IRomb.ObliczŚrednica(this);

        public string Info => IRomb.ZwróćInfo(this);
    }
}
