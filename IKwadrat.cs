using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_2_1_z5
{
    internal interface IKwadrat : IProstokąt, IRomb
    {
        protected readonly static double PierwiastekZ2 = Sqrt(2);
        protected static double ObliczŚrednica(IKwadrat kwadrat)
            => kwadrat.Bok * PierwiastekZ2;
        protected static string ZwróćInfo(IKwadrat kwadrat) =>
            $"Kwadrat o boku {kwadrat.Bok}\n" +
            $"\tObwód {kwadrat.Obwód}\n" +
            $"\tPole {kwadrat.Pole}\n" +
            $"\tŚrednica (przekątna) {kwadrat.Średnica}"
            ;
    }
}
