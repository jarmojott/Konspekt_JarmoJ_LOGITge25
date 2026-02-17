internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sisesta mitu õppetundi oli sul eelmine nädal: ");
        int tunnid = int.Parse(Console.ReadLine());

        if (tunnid >= 0)
        {
            if (tunnid == 0)
                Console.WriteLine("kahju et sa endast lugu ei pea :c");
            else if (tunnid <= 5)
                Console.WriteLine("algus on hea, aga kõike nii tehtud ei saa");
            else if (tunnid <= 10)
                Console.WriteLine("Oh, sellise tööhooga saab stippigi");
            else if (tunnid <= 20)
                Console.WriteLine("Kuldmedal aasta lõpus?");
            else if (tunnid > 20)
                Console.WriteLine("siin peaks juba sekkuma psühholoog.");
        }
    }
}
