internal class Program
{
    static void Main(string[] args)
    {
        string stringFailiNimi = "kasutajatänav.txt";
        if (File.Exists(stringFailiNimi))
        {
            string[] tervitus = File.ReadAllLines(stringFailiNimi);
            Console.WriteLine(tervitus[0]);
        }
        else
        {
            Console.WriteLine("Sisesta oma nimi:");
            string kasutajaNimi = getAnswer();
            Console.WriteLine("Tere " + kasutajaNimi);
            Console.WriteLine("Palun sisesta ka oma tänavanimi: ");
            string tänavaNimi = getAnswer();

            string failisisu = kasutajaNimi + " ahhaa! Sa elad " + tänavaNimi +" tänaval.";
            Console.WriteLine(failisisu);
            File.WriteAllText(stringFailiNimi, failisisu);

        }
    }

    private static void sisestaOmaVanus(string tekst = "Siseta oma vanus: ")
    {
        int vanus = 0;
        do
        {
            Console.Write(tekst);
            vanus = int.Parse(Console.ReadLine());
        }
        while (vanus <= 0);

        if (vanus >= 65)
            Console.WriteLine("Kuidas jalad liiguvad? hästi?");
        else
            Console.WriteLine("Mitu monsterit päevas jood?");
    }

    private static string getAnswer()
    {
        string input = String.Empty;
        do
        {
            Console.Write("Sisestus: ");
            input = Console.ReadLine();
        }
        while (String.IsNullOrEmpty(input));
        return input;
    }
}
