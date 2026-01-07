
internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        int palk = 322;
        int kulud = 32;

        //Console.WriteLine("Kas see kuu kulusid või väljaminekuid oli? jah/ei");
        //string kasutajaVastus = "";
        //kasutajaVastus= Console.ReadLine();

        //if (kasutajaVastus.Equals("jah"))
        //{
        //    Console.Write("Sisesta oma kulutuste summa: ");
        //    kulud = int.Parse(Console.ReadLine());
        //}

        //int kontojääk = palk - kulud;
        //Console.WriteLine(kontojääk + " EUR");
        //Console.Write("Palun sisesta oma boonus: ");
        //int bonus = int.Parse(Console.ReadLine());
        //kontojääk = kontojääk + bonus;
        //Console.WriteLine("Sinu lõppväljate on: " + kontojääk + " EUR");

        // ctrl + k + c/u
        string tekst = "tekstike";
        char täht = 'A';
        float komakohaga = 1.5f; //32bit
        double suuremkomakohagaarv = 1.5d;  //64bit
        decimal kümnendsüsteemikomakohagaarv = 1.5M;
        var x = 123;  // umbmäärane andmetüüp
        var y = "ABC";
        bool javõiei = false; //true või false

        // string string = "abc"; //kõik nimed pole lubatud

        int vanus = 0;

        //Console.Write("Sisesta oma vanus: ");
        //vanus= int.Parse(Console.ReadLine());

        //if (vanus >= 18)
        //{                      
        //    Console.WriteLine("Siin on sinu mojito 🍸");
        //} else
        //{
        //    Console.WriteLine("Sissepääs keelatud!");
        //}

        /*
        klient tahab programmi:
        - küsib kasutaja nime
        - küsib kasutaja parooli
        - logib sisse kui kui parool ja nimi on õige
        Vooskeem juba tehtud
         */

        Console.Write("Sisesta oma kasutajanimi: ");
        String kasutajaNimi= Console.ReadLine();

        Console.Write("Sisesta oma parool: ");
        String kasutajaParool= Console.ReadLine();

        if (kasutajaNimi=="jarmoj" && kasutajaParool=="jarmoParool")
        {
            Console.WriteLine("Oled edukalt sisse logitud!");
        } else
        {
            System.Console.WriteLine("Kasutaja nimi või parool on vale!");
        }
    }
}

