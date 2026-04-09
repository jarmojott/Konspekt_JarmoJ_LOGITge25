/*
B (LOGITge25 Jarmo Jõgeva)
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
            kasutajad.Add(new Kasutaja("proov1@test.ee", "1", "1"));
            kasutajad.Add(new Kasutaja("proov2@test.ee", "2", "2"));

            List<Üritus> üritused = new List<Üritus>();
            üritused.Add(new Üritus("Õllesummer", 24.99));
            üritused.Add(new Üritus("Luikede järv", 49.99));

            List<Pilet> piletid = new List<Pilet>();
            piletid.Add(new Pilet(kasutajad[1], üritused[0].Hind, üritused[0]));

            int valik = -1;
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Peamenüü:");
                Console.WriteLine("1: Logi sisse");
                Console.WriteLine("2: Registreeri");
                Console.WriteLine("3: Lõpeta");
                Console.ForegroundColor = ConsoleColor.White;
                valik = sisestaNaturaalarvVahemikus("Tee oma valik numbriga: ", 1, 3);
                switch (valik)
                {
                    case 1:
                        {
                            Kasutaja kasutaja = logiSisse(kasutajad);
                            if (kasutaja != null && kasutaja.SisseLogitud)
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Kasutaja menüü:");
                                    Console.WriteLine("1: Vaata oma kehtivaid pileteid.");
                                    Console.WriteLine("2: Vaata oma kehtetuid pileteid.");
                                    Console.WriteLine("3: Osta uus pilet.");
                                    Console.WriteLine("4: Lunasta oma pilet.");
                                    Console.WriteLine("5: Logi välja.");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    valik = sisestaNaturaalarvVahemikus("Tee oma valik numbriga: ", 1, 5);

                                    switch (valik)
                                    {
                                        case 1:
                                            kuvaPiletid(piletid, kasutaja, true);
                                            break;
                                        case 2:
                                            kuvaPiletid(piletid, kasutaja, false);
                                            break;
                                        case 3:
                                            ostaPilet(üritused, piletid, kasutaja);
                                            break;
                                        case 4:
                                            lunastaPilet(piletid, kasutaja);
                                            break;
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
                        Console.ForegroundColor = ConsoleColor.White;
                        return;
                }
            } while (true);
        }

        static void kuvaPiletid(List<Pilet> piletid, Kasutaja kasutaja, bool kasKehtib)
        {
            Console.Clear();
            int i = 0;

            foreach (var pilet in piletid)
            {
                if (pilet.Kasutaja.Equals(kasutaja) && pilet.kehtib == kasKehtib)
                {
                    i++;
                    Console.WriteLine(i + ". " + pilet.Üritus.Nimi);
                }
            }

            if (i > 0)
            {
                if (kasKehtib)
                {
                    Console.WriteLine("Kehtivaid pileteid kokku: " + i + "tk");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(!) Vajuta jätkamiseks suvalist klahvi...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Kehtetuid pileteid kokku: " + i + "tk");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("(!) Vajuta jätkamiseks suvalist klahvi...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (kasKehtib)
                    Console.WriteLine("(!) Puuduvad kehtivad piletid.");
                else
                    Console.WriteLine("(!) Puuduvad kehtetud piletid.");
            }
        }

        static void lunastaPilet(List<Pilet> piletid, Kasutaja kasutaja)
        {
            Console.Clear();
            List<int> indeksid = new List<int>();
            for (int i = 0; i < piletid.Count; i++)
            {
                if (piletid[i].Kasutaja.Equals(kasutaja) && piletid[i].kehtib)
                {
                    indeksid.Add(i);
                    Console.WriteLine(indeksid.Count + ": " + piletid[i].Üritus.Nimi);
                }
            }

            if (indeksid.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("(!) Puuduvad kehtivad piletid mida lunastada.");
            }
            else
            {
                int valik = sisestaNaturaalarvVahemikus("Tee oma valik numbriga: ", 1, indeksid.Count);
                piletid[indeksid.ElementAt(valik - 1)].kehtib = false;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("(!) Pilet on lunastud.");
            }
        }

        static void ostaPilet(List<Üritus> üritused, List<Pilet> piletid, Kasutaja kasutaja)
        {
            Console.Clear();
            int valik = -1;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hetkel on saada pileteid üritustele:");
            for (int i = 0; i < üritused.Count; i++)
            {
                Console.WriteLine((i + 1) + ": " + üritused[i].Nimi + " - " + üritused[i].Hind + " EUR");
            }
            Console.ForegroundColor = ConsoleColor.White;
            valik = sisestaNaturaalarvVahemikus("Tee oma valik numbriga: ", 1, üritused.Count) - 1;

            double sisestatudSumma = -1;
            while (sisestatudSumma < üritused[valik].Hind)
            {
                Console.Write("Sisesta palun vajalik summa (" + üritused[valik].Hind + " EUR): ");
                sisestatudSumma = double.Parse(Console.ReadLine());
                if (sisestatudSumma < üritused[valik].Hind)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) Summa ei ole piisav.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            if (sisestatudSumma > üritused[valik].Hind)
                Console.WriteLine("(!) Tagastud summa: " + double.Round((sisestatudSumma - üritused[valik].Hind), 2) + " EUR");
            piletid.Add(new Pilet(kasutaja, üritused[valik].Hind, üritused[valik]));
            Console.WriteLine("(!) Valitud pilet ostetud.");
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(tekst);
                sisestus = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(sisestus))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) Puudub sisestatud väärtus.");
                } else if (sisestus.Contains(' '))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) Tühikud pole lubatud.");
                }
            }
            while (string.IsNullOrEmpty(sisestus) || sisestus.Contains(' '));
            return sisestus;
        }

        static string sisestaEpost()
        {
            string[] ePostiOsad = Array.Empty<string>();
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Sisesta oma e-posti aadress: ");
                ePostiOsad = Console.ReadLine().Trim().ToLower().Split('@');
                if (ePostiOsad.Length != 2 || !ePostiOsad[1].Contains('.'))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) Ei ole sobilik e-post.");
                }
            }
            while (ePostiOsad.Length != 2 || !ePostiOsad[1].Contains('.'));
            return string.Join("", ePostiOsad);
        }

        static int sisestaNaturaalarvVahemikus(string tekst, int algus, int lõpp)
        {
            bool kontroll = false;
            int sisestus = -1;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(tekst);
                kontroll = int.TryParse(Console.ReadLine(), out sisestus);
                if (!kontroll || sisestus < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("(!) Ei ole sobilik naturaalarv.");
                }
            }
            while (!kontroll || sisestus < algus || sisestus > lõpp);
            return sisestus;
        }
    }
}
