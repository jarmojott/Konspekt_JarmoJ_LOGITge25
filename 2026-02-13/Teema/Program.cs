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

    }
}

