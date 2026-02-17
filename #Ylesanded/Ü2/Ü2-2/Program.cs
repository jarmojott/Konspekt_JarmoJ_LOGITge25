internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Kas hiired meeldivad sulle? (jah/ei): ");
        if (Console.ReadLine().ToLower().Equals("jah"))
            Console.WriteLine("IUUUUU");
        else
            Console.WriteLine("vähemalt pole piuksuja");
    }
}