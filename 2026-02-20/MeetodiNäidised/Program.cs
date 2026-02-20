internal class Program
{
    static void Main(string[] args)
    {
        ///* näiteülesanne 7.1 - asenda switchcase if-elseif-elseiga*/
        //Console.WriteLine("Palun sisesta esimene arv");
        //float arv1 = 0.0f;
        //arv1 = float.Parse(Console.ReadLine());

        //Console.WriteLine("Palun sisesta teine arv");
        //float arv2 = 0.0f;
        //arv2 = float.Parse(Console.ReadLine());

        //Console.WriteLine("Mis tüüpi tehet sa teha tahad? (valik: + - * / ^ V)");
        //string tehteTüüp = "";
        //tehteTüüp = Console.ReadLine();

        //double tehteTulemus = 0.0d;

        //if (tehteTüüp != "")
        //{
        //    switch (tehteTüüp)
        //    {
        //        default:
        //            Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
        //            return;
        //        case "+":
        //            tehteTulemus = liitmine(arv1, arv2);
        //            break;
        //        case "-":
        //            tehteTulemus = lahutamine(arv1, arv2);
        //            break;
        //        case "/":
        //            tehteTulemus = jagamine(arv1, arv2);
        //            break;
        //        case "*":
        //            tehteTulemus = korrutamine(arv1, arv2);
        //            break;
        //        case "^":
        //            tehteTulemus = astendamine(arv1, arv2);
        //            break;
        //        case "V":
        //            tehteTulemus = juurimine(arv1, arv2);
        //            break;
        //    }
        //    Console.WriteLine($"Tehte tulemus on: {arv1} {tehteTüüp} {arv2} = {tehteTulemus}");
        //}
        //else
        //{
        //    Console.WriteLine("Tehtetüüp pole valitud, tehet ei sooritata.");
        //}

        //Console.WriteLine("Sisesta oma nimi: ");
        //string kasutajaNimi = getAnswer();
        //Console.WriteLine("Tere " + kasutajaNimi);
        //Console.WriteLine("Palun sisesta ka oma tänavanimi: ");
        //string tänavaNimi = getAnswer();
        //Console.WriteLine(kasutajaNimi + " ahha! elad " + tänavaNimi);

        sisestaOmaVanus("Sisetage Teie vanus: ");
    }

    private static void sisestaOmaVanus(string tekst = "Siseta oma vanus: ")
    {
        int vanus = 0;
        do
        {
            Console.Write(tekst);
            vanus = int.Parse(Console.ReadLine());
        }
        while (vanus <= 0);

        if (vanus >= 65)
            Console.WriteLine("Kuidas jalad liiguvad? hästi?");
        else
            Console.WriteLine("Mitu monsterit päevas jood?");
    }

    //private static string getAnswer()
    //{
    //    string input = String.Empty;
    //    do
    //    {
    //        Console.Write("Sisestus: ");
    //        input = Console.ReadLine();
    //    }
    //    while (String.IsNullOrEmpty(input));
    //    return input;
    //}

    //private static double juurimine(float arv1, float arv2)
    //{
    //    return Math.Pow(arv1, (1 / arv2));
    //}

    //private static double astendamine(float arv1, float arv2)
    //{
    //    return Math.Pow(arv1, arv2);
    //}

    //private static double korrutamine(float arv1, float arv2)
    //{
    //    return arv1 * arv2;
    //}

    //private static double jagamine(float arv1, float arv2)
    //{
    //    return arv1 / arv2;
    //}

    //private static double lahutamine(float arv1, float arv2)
    //{
    //    return arv1 - arv2;
    //}

    //private static double liitmine(float arv1, float arv2)
    //{
    //    return arv1 + arv2;
    //}
}
