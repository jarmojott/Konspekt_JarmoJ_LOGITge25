internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Sisesta oma vanus: ");
        //int kasutajaVanus = int.Parse(Console.ReadLine());

        //Console.Write("Sisesta oma vanaisa vanus: ");
        //int kasutajaVanaisaVanus = int.Parse(Console.ReadLine());

        //int VanusteVahe = Math.Abs(kasutajaVanaisaVanus - kasutajaVanus);
        //Console.WriteLine("Vanuste vahe " + (kasutajaVanaisaVanus - kasutajaVanus));

        //Console.Write("Kui palju sa oled vanem nüüd: ");
        //kasutajaVanus += int.Parse(Console.ReadLine());
        //Console.WriteLine("Vanuste vahe on nüüd " + (kasutajaVanaisaVanus - kasutajaVanus));


        // # OMISTUSOPERATOORID #

        // = tüüpiline väärtuse omistamine
        int muutuja = 1;
        // += liida juurde uus väärtus ja siis omista
        muutuja += 1;
        // -=  lahuta maha uus väärtus ja siis omista
        muutuja -= 1;
        // *= korruta uue väärtusega ja siis omista
        muutuja *= 2;
        // /= jaga uue väärtusega ja siis omista
        muutuja /= 2;
        // %= leia jagamise jääk ja siis omista
        muutuja %= 2;
        // ++ lisa juurde täpselt 1 ja siis omista
        muutuja++;
        // -- lahuta maha täpselt 1 ja siis omista
        muutuja--;

        //Console.Write("Kui kaugele oli su viimane kuulitõuge (komakohaga meetrites): ");
        //float kaugus = float.Parse(Console.ReadLine());
        //if (kaugus <= 1 && kaugus >= 0)
        //{
        //    Console.WriteLine("Sa suudad kindlasti rohkem");
        //}
        //else if (kaugus <= 2 && kaugus > 1)
        //{
        //    Console.WriteLine("Noh tuleb juba, aga jõuad veel");
        //}
        //else if (kaugus <= 3 && kaugus > 2)
        //{
        //    Console.WriteLine("Tubli oled!");
        //}
        //else if (kaugus < 0)
        //{
        //    Console.WriteLine("Kas viskasid vales suunas?");
        //}
        //else
        //{
        //    Console.WriteLine("Ohoh, kas luiskad ka?");
        //}

        // ### VÕRDLUSOPERAATORID (2 erineva väärtuse võrdlemine) ###

        // == on võrdne ehk mõlemad peavad olema täpselt sama väärtusega
        // > on suurem ehk esimene väärtus peab olema suurem kui teine väärtus
        // < on väiksem ehk esimene väärtus peab olema väiksem kui teine väärtus
        // >= on suurem või võrdne ehk esimene väärtus peab olema suurem või võrdne teise väärtusega
        // <= on väiksem või võrdne ehk esimene väärtus peab olema väiksem või võrdne teise väärtusega
        // != mitte võrdne ehk mõlemad väärtused peavad olema erinevad

        // ### LOOGILISED TEHTED ###

        // &&  "AND" tehe mis on tõene ainult kui mõlemad pooled on ka tõesed.
        // || "OR" tehe mis on tõene kui vähemalt 1 pool on tõene
        // ! "NOT" tehe mis on tõene kui antud väärtus on väär

        // ### TINGIMUSLAUSE ###
        if (true) { } /*Tingimuslause "if" alustab tingimuslauset mille tingimus on sellele järgnevate sulgude sees.
                   Selle järgneb blokk loogeliste sulgude sees mis täidetakse ainult siis kui tingimus on tõene.   
        */
        else if (true) { } /*Tingimuslause "else if" saab järgneda ainult eelevale "if" lausele, ning mille tingimus on sellele järgnevate sulgude sees.
                Selle järgneb blokk loogeliste sulgude sees, mis täidetakse ainult siis, 
                kui eelnevate if lausete tingimused oli väärad ning hetke tingimus osutub tõeseks.  */
        else { } /*Tingimuslause "else" saab järgeneda ainult kas "if" või "else if" lausele ning millele järgneb loogeliste sulgude blokk,
                  mis täidetakse ainult siis kui kõik eelnevad tingimused on olnud väärad. */

        Console.Write("Palun sisesta oma vanus: ");
        int isikuVanus = 0;
        isikuVanus = int.Parse(Console.ReadLine());

        if (isikuVanus <= 0)
        {
            Console.WriteLine("Aja rändureid me ei teeninda");
        }
        else if (isikuVanus > 0 && isikuVanus < 18)
        {
            Console.Write("Palun sisesta oma nimi: ");
            string nimi = "";
            nimi = Console.ReadLine();
            Console.WriteLine($"Kallis {nimi}, palun kutsu siia oma lapsevanem.");
        }
        else
        {
            Console.Write("Palun kirjuta oma eesnimi: ");
            string eesNimi = String.Empty;
            eesNimi = Console.ReadLine();

            Console.Write("Palun kirjuta oma eesnimi: ");
            string pereNimi = String.Empty;
            pereNimi = Console.ReadLine();

            if (eesNimi == "" || pereNimi == "")
            {
                Console.WriteLine("Sisetama pidi mõlemad nimed!");
            }
            else
            {
                Console.WriteLine($"Tere päevast {eesNimi} {pereNimi}!");
            }
        }
    }
}