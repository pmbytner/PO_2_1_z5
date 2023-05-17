namespace PO_2_1_z5
{
    internal interface IRomb : IFigura
    {
        double Bok { get; set; }
        double Kąt { get; set; }

        protected static double ObliczObwód(IRomb romb)
            => 4 * romb.Bok;
        protected static double ObliczPole(IRomb romb)
            => romb.Bok * romb.Bok * Sin(romb.Kąt);
        protected static double ObliczŚrednica(IRomb romb)
            => 2 * romb.Bok * Cos(romb.Kąt / 2);

        protected static string ZwróćInfo(IRomb romb) =>
            $"Romb o boku {romb.Bok} i kącie ostrym {romb.Kąt}\n" +
            $"\tObwód {romb.Obwód}\n" +
            $"\tPole {romb.Pole}\n" +
            $"\tŚrednica (przekątna) {romb.Średnica}"
            ;
    }
}