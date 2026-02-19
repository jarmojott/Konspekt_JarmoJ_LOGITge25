using System.Runtime.CompilerServices;

internal class Program
{
    static void Main(string[] args)
    {
        /* 
         * <-- SÕNE TÖÖRIISTAD -->
         * Teksti andmete manipuleerimise tööriistad mis kas muudavad või kontrollivad sõne väärtust.
         * Nendega saab tihtipeale vorminda sõne väärtust endale sobivaks enne järgmisi operatsioone.
         * 
         * Length tagastab selle sõne pikkuse kuna sõne asub arhitektuuriliselt massiivi sees.
         * ToUpper() meetod is muudab kõik sõne sümbolid suurtähtedeks.
         * ToLower() meetod is muudab kõik sõne sümbolid väiketähtedeks.
         * Contains() tagastab bool väärtuse sõltuvalt kas otsivat esineb objektis.
         * StartsWith() tagastab booli sõtuval kas sõne algab otsitava parameeteriga
         * EndsWith() tagastab booli sõtuval kas sõne algab otsitava parameeteriga
         * Trim() eemaldab sõnest algusest ja lõpust tühjad sümbold ehk tühikud, ning ka reavahed.
         * Split() tükeldab sõne massiiviks ette antud sõne või karakteri parameetri põhjal.
         * Join() liidab sõned kokku üheks sõneks kasutades parameetrina eraldajat.
         * Concat() on meetod millega saab mitu sõne ühendada üheks sõneks.
         * $ sõne väärtuse ees lubab kasutada muutujaid sõne väärtuses loogeliste sulgude vahel ehk formateeritud sõne.
         * \n reavahetus sõne väärtuses.
         * \ on niiöelda ignoreeri sümbol millega saab järgnevat 1 sümboli näiteks \ või " kasutada väärtusena sõnes.
         * \t lisab sõne väärtuse TAB käskluse.
         * \b backspace ehk eelneva sümboli kustutamine ainult siis kui ta on keset sõne.
         * PadLeft() ja PadRight() lisavad sõnast kas vasakule või paremale poole sõnest tühimikke vastavalt parameetri väärtuse jagu (aga mitte rohkem kui sõne pikkus ise)
         * IndexOf() sarnanselt massiivile saab ka sõne väärtuse teada etteantud parameetri indeksit ehk asukohta.
         * """ vormindusega sõne algus ja lõpp
         */
        string minuLause = "  Täna jõin terve ploki monsterit   ";
        Console.WriteLine(minuLause.Length);
        Console.WriteLine(minuLause.ToUpper());
        Console.WriteLine(minuLause.Trim());

        string tuvastus = "Kas lauses on sõna 'monsterit'?: " + minuLause.ToLower().Contains("monsterit");
        Console.WriteLine(tuvastus);

        bool tuvastus2 = minuLause.StartsWith("täna");
        bool tuvastus3 = minuLause.EndsWith("magada");
        Console.WriteLine(tuvastus2 + " " + tuvastus3);

        string[] lauseOsad = minuLause.Split(' ');
        foreach (var osa in lauseOsad)
        {
            Console.WriteLine(osa);
        }

        bool isBig = false;
        for (int i = 0; i < lauseOsad.Length; i++)
        {
            if (isBig)
            {
                lauseOsad[i] = lauseOsad[i].ToUpper();
            }
            else
            {
                lauseOsad[i] = lauseOsad[i].ToLower();
            }
            isBig = !isBig;
        }
        string töödeldudLAuse = string.Join(" ", lauseOsad);
        Console.WriteLine(töödeldudLAuse);

        List<String> menüü = new List<string>() { "kilu", "vastal", "hernes" };
        string väljundLause = "Need on meie menüüs";
        foreach (var söök in menüü)
        {
            väljundLause += " " + söök + ",";
        }
        Console.WriteLine(väljundLause);

        string eesNimi = "Julius";
        string perekonnaNimi = "Caesar";
        string amet = "Noahoidik";
        string kuulusKeiser = string.Concat(eesNimi, perekonnaNimi, amet);
        Console.WriteLine(kuulusKeiser);

        String kuukusKeiser2 = $"{eesNimi} {perekonnaNimi} oli maailma kuulsaim {amet}";
        Console.WriteLine(kuukusKeiser2);

        Console.WriteLine("A\nB");
        Console.WriteLine("\\n");
        Console.WriteLine("\"");
        Console.WriteLine("A\tB");
        Console.WriteLine("ABCD\bA");
        Console.WriteLine("|" + amet.PadLeft(30) + "|");
        Console.WriteLine("|" + amet.PadRight(30) + "|");

        //sõne käitub kui massiiv sümbolitest siis saame kasutada ka tüüpilisi massiivi operatsioon.
        foreach (var täht in perekonnaNimi)
        {
            Console.Write(täht + " ");
        }
        Console.WriteLine("\n"+perekonnaNimi.IndexOf("r"));

        Console.WriteLine("""
              1
                 2
            3
            """);


        /*
         * <-- ARRAY -->
         * IndexOf() tagastab indeksi arvuväärtusena, -1 või 0 sõltuvalt kas etteantud parameeter eksisteerib massiivis või mitte. 
         */
        Array.IndexOf(lauseOsad, 1);
    }
}
