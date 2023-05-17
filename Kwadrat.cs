using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal class Kwadrat : IKwadrat
    {
        private double bok = 0;

        public double Bok { get => bok; set => bok = value; }
        public double BokA { get => Bok; set => Bok = value; }
        public double BokB { get => Bok; set => Bok = value; }
        public double Kąt
        {
            get => PI / 2;
            set { }
        }

        public double Obwód => IRomb.ObliczObwód(this);
        public double Pole => IProstokąt.ObliczPole(this);
        public double Średnica => IKwadrat.ObliczŚrednica(this);

        public string Info => IKwadrat.ZwróćInfo(this);
    }
}
