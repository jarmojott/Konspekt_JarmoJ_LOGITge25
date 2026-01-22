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

            /* <-- KAITSTUD SÕNAD -->
             * Kaitsud sõnad on kindlad sõnad mida kompilaator kasutab oma koodistruktuuride tähistamiseks, 
             * mistõttu ei saa neid kasutada muutujate, klasside, nimeruumide ja funktsioonide nimedes
             * Näiteks: 
             * abstract, as, base, bool, break, byte, case, catch, char, checked, class, count, countinue, 
             * decimal, default, delegate, do, double, else, enum, event, explicit, extern, false, finally, fixed, float, for, 
             * foreach, goto, if, implicit, in, int, interface, internal, is, lock, long, namespace, new, null, object,
             * operator, out, override, params, private, protected, public, readonly, ref, return ,sbyte, sealed, short, sizeof,
             * stackalloc, static, string, struct, switch, this, throw, true, try, typeof, uint, ulong, unchecked, unsafe, ushort, 
             * using, virtual, void, volatile, while.
             */
        }
    }
}
