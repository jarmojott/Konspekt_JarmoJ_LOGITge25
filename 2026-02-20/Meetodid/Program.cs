
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    /* 
     * <-- MEETODID -->
     * on väljakutsutavad koodijupid või alamprogrammid mis teostavad mingeid tegevusi mida on vaja taaskasutada.
     * Meetodeid on 2 liike: tagastusega ja ilma tagastuseta, mõlemal juhul saab läbi viia tegevusi.
     * 
     *  <<< MEETODI ANATOOMIA >>>
     *  Meetodi olemus sisaldab endas 3 vajalikku komponenti. Meetodi enda tüüp, parameetrid ning koodiblokk.
     *  Meetod luuakse signatuuriga kus on tema tüüp ja parameetrid () ning selle järgneb koodiblokk {}
     *  
     *  Signatuur: juurdepääsu modifikaator, tagastustüüp, meetodi enda nimi, parameetrid sulgude vahel.
     *  Millele järgneb koodiblokk.
     *  
     *  Juurdepääsu modifikaator määrab ära kust ja millal saab seda meetodit välja kutsuda:
     *  0. <defineerimata> - kompilaator määrab ise vaiketüübi
     *  1. public - avalik ja kätesaadav ka teistele klassidele.
     *  2. private - meetod on kättesaadav ainult oma enda klassis
     *  3. protected - meetod on kättesaadav kust ta asub ja kõikides pärinevates klassides
     *  4. internal - kättesaadav ainult oma enda projektis.
     *  
     *  1. static modifikaator võimalab meetodid kasutada ilma klassi objeki loomata ehk klassi spetsiifiline meetod.
     *  2. ilma static'uta meetodit saab väljakutsuda ainult koos objektiga.
     *   
     *  Tagastüübi modifikaator määrab kas ja mida meetod tagastab.
     *  1. void - ilma tagastuseta meetod
     *  2. <andmetüüp> - tagastusega meetod mis tagastab ALATI ettemääratud andmetüübiga väärtuse kasutades "return" käsklust koodibloki sees mis ALATI katkestab ka meetodi töö koodiblokis.
     *  
     *  <<< MEETODI NIMI >>>
     *  Meetodi nime kasutame meetodi välja kutsumiseks ning mis alati lõpeb sulgudega kuhu saab lisada parameetreid. Nime valimisel tuleb olla hoolikas et säilitada koodi arusaadavus.
     *  
     *  <<< MEETODI PARAMEETRID >>>
     *  Väljad kus defineeritakse andmed mida on vaja meetodi käivitamiseks.
     *  1. Meetod saab eksisteerida ilma ühegi parameetrita ehk ()
     *  2. Iga parameeter koosneb meetodi signatuuris alati andmetüübist ja muutuja nimest. Samuti saab olla parameetril ka algväärtus ehk seda ei pea siis väljakutsumisel määrama.
     */

    public static void meetod1()
    {
        Console.WriteLine("See on tagastuseta meetod");
    }

    public static string meetod2()
    {
        return "See on tagastusega meetod";
    }

    static void meetod3()
    {
        Console.WriteLine("Ilma juurdepääsu modifikaatorita ehk vaiketüübiga");
    }
    public static void meetod4()
    {
        Console.WriteLine("Koos juurdepääsu modifikaatoriga ehk vaiketüübiga");
    }

    public void meetod5()
    {
        Console.WriteLine("Mitte static ehk objekti spetsifiiline meetod");
    }

    public void meetod6(int arv)
    {
        Console.WriteLine("1 parameetriga meetod");
    }

    public void meetod7(int arv)
    {
        if (arv > 0)
            return;
        Console.WriteLine("Return kui katkestaja mitte tagastaja");
    }

    public void meetod8(int arv2 = 0)
    {
        Console.WriteLine("Vaike väärtusega parameeter ehk meetodi saab käivitada ilma parameetrita.");
    }

    public void meetod9(int? arv1)
    {
        Console.WriteLine("Valikuline parameeter arv1 ehk null väärtus ehk nullable, mis võib vajada castimist koodiblokis");
    }
}
