using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal interface IKoło : IFigura
    {
        double Promień { get; set; }

        //poniższe metody statyczne dostarczają implementację
        //do której można się łatwo odnieść w klasach implementujących
        //oraz interfejsach pochodnych
        //mogą prawdopodobnie być public
        protected static double ObliczObwód(IKoło koło)
            => PI * 2 * koło.Promień;
        protected static double ObliczPole(IKoło koło)
            => PI * koło.Promień * koło.Promień;
        protected static double ObliczŚrednica(IKoło koło)
            => 2 * koło.Promień;

        protected static string ZwróćInfo(IKoło koło) =>
            $"Koło o promieniu {koło.Promień}\n" +
            $"\tObwód {koło.Obwód}\n" +
            $"\tPole {koło.Pole}\n" +
            $"\tŚrednica (przekątna) {koło.Średnica}"
            ;

        //niepoprawne w tej wersji języka
        /*public static virtual bool operator ==(IKoło L, IKoło P)
            => L.Promień == P.Promień;*/
    }
}
