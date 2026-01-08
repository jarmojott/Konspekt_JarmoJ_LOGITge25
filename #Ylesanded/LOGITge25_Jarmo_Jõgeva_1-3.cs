internal class Program
{
    static void Main(string[] args)
    {
        /*
        klient tahab programmi:
        - küsib kasutaja nime
        - küsib kasutaja parooli
        - logib sisse kui kui parool ja nimi on õige
        Vooskeem juba tehtud
         */

        Console.Write("Sisesta oma kasutajanimi: ");
        String kasutajaNimi = Console.ReadLine();

        Console.Write("Sisesta oma parool: ");
        String kasutajaParool = Console.ReadLine();

        if (kasutajaNimi == "jarmoj" && kasutajaParool == "jarmoParool")
        {
            Console.WriteLine("Oled edukalt sisse logitud!");
        }
        else
        {
            System.Console.WriteLine("Kasutaja nimi või parool on vale!");
        }
    }
}