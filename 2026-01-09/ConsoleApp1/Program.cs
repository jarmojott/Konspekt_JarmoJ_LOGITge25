internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Sisesta oma vanus: ");
        int kasutajaVanus = int.Parse(Console.ReadLine());

        Console.Write("Sisesta oma vanaisa vanus: ");
        int kasutajaVanaisaVanus = int.Parse(Console.ReadLine());

        //int VanusteVahe = Math.Abs(kasutajaVanaisaVanus - kasutajaVanus);
        Console.WriteLine("Vanuste vahe " + (kasutajaVanaisaVanus - kasutajaVanus));

        Console.Write("Kui palju sa oled vanem nüüd: ");
        kasutajaVanus += int.Parse(Console.ReadLine());
        Console.WriteLine("Vanuste vahe on nüüd " + (kasutajaVanaisaVanus - kasutajaVanus));


        // # OMISTUSOPERATOORID #

        // = tüüpiline väärtuse omistamine
        int muutuja = 1;
        // += liida juurde uus väärtus ja siis omista
        muutuja += 1;
        // -=  lahuta maha uus väärtus ja siis omista
        muutuja -= 1;
        // *= korruta uue väärtusega ja siis omista
        muutuja *= 2;
        // /= jaga uue väärtusega ja siis omista
        muutuja /= 2;
        // %= leia jagamise jääk ja siis omista
        muutuja %= 2;
        // ++ lisa juurde täpselt 1 ja siis omista
        muutuja++;
        // -- lahuta maha täpselt 1 ja siis omista
        muutuja--;
    }
}