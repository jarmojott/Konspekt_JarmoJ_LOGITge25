namespace TeemaStruct  //globaalne nimeruumi tunnus mis määrab ära skoobi.
{
    /* Klassi anatoomia
     * Klassi enda nimeruum mis sisaldab kõike mida klass vaja oma operatsioonideks mis koosneb:
     * juurdepääsu modifikaatorist, kaitstud sõna 'class', klassi nimi mis algab tüüpiliselt suure tähega.
     * Konstruktur defineerib ära kuidas klassi objekti saab luua mida võib olla mitu. Puudub vaikekonstruktor erinevalt structist.
     * Kui andmevälja andemtüübil on lõpus '?' siis on sinna lubatud ka null. Andmeväljal saab olla ka vaikeväärtus mis jääb kehtima kuniks seda ei kirjuta üle.
     * 
     * 
     */
    public class TeemaKlass
    {
        string Materjal { get; set; }
        string? Värvus { get; set; } //näiteks olen värvipime
        double Paksus { get; set; } = -1;

        public TeemaKlass(string värvus, string materjal, double paksus)
        {
            Materjal = materjal;
            Värvus = värvus;
            Paksus = paksus;
        }

        public TeemaKlass(string värvus, string materjal)
        {
            Materjal = materjal;
            Värvus = värvus;
        }

        /// <summary>
        /// Returns a sentence, containing onfo about this object 
        /// </summary>
        /// <returns>sentence</returns>
        public string GetInfo()
        {
            return $"This objekt is made of {Materjal}, and is {Paksus} thick and has {Värvus} color.";
        }


        /// <summary>
        /// Method that returns true when this material can be dremeled depending whether the thicknes is greater than Paksus or not
        /// </summary>
        /// <param name="freesiPaksus">Input your dremel length</param>
        /// <returns>true or false</returns>
        public bool canThisBeDremeled(double freesiPaksus)
        {
            if (freesiPaksus > Paksus)
                return false;
            else
                return true;
        }
    }
}
