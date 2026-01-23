namespace Teooria3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* <-- PARSIMINE ehk teisendamine -->
             * On katse teisendada tekstist mingeid arvandmeid.
             * Teisendamine toimub küsides mingist andmetüübist talle sisseehitatud funktsiooni "Parse" välja kutsumisel mille parameetriks on sõne. 
             * Eksisteerib ka alternatiivne meetod tryParse() mis suudab teisendamise ebaõnnestumisel tagastada booleani.
             */
            string seeOnTekst = "1";
            int teisendatud = int.Parse(seeOnTekst);
            //Console.WriteLine(teisendatud);
            //Console.WriteLine(int.TryParse(seeOnTekst, out teisendatud));

            /*  <-- KONVERTEERIMINE -->
             *  Konverteerimine on otsene teisendus ükskõik millisesse teise andmetüüpi.
             *  Selle jaoks eksisteerib eraldi moodul Convert kus on olemas erinevad meetodid kõikide andmetüüpide jaoks, sh. toString().
             *  Sisendparameetrina aktseerib ta suvalist andmetüüpi.
             * */
            //var mingiInfo = "6.7";
            //string mingiInfoTekst = Convert.ToString(mingiInfo);
            //double mingiInfoDouble = Convert.ToDouble(mingiInfoTekst);
            //char mingoInfoChart = Convert.ToChar(mingiInfoDouble);
            //int mingiInfoInt = Convert.ToInt32(mingoInfoChart);
            //long mingiInfoLong = Convert.ToInt64(mingoInfoChart);
            //decimal mingiInfoDecimal = Convert.ToDecimal(mingiInfoLong);
            //byte mingiInfoByte = Convert.ToByte(mingiInfoDecimal);
            //bool mingiInfoBool = Convert.ToBoolean(mingiInfoByte);

            //NÄIDE:

            //int kasutajaPikkus = 0;
            //int vennaPikkus = 0;
            //int emaPikkus = 0;
            //int isaPikkus = 0;

            //Console.Write("Mis on sinu pikkus (cm): ");
            //kasutajaPikkus = int.Parse(Console.ReadLine());

            //Console.Write("Mis on sinu venna pikkus (cm): ");
            //vennaPikkus = int.Parse(Console.ReadLine());

            //Console.Write("Mis on sinu ema pikkus (cm): ");
            //emaPikkus = int.Parse(Console.ReadLine());

            //Console.Write("Mis on sinu isa pikkus (cm): ");
            //isaPikkus = int.Parse(Console.ReadLine());

            //// manuaalne castimine
            //float pereKeskmine = ((float)kasutajaPikkus + vennaPikkus + emaPikkus + isaPikkus) / 4 / 100; //meetrites
            //float vanemateKeskmine = ((float)emaPikkus + isaPikkus) / 2 / 100; //meetrites
            //float lasteKeskmine = ((float)kasutajaPikkus + vennaPikkus) / 2 / 100; //meetrites

            //float vahe = 0;

            //if (vanemateKeskmine > lasteKeskmine)
            //    vahe = vanemateKeskmine - lasteKeskmine;
            //else
            //    vahe = lasteKeskmine - vanemateKeskmine;

            //Console.WriteLine("Perekeskmine on " + Math.Round(pereKeskmine, 2) + "m.\nVanematekeskmine on " + Math.Round(vanemateKeskmine, 2) + "m.\nLastekeskmine on " + Math.Round(lasteKeskmine, 2) + "m.\nVahe on " + Math.Round(vahe, 2) + "m.");



            //JÄRJENDID
            List<int> vanused = new List<int>();
            List<string> nimed = new List<string> { "oma", "venna", "isa", "ema" };
            int i = 0;
            do
            {
                Console.Write("Sisesta " + nimed.ElementAt(i) + " pikkus (cm): ");
                vanused.Add(int.Parse(Console.ReadLine()));
                i++;
            } while (i < nimed.Count);


            // manuaalne castimine
            float pereKeskmine = ((float)vanused.ElementAt(0) + vanused.ElementAt(1) + vanused.ElementAt(2) + vanused.ElementAt(3)) / nimed.Count / 100; //meetrites
            float vanemateKeskmine = ((float)vanused.ElementAt(2) + vanused.ElementAt(3)) / 2 / 100; //meetrites
            float lasteKeskmine = ((float)vanused.ElementAt(0) + vanused.ElementAt(1)) / 2 / 100; //meetrites

            float vahe = 0;
            if (vanemateKeskmine > lasteKeskmine)
                vahe = vanemateKeskmine - lasteKeskmine;
            else
                vahe = lasteKeskmine - vanemateKeskmine;

            Console.WriteLine("Perekeskmine on " + Math.Round(pereKeskmine, 2) + "m.\nVanematekeskmine on " + Math.Round(vanemateKeskmine, 2) + "m.\nLastekeskmine on " + Math.Round(lasteKeskmine, 2) + "m.\nVahe on " + Math.Round(vahe, 2) + "m.");
        }
    }
}
