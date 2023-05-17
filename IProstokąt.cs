namespace PO_2_1_z5
{
    internal interface IProstokąt : IFigura
    {
        double BokA { get; set; }
        double BokB { get; set; }

        protected static double ObliczObwód(IProstokąt prostokąt)
            => 2 * (prostokąt.BokA + prostokąt.BokB);
        protected static double ObliczPole(IProstokąt prostokąt)
            => prostokąt.BokA * prostokąt.BokB;
        protected static double ObliczŚrednica(IProstokąt prostokąt)
            => Sqrt(
                prostokąt.BokA * prostokąt.BokA
                + prostokąt.BokB * prostokąt.BokB
                );

        protected static string ZwróćInfo(IProstokąt prostokąt) =>
            $"Prostokąt {prostokąt.BokA}x{prostokąt.BokB}\n" +
            $"\tObwód {prostokąt.Obwód}\n" +
            $"\tPole {prostokąt.Pole}\n" +
            $"\tŚrednica (przekątna) {prostokąt.Średnica}"
            ;
    }
}