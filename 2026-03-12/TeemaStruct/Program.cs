using System.Linq.Expressions;
using TeemaStruct;

internal class Program
{
    static void Main(string[] args)
    {
        Kordinaat minuAsukoht1 = new Kordinaat();
        minuAsukoht1.X = 10;
        minuAsukoht1.Y = 20;
        Console.WriteLine(minuAsukoht1.ToString());

        Kordinaat minuAsukoht2 = new Kordinaat(11, 22);

        Console.WriteLine(minuAsukoht2.ToString());

        Car myCar = new Car("Yaris", CarMark.Toyota, "ABC123", "dark-grey", 1600, new List<string>() {"BT", "DAB" });

        Console.WriteLine(myCar.getInfo());
        myCar.printAssecories();
    }

    /*
 * <<< KOMPOSIITANDMETÜÜP: STRUCT ehk STRUKTUUR >>>
 * Struct ehk struktuur on komposiitandmetüüp mis sarnaneb klassile, et erinevalt teistest andmetüüpidest saab struct sisaldada meetodeid ja omadusi
 * Sarnaselt klassile on ka structil ka konstruktur millega ta luuakse.
 * 
 * Anatoomia:
 * Vajalik on nimeruumi tekitamine koos juurdepääsu modifikaatoriga, nime ja andmetüübi sätestusega.
 * Konstruktor (sama nagu klassil) ning defineerib ära spetsiaalse meetodi mis defineerib selle loomise sammude jada.
 * Konstruktoreid saab olla mitu.
 * Struktuuri omadused on meetodid millega andmeid käideltakse. Neid meetodeid saab ka ülelaadida.
 * Get() ja Set() on vaike meetodid millega andmeväljasid muuta ja küsida.
 * 
 */
    struct Kordinaat
    {
        public int Y { get; set; }
        public int X { get; set; }

        public Kordinaat(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public void HelloWorld()
        {
            Console.WriteLine("Tere-tere!");
        }
    }


    /*
     * <<< ENUM >>>
     * Enum on spetsiaalne klassi tüüp mille andmed on muutumatud ehk konstandid.
     * Praktikas on ta täisarvuline loend mille on lihtsalt sildid küljes.
     * Defineeritakse enum kaitstud sõnaga enum mille järel on muutuja nimi ning siis koodiblokis tema väärtused loendina eraldatuna komadena. 
     */

    enum HäireTase
    {
        Madal, Keskmine, Kõrge, Kriitiline
    }
}
