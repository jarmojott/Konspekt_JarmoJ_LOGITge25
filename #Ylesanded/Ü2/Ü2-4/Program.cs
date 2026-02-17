internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sisesta oma viimane jalgpallimängu tulemus: ");
        switch (int.Parse(Console.ReadLine()))
        {
            case 0:
                Console.WriteLine("PUDRUJALG OLED VÄ?!?!");
                break;
            case 1:
                Console.WriteLine("täitsa ok");
                break;
            case 2:
                Console.WriteLine("no see on juba on parem");
                break;
            case 3:
                Console.WriteLine("Wow, messi!");
                break;
            default:
                Console.WriteLine("Ei tunne sellist skoori, see liiga suur minu jaoks.");
                break;
        }
    }
}