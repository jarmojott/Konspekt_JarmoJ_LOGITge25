namespace Aine_Lõputöö
{
    public class Pilet
    {
        public bool kehtib;
        public Kasutaja Kasutaja;
        public double Hind;
        public Üritus Üritus;

        public Pilet(Kasutaja piletiOmanik, double OstuHind, Üritus valitudÜritus)
        {
            kehtib = true;
            Kasutaja = piletiOmanik;
            Hind = OstuHind;
            Üritus = valitudÜritus;
        }
    }
}
