using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal class Koło : IKoło, IComparable<IKoło>
    {
        private double promień = 0;

        public double Promień { get => promień; set => promień = value; }

        public double Obwód => IKoło.ObliczObwód(this);
        public double Pole => IKoło.ObliczPole(this);
        public double Średnica => IKoło.ObliczŚrednica(this);

        public string Info => IKoło.ZwróćInfo(this);

        public override string ToString()
            => $"Koło o promieniu {Promień}";

        public static bool operator ==(Koło L, Koło P)
            => L.Promień == P.Promień;
        public static bool operator !=(Koło L, Koło P)
            => !(L == P);

        public override bool Equals(object? that)
        {
            if (that is Koło)
                return this == ((Koło)that);
            else
                return false;
        }
        public override int GetHashCode()
            => Promień.GetHashCode();

        public int CompareTo(IKoło? that)
            => this.Promień.CompareTo(that.Promień);
    }
}
