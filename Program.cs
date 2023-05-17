global using static System.Math;
using PO_2_1_z5;
using static System.Console;

P11();

void P11()
{
    SortedSet<Koło> koła = new()
    {
        new Koło() { Promień = 1 },
        new Koło() { Promień = 3 },
        new Koło() { Promień = 1 },
        new Koło() { Promień = 2 },
    };
    foreach (Koło koło in koła)
        WriteLine(koło);
}
void P10()
{
    Koło
        k = new Koło() { Promień = 1 }
        ;
    //zbiór (i podobne kolekcje) korzystają z funkcji skrótu,
    //a nie operatora/funkcji równości
    HashSet<Koło> koła = new HashSet<Koło>()
    {
        new Koło() { Promień = 1 },
        new Koło() { Promień = 2 },
        new Koło() { Promień = 1 },
        //k
    };

    WriteLine(
        koła.Contains(k) //normalnie zwróci false,
                         //jeśli w zbiorze nie ma dokładnie tej instancji
        );
    foreach (Koło koło in koła)
        WriteLine(koło);
}

void P9()
{
    //przeciążenie metody Equals
    //coś jest schrzanione
    Koło
        k1 = new Koło() { Promień = 1 },
        k2 = new Koło() { Promień = 2 },
        k3 = new Koło() { Promień = 1 },
        k4 = k1
        ;

    WriteLine($"{k1} == {k2}? {k1.Equals(k2)}");
    WriteLine($"{k1} == {k3}? {k1.Equals(k3)}");
    WriteLine($"{k1} == {k4}? {k1.Equals(k4)}");
    WriteLine($"{k2} == {k3}? {k2.Equals(k3)}");
    WriteLine($"{k2} == {k4}? {k2.Equals(k4)}");
    WriteLine($"{k4} == {k4}? {k3.Equals(k4)}");
}
void P8()
{
    //na typie Koło możemy zdefiniować operator porównania
    Koło
        k1 = new Koło() { Promień = 1 },
        k2 = new Koło() { Promień = 2 },
        k3 = new Koło() { Promień = 1 },
        k4 = k1
        ;
    //k1 i k3 są takie same, ale nie te same
    //k1 i k4 są tymi samymi instancjami

    WriteLine($"{k1} == {k2}? {k1 == k2}");
    WriteLine($"{k1} == {k3}? {k1 == k3}");
    WriteLine($"{k1} == {k4}? {k1 == k4}");
    WriteLine($"{k2} == {k3}? {k2 == k3}");
    WriteLine($"{k2} == {k4}? {k2 == k4}");
    WriteLine($"{k4} == {k4}? {k3 == k4}");
}
void P7()
{
    //na interfejsach w tej wersji języka nie możemy deklarować operatorów
    IKoło
        k1 = new Koło() { Promień = 1 },
        k2 = new Koło() { Promień = 2 },
        k3 = new Koło() { Promień = 1 },
        k4 = k1
        ;
    //k1 i k3 są takie same, ale nie te same
    //k1 i k4 są tymi samymi instancjami

    WriteLine($"{k1} == {k2}? {k1 == k2}");
    WriteLine($"{k1} == {k3}? {k1 == k3}");
    WriteLine($"{k1} == {k4}? {k1 == k4}");
    WriteLine($"{k2} == {k3}? {k2 == k3}");
    WriteLine($"{k2} == {k4}? {k2 == k4}");
    WriteLine($"{k4} == {k4}? {k3 == k4}");
}
//interfejsy własne, związane z konkretnym klasami
//pozwalające zdefiniować bardziej rozbudowaną i elastyczną strukturę typów
void P6()
{
    IEnumerable<IFigura> figury = new HashSet<IFigura>()
    {
        new Koło() { Promień = 1},
        new Prostokąt() { BokA = 3, BokB = 4 },
        new Kwadrat() { Bok = 1 },
        new Romb() { Bok = 2, Kąt = PI / 4 },
    };
    foreach (IFigura f in figury)
        WriteLine(f.Info);
}
void P5()
{
    Koło k1 = new Koło() { Promień = 1};
    IKoło k2 = new Koło() { Promień = 1};

    //dzięki nowej implementacji za pośrednictwem składowych statycznych
    //nie mamy problemów z odwołaniami do właściwości
    WriteLine(k1.Info);
    WriteLine(k2.Info);
}

void P4()
{
    IProstokąt[] prostokąty = new IProstokąt[]
    //typem komórek dalej musi być typ IProstokąt
    //ze względu na problem z "zepsutą" kowariancją tablic
    //powinniśmy raczej użyć automatycznego inicjalizatora tablicy
    {
        new Prostokąt() { BokA = 3, BokB = 4 },
        new Kwadrat() { Bok = 1 }
    };

    IRomb[] romby =
    {
        new Romb() { Bok = 1, Kąt = PI / 4 },
        new Kwadrat() { Bok = 2 }
    };

    WriteLine("Prostokąt:");
    foreach (IProstokąt prostokąt in prostokąty)
        WriteLine(prostokąt.Info);
    WriteLine(
        "----\n" +
        "Romby:"
        );
    foreach (IRomb romb in romby)
        WriteLine(romb.Info);
}
void P3()
{
    //jeśli stosujemy referencje typu klasy, to nie widzimy struktury
    //typów określonej przez interfejsy
    Prostokąt[] prostokąty =
    {
        new Prostokąt() { BokA = 3, BokB = 4 },
        //new Kwadrat { Bok = 2 } //błąd kompilacji
        //klasa Kwadrat nie jest pochodną klasy Prostokąt
    };
    Romb[] romby =
    {
        new Romb() { },
        //new Kwadrat() //błąd kompilacji
        //klasa Kwadrat nie jest pochodną klasy Romb
    };
}
void P2()
{
    IFigura[] figury =
    {
        //new(),//interfejs
        new Prostokąt() { BokA = 3, BokB = 4 },
        new Romb() { Bok = 1, Kąt = PI / 3 },
        new Romb() { Bok = 2, Kąt = PI / 4 },
        new Kwadrat { Bok = 2 }
    };
    double sumaPól = 0;
    foreach (IFigura f in figury)
        sumaPól += f.Pole;
    WriteLine(sumaPól);
}

void P1()
{
    //jeśli nie mamy wspólnego typu, który deklarowałby daną składową
    //to musimy się posługiwać mechanizmem refleksji
    object[] figury =
    {
        new Prostokąt() { BokA = 3, BokB = 4 },
        new Romb() { Bok = 1, Kąt = PI / 3 }
    };

    double sumaPól = 0;
    foreach (object figura in figury)
        if(figura is Prostokąt)
            sumaPól += ((Prostokąt)figura).Pole;
        else if(figura is Romb)
            sumaPól += ((Romb)figura).Pole;

    WriteLine(sumaPól);
}

void P0()
{
    Prostokąt
        p = new() { BokA = 3, BokB = 4 };
    Romb
        r1 = new() { Bok = 1 },
        r2 = new() { Bok = 1, Kąt = PI / 3 }
        ;

    WriteLine(p.Info);
    WriteLine(r1.Info);
    WriteLine(r2.Info);
}