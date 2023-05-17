using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal class Prostokąt : IProstokąt
    {
        private double
            bokA = 0,
            bokB = 0
            ;

        public double BokA { get => bokA; set => bokA = value; }
        public double BokB { get => bokB; set => bokB = value; }

        public double Obwód => IProstokąt.ObliczObwód(this);
        public double Pole => IProstokąt.ObliczPole(this);
        public double Średnica => IProstokąt.ObliczŚrednica(this);

        public string Info => IProstokąt.ZwróćInfo(this);
    }
}
