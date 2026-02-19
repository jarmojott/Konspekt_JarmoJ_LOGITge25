internal class Program
{
    static void Main(string[] args)
    {
        Y3_1();
        Y3_2();
        Y3_3();
        Y3_4();
    }

    static void Y3_1()
    {
        do
        {
            Console.Write("Siseta palun oma vanus: ");
        } while (!(int.Parse(Console.ReadLine()) > 0));
    }

    static void Y3_2()
    {
        int aastaArv = 0;
        while (!(aastaArv >= 1000 && aastaArv <= 2025))
        {
            Console.Write("Sisesta aastaarv: ");
            aastaArv = int.Parse(Console.ReadLine());
        }
    }

    static void Y3_3()
    {
        string[] jõuluKingitusIdeed = new string[5] { "Õun", "Pirn", "Banaan", "Greip", "Sidrun" };
        for (int i = 1; i < jõuluKingitusIdeed.Length + 1; i++)
            Console.WriteLine($"{i}. {jõuluKingitusIdeed.ElementAt(i - 1)}");
    }

    static void Y3_4()
    {
        List<int> täisArvud = new List<int>() { 1, 2, 3, 4, 5 };
        int korrutis = 1;
        foreach (var täisArv in täisArvud)
        {
            korrutis *= täisArv;
        }
        Console.WriteLine(string.Join("*", täisArvud) +"=" + korrutis);
    }
}
