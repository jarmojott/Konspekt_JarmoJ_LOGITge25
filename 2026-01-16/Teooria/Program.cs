using System; /*enne nimeruumi, viidatakse selles klassis kasutatud teekidele ja muudele komponentidele,
milleks võib olla ka teised projektid mida haldab solution (.sln) fail*/
namespace Teooria   //nimeruum, sisaldab {} vahel konteinerit kus asub kogu kood
{
    internal class Program  //programmi klass, mis on omakorda konteiner tüüpi kus asub kogu kood
    {
        static void Main(string[] args) // on klassi peamine meetod mis käivitatakse alati esimesena
        {
            // <-SÜNTAKS->
            Console.WriteLine("Ommik!");
            string vastus = Console.ReadLine();
            Console.WriteLine("=)");
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
        }
    }
}
