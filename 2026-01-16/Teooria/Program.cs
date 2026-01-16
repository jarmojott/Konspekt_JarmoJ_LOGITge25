using System; /*enne nimeruumi, viidatakse selles klassis kasutatud teekidele ja muudele komponentidele,
milleks võib olla ka teised projektid mida haldab solution (.sln) fail*/
namespace Teooria   //nimeruum, sisaldab {} vahel konteinerit kus asub kogu kood
{
    internal class Program  //programmi klass, mis on omakorda konteiner tüüpi kus asub kogu kood
    {
        static void Main(string[] args) // on klassi peamine meetod mis käivitatakse alati esimesena
        {
            // <-SÜNTAKS->
            //Console.WriteLine("Ommik!");
            //string vastus = Console.ReadLine();
            //Console.WriteLine("=)");
            // ';'      - iga koodirida peab lõppema selle lauselõpumärgiga.
            // Console  - on C# käsurea adresseerimine teek millega saab erinevad operatsioone teha.
            // '.'      - kasutakse adresseerimiseks eelnevast klassist mingit meetodit.
            // 'WriteLine' - meetod mida soovime kasutada mis trükib terminali teksti.
            // '()'     - sulupaar mis defineerib meetodi ning kuhu sisse käivad meetodi parameetrid
            // '{}'     - tähistab koodiplokki konteineri sees
            // '[]'     - tähistab massiivi ning võimaldab seda indekseerida.
            // ""       - jutumärgid tähistad string ehk tekst tüüpi väärtust mis asub jutumärkide vahel
            // 'string' - tekstipõhine andmeetüüp mis eelneb muutuja nimele. Samuti võib andemetüüp sisalda ka funktsioone. EST: sõne
            // 'vastus' - muutuja definitsioon koos tema nimega kuhu omistatakse väärtus omistusoperaatoriga =
            // 'ReadLine' - meetod mis loeb käsurealt sisse väärtusse string andmetüübina.
            // '//'       - tähistab 1 realist kommentaari koodis
            // '/* */'    - tähistab mitmerealist kommentaari koodis
            // '///'    - Meetodi kirjelduse kommentaar mille kuvab välja ka IDE ehk koodiredaktor
            // <taane>  - aitab koodi kirjutamisel/lugemisel mõista kus bloki sees mingi element asub (koodi treppimine).

            // <--MUUTUJAD-->
            string naidis = ""; /* muutuja defineerimine algab alati andmetüübist millele järgneb muutuja nimi teksti kujul (kohustuslik osa)
                                 * Peale definitsiooni saab soovi korral ka kohe omistada sellele väärtuse kasutades omistusoperaatori.
                                 * Lause lõppeb nagu alati semikooloniga (;)
                                 */

            // <--CASTIMISEE NÄIDE-->
            int minuArv = 9001;
            Console.WriteLine(minuArv);
            double minuDouble = minuArv;
            Console.WriteLine(minuDouble);

            double uusDouble = 6.7;
            Console.WriteLine(uusDouble);
            int uusInt = (int)uusDouble; //castimine kus on mingi andmekadu
            Console.WriteLine(uusInt);

            double newDouble = 1.23d;
            float newFloat = (float)newDouble;

            long newLong = (long)newFloat;
            int newInt = (int)newLong;
            char newChar = (char)newInt;

            int backToInt = newChar; // castimine kus pole andmekadu
            long backToLong = backToInt;
            float backToFloat = backToLong;
            double backToDouble = backToLong;

            //TEISENDAMINE
            /* Castmine on arvu teisendamine ühest andmetüübist teise:
             * Automaatne (implicit) - kui toimub väiksemast andmetüübist suuremasse ning andmekadu pole
             * Manuaalne (explicit)  - kui toimub suuremast andetüübist väiksemasse ning on võimalik andmekadu kus on vaja kasutada suurema andmetüübi ees sulgude sees olevat uut andmetüüpi
             * EXPLICIT:
             * double uusDouble = 6.7;
             * int uusInt = (int)uusDouble; - castimine kus on võimalik andmekadu
             * IMPILICIT
             * int minuArv = 9001;
             * double minuDouble = minuArv - castimine kus pole andmekadu
             */
        }
    }
}
