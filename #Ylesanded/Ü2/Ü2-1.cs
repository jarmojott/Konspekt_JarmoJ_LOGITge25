internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Palun sisesta oma nimi: ");
        string nimi = Console.ReadLine();
        if (nimi.Equals("Võsapets"))
            Console.WriteLine("Mine võssa tagasi.");
    }
}