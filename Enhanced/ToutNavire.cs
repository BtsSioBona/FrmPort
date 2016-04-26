namespace Enhanced
{
    class ToutNavire
    {
        public ToutNavire(int noLloyds, string nomNavire, string pavillon, int longeur, int largeur, int tirantEau)
        {
            NoLloyds = noLloyds;
            NomNavire = nomNavire;
            Pavillon = pavillon;
            Longeur = longeur;
            Largeur = largeur;
            TirantEau = tirantEau;
        }

        public int NoLloyds { get; set; }

        public string NomNavire { get; set; }

        public string Pavillon { get; set; }

        public int Longeur { get; set; }

        public int Largeur { get; set; }

        public int TirantEau { get; set; }

        public static int NbToutNavires { get; set; }
    }
}
