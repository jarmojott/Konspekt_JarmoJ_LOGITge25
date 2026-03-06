internal class Program
{
    static void Main(string[] args)
    {
        /*
         * <<< FAILIOPERATSIOONID >>>
         * 
         * Kui programmil on vaja lugeda või salvestada andmed mis ei tule kasutajalt ega programmist endast, siis saab teha seda faili abil.
         * Selleks on vaja eraldi teeki: System.IO
         * 
         * << FAILI LUGEMINE >>
         * File.ReadAllText() - Loeb etteantud failist kogu sisu sõne andmetüübina sisse.
         * File.ReadAllLines() - Loeb etteantud failist kogu sisu sõne massiivina sisse kus iga rida on eraldi element.
         * File.ReadAllBytes() - Loeb etteantud failist kogu sisu baitidena sisse byte massiivina ehk ilma teisenduseta.
         * 
         * << FAILI KIRJUTAMINE >>
         * File.WriteAllText() kirjutab etteantud asukohta faili sisse antud teksti.
         * File.WriteAllLines kirjutab etteantud asukohta faili sisse sõne tüüpi massiivi sisu.
         * File.WriteAllBytes kirjutab etteantud asukohta faili sisse byte tüüpi massiivi sisu.
         * 
         * Kõik kirjutus meetodid kirjutavad faili üle kui see on eksisteerib varasemalt.
         * 
         * << MUUD >>
         * File.Exists() kontrollib kas etteantud asukohas eksisteerib mingi fail ja tagastab tõeväärtuse.
         * File.Create() loob uue faili etteantud asukohta ning eksisteeriv faili kirjutakse üle.
         * File.Copy() uue koopia loomine failist.
         * File.Replace() asendamine koos originaalist varukoopia tegemisega
         * File.AppendAllText() lisab olemasolevale failile juurde etteantud sisu või loob uue kui see ei eksisteeri
         */

        string loetudFailSisu1 = File.ReadAllText("failinimi.txt");
        string[] loetudFailSisu2 = File.ReadAllLines("failinimi.txt");
        byte[] loetudFailiSisu3 = File.ReadAllBytes("failinimi.txt");

        File.WriteAllText("väljund1.txt", "suvatekst");
        File.WriteAllLines("väljund2.txt", loetudFailSisu2);
        File.WriteAllBytes("väljund3.txt", loetudFailiSisu3);

        File.Exists("failinimi.txt");

        File.Create("failinimi.txt");
        File.Delete("failinimi.txt");

        File.Copy("/failinimi.txt", "/failinimiKOOPIA.txt");

        File.Copy("/failinimi.txt", "/failinimiKOOPIA.txt", false);

        File.Replace("väljund.txt", "/sihtfail.txt", "/sihtFAILBACKUP");

        File.AppendAllText("väljund.txt", "uus sisu");
    }
}
