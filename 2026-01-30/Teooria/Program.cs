internal class Program
{
    static void Main(string[] args)
    {
        /* <-- TSÜKLID (WHILE) -->
         *  WHILE tsükkel on kõige tavalisem tsükkel ning tema tingimuskontroll on tsükli alguses ehk ilma tingimust täitmata ei käivitu üldse tsükkel.
         *  Tsükkel algab kaitstud sõnaga 'while', millele järgneb sulgude vahel olev tingimusekontroll.
         *  Seal asetseb tavaliselt tsüklimuutuja, mille tõene ehk 'true' väärtus käivitab alati uue iteratsiooni tsüklis.
         *  Tsükli jooksul täidetav tegevus asub koodiblokis {}
         */
        //string tsükliMuutuja = "";
        //while (tsükliMuutuja != "0")
        //{
        //    Console.Write("Esita tekst: ");
        //    tsükliMuutuja = Console.ReadLine();
        //}

        /* <-- TSÜKLID (FOR) -->
         * For tsükkel omab endas tsükli töö jaoks erinevalt teistest tsükli tüüpidest, nii lokaalset tsüklimuutujat, tingimust ning ka selle muutmist.
         * Tsükkel algab alati kaitstud sõnaga 'for, millele järgnevad sulgude sees olev kõik vajalik tsükli töö jaoks (parameetrid - 3).
         * Esimene parameeter tekitab uue kohaliku muutuja (tsükliMuutuja) mida ei eksisteeri väljaspool tsüklit.
         * Teine parameeter on tingimuskontroll mille tõese väärtuse puhul jätkub või algab tsükli töö.
         * Kolmas parameeter on tsüklimuutuja muutmine mis tavaliselt on kas suurendamine või vähendamine 1 võrra.
         * Parameetrid on eraldatud lauselõpu märgiga ';' (mitte komaga!), sest nad on täielikud koodilaused mitte muutujad või lihtväärtused.
         * Sulgude järele järgneb koodiblokk mille sisse käib tsükli töö.
         */
        //int[] arvuMassiiv = new int[5];
        //for (int i = 0; i < arvuMassiiv.Length; i++)
        //{
        //    Console.Write("Sisesta " + i + 1 + ". arv: ");
        //    arvuMassiiv[i] = int.Parse(Console.ReadLine());
        //}

        /* <-- KOMPOSIITANDMETÜÜBID -->
         * 
         *  1. MASSIIV []
         *  Massiiv on komposiitandmetüüp, mille sees saab olla sama tüüpi lihtandmeid.
         *  Massiiv defineeritakse '[]' abil. Selle käigus defineeritakse ära nii andmetüüp kui ka massiivi pikkus.
         *  On võimalik kasutada andmetüübina ka komposiitandmetüüpe nagu massiiv ise. Sellisel juhul räägime juba mitmedimensioonilisest masiividest (2D jne).
         *  Massiivi saab luua nii tühja kui täidetud kujul. Kaitstud sõna 'new' kasutamisel saab luua tühja massiivi. 
         *  Eeltäidetud massiivi puhul anname '{}' või [] kaudu parameetritena kaasa väärtused, ning massiivi pikkus määratakse siis automatseelt. 
         */

        int[] massiiv1 = new int[5];
        int[] massiiv2 = [1, 2, 3, 4, 5];
        int[] massiiv3 = { 1, 2, 3, 4, 5 };

        /* <-- MASSIIVISISESED MEETODID -->
         * Meetod 'Lenght' tagastab meile massiivi pikkuse mille väärtus on alati täisarv.
         */
        int kuiPaljuOn = new int[2] { 1, 2 }.Length;

        //NÄIDIS 9: Sünoptik

        Console.WriteLine("Tere sünoptik!");
        float[] temperatuurid = new float[5];
        string[] kirjeldused = new string[5];
        for (int i = 0; i < kirjeldused.Length; i++)
        {
            Console.Write("Esita palun " + (i + 1) + ". päeva temperatuur: ");
            temperatuurid[i] = float.Parse(Console.ReadLine());

            Console.Write("Kirjelda palun ka seda päeva: ");
            kirjeldused[i] = Console.ReadLine();
        }

        Console.WriteLine("5 päeva ennustus: ");
        for (int i = 0;i < temperatuurid.Length; i++)
        {
            Console.WriteLine(i+1+". päeval on temperatuur " + temperatuurid[i] +" ja ilma kirjeldus on " + kirjeldused[i]+".");
        }
    }
}

