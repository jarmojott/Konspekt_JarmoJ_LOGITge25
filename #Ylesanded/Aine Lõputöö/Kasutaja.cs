namespace Aine_Lõputöö
{
    public class Kasutaja
    {
        public string Epost;
        public string Parool;
        public string Kasutajanimi;
        public bool SisseLogitud;

        public Kasutaja(string uusEpost, string uusKasutajanimi, string uusParool)
        {
            SisseLogitud = false;
            Epost = uusEpost;
            Parool = uusParool;
            Kasutajanimi = uusKasutajanimi;
        }
    }
}
