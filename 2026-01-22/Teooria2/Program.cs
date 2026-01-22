namespace Teooria2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* <-- TINGIMUSLAUSE "SWITCHCASE" -->
             * 'switch' on kaitstud sõna alternatiivse tingimuskontrolli jaoks, mida saab tüüpilise 'IF ELSE' asemel kasutada.
             * Sulgude vahele jääb muutuja nimi või avaldis mille põhjal tingimuslik ümberlülitus toimub.
             *  Sellele järgneb koodiblokk {} mille siis käivad juhtumid või väärtused mis võivad ühtida lülitusvalikuga.
             *  Iga juhtum algab sõnaga 'case' ning väärtus selle järele millele see juhtub vastab. Kooloni järgi lisatakse tegevus mis tingimuse täitumisel täidetakse.
             *  'default:' juhtub käivitub siis kui mitte üksi juhtumi väärtus ei vastanud tingimusele ehk siis vaikejuhtum. Erinvalt else lausest võib see olla ka bloki alguses.
             *  'break' sõna määrab nii juhtumi tegevuse lõpu ning katkestab kogu switch koodibloki.
             */
            int option = 3;
            switch (option)
            {
                case 1:
                    Console.WriteLine("1");
                    break;
                case 2:
                    break;
                case 3:
                    Console.WriteLine(option);
                    break;
                default:
                    break;
            }
        }
    }
}
