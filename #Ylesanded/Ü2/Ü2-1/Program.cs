internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Palun sisesta oma nimi: ");
        if (Console.ReadLine().Equals("Võsapets"))
            Console.WriteLine("Mine võssa tagasi.");
    }
}