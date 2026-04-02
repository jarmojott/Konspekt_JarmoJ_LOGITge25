/*
B
- Kontserdipiletiprogramm
- -user klass on, tal on email username ja parool
- - registreeritakse emailiga (kontrolli et on @)
- - sisse logitakse kasutajanime ja parooliga
- - pilet klass on, on eraldi omad omadused (pileti id, event nimi, ostnud kasutaja, hind)
- kasutaja saab vaadata kas andmebaasis (soldticket list) on tal ostetud pileteid tema kasutajale
- on ka event klass, kasutaja saab osta pileteid eventile. kasutaja sisestab rahasumma piletisumma küsimisel
- piletil on juures ka bool ischeckedin omadus mis ütleb kas kasutaja on eventil käinud
- kasutaja saab oma pileteid checkinida.
- kasutaja saab vaadata ainult oma check-initud evente
*/

namespace Aine_Lõputöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Kasutaja> kasutajad = new List<Kasutaja>();
            kasutajad.Add(new Kasutaja("proov@test.ee", "nimi", "parool"));

            int valik = -1;
            do
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Peamenüü:");
                    Console.WriteLine("1 - Logi sisse");
                    Console.WriteLine("2 - Registreeri");
                    Console.WriteLine("3 - Lõpeta");
                    valik = sisestaNaturaalarv("Tee oma valik numbriga: ");
                } while (valik < 1 || valik > 3);

                switch (valik)
                {
                    case 1:
                        {
                            Kasutaja kasutaja = logiSisse(kasutajad);
                            if (kasutaja != null && kasutaja.SisseLogitud)
                            {
                                do
                                {
                                    do
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Kasutaja menüü:");
                                        Console.WriteLine("1 - Vaata oma kehtivaid pileteid.");
                                        Console.WriteLine("2 - Vaata oma vanu pileteid.");
                                        Console.WriteLine("3 - Osta uus pilet.");
                                        Console.WriteLine("4 - Lunasta oma pilet.");
                                        Console.WriteLine("5 - Logi välja.");
                                        valik = sisestaNaturaalarv("Tee oma valik numbriga: ");
                                    } while (valik < 1 && valik > 5);

                                    switch (valik)
                                    {
                                        case 5:
                                            kasutaja.SisseLogitud = false;
                                            Console.Clear();
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("(!) Oled välja logitud.");
                                            break;
                                    }
                                } while (kasutaja.SisseLogitud);
                            }
                            break;
                        }
                    case 2:
                        {
                            kasutajad.Add(looKasutaja());
                            break;
                        }
                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("(!) Lõpp.");
                        return;
                }

            } while (true);


        }

        static Kasutaja logiSisse(List<Kasutaja> kasutajad)
        {
            Console.Clear();
            string kasutajaNimi = sisestaIlmaTühikuta("Palun sisesta oma kasutajanimi: ");
            string parool = sisestaIlmaTühikuta("Palun sisesta oma parool: ");

            foreach (var kasutaja in kasutajad)
            {
                if (kasutaja.Kasutajanimi == kasutajaNimi && kasutaja.Parool == parool)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(!) Oled sissse logitud.");
                    kasutaja.SisseLogitud = true;
                    return kasutaja;
                }

            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("(!) Sellist kasutajat ei leitud.");
            return null;

        }


        static Kasutaja looKasutaja()
        {
            Console.Clear();
            string kasutajanimi = sisestaIlmaTühikuta("Sisesta oma kasutajanimi: ").ToLower();
            string parool = sisestaIlmaTühikuta("Sisesta oma parool: ");
            string ePost = sisestaEpost();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(!) Uus kasutaja loodud.");
            return new Kasutaja(ePost, kasutajanimi, parool);
        }

        static string sisestaIlmaTühikuta(string tekst)
        {
            string sisestus = String.Empty;
            do
            {
                Console.Write(tekst);
                sisestus = Console.ReadLine().Trim();
            }
            while (string.IsNullOrEmpty(sisestus) || sisestus.Contains(' '));
            return sisestus;
        }


        static string sisestaEpost()
        {
            string[] ePostiOsad = Array.Empty<string>();
            do
            {
                Console.Write("Sisesta oma e-posti aadress: ");
                ePostiOsad = Console.ReadLine().Trim().ToLower().Split('@');

            }
            while (ePostiOsad.Length != 2 || !ePostiOsad[1].Contains('.'));
            return string.Join("", ePostiOsad);
        }

        static int sisestaNaturaalarv(string tekst)
        {
            bool kontroll = false;
            int sisestus = -1;
            do
            {
                Console.Write(tekst);
                kontroll = int.TryParse(Console.ReadLine(), out sisestus);
            }
            while (!kontroll || sisestus < 0);
            return sisestus;
        }
    }
}
