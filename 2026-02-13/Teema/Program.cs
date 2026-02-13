internal class Program
{
    static void Main(string[] args)
    {
        /* 
         * <--- JUHUVÄÄRTUS --->
         * Random klass annab meile võimaluse genereerida juhuväärtusi.
         * Random klassi saab määrata kui muutuja kui objekti tüüpi andmetüüp.
         * new Random() käivitab konstrukturi ja loob meiele uue objekti.
         * See aga ei ole veel juhuväärtus. Selle meetodite abil saab luua erinevaid juhuväärtusi soovitud andmetüübina.
         * Next() on meetod mis tagastab meile juhuväärtuse juba kindlas andmetüübis.
         * Samuti on võimalik kaasa anda erinevaid parameetried mis piiravad genereeritavat juhu väärtust.
         * (X) parameeter määrab ära ülemväärtuse ning alamväärtus on automaaselt 0 ehk juhuarvu.
         * (X,X) parameeter määrab ära nii alam kui ülemväärtuse ehk vahemiku (lubatud ka negatiivsed väärtused).
         * NextDouble() määratleb juba ära tagastava andmetüübi kui double.
         * NextSingle() määratleb andmetüübi kui float vahemikus 0,0 ja 1,0
         */

        Random juhuObjekt = new Random();
        int juhuArv = juhuObjekt.Next();
        juhuArv = juhuObjekt.Next(5);
        juhuArv = juhuObjekt.Next(-5, 5);
        double kaheKomaga = juhuObjekt.NextDouble();
        float üheKomaga  = juhuObjekt.NextSingle();


        /*
         * ### KOMPOSIITANDMETÜÜBID ###
         * 1. Massiiv
         * 2. Loend
         * 2. Sõnastik
         * 3. Tuple
         * 
         * <-- SÕNASTIK -->
         * Dictionary on komposiitandmetüüp mis omab võti/väärtus paare.
         * Erinevalt teistest komposiitandmetüüpidest saab Dictionary omada 2 erinevat või sama andmetüüpi väärtust mis sümboliseerivadki võtit ning tema väärtust.
         * Samuti võib andmetüübiks olla ka klass.
         * Andmetüüp Dictionary näitab ära sõnastiku klassi, selle järel noolsulgude sees on 2 andmetüüpi: esimene on võti, ja teine tema väärtus.
         * new käsusõna käivitab konstruktori mis loob uue tühja sõnastiku vastavate andmetüüpidega noolsulgude vahel.
         * Võimalik on uus sõnastik ka kohe algväärtustada andmetega kasutades topelt loogelisi sulge {{}}
         * 
         * <-- SÕNASTIKU TÖÖRIISTAD -->
         * Meetod add() võimaldab lisada sõnastikku lõppu uue paari andes kaasa parameetridena sulgude sees võtmepaari väärtused.
         * Meetod Remove() võimaldab eemalda ühe võtmepaari kasutades parameetrina võtme väärtust.
         * Meetod Clear() eemaldab kõik võtmepaarid sõnastikust.
         * Meetod ContainsKey() kontrollib kas sõnastikus eksisteerib vastav võti ning tagastab meile tulemuse bool'ina.
         * Meetod ContainsValue() kontrollib kas sõnastikus eksisteerib vastav väärtus ning tagastab meile tulemuse bool'ina.
         */
        Dictionary<int, string> sõnastik1 = new Dictionary<int, string>();
        Dictionary<int, string> sõnastik2 = new Dictionary<int, string>() { {1, "essa" }, {2, "tessa" }, { 3, "kossa" } };
        ;
        Dictionary<List<int>, string> sõnastik3 = new Dictionary<List<int>, string>();
        sõnastik2.Add(4, "tikker");
        sõnastik2.Remove(4);
        sõnastik2.Clear();
        sõnastik1.ContainsKey(4);
        sõnastik1.ContainsValue("uus");


    }
}

