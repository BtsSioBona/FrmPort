namespace Enhanced
{
    public class NavirePassager : ToutNavire
    {
        public NavirePassager(int nbMaxiPassager, int nbChambres, int nbCouchettes, int noLloyds, string nomNavire, string pavillon, int longeur, int largeur, int tirantEau)
            : base(noLloyds, nomNavire, pavillon, longeur, largeur, tirantEau)
        {
            NbMaxiPassager = nbMaxiPassager;
            NbChambres = nbChambres;
            NbCouchettes = nbCouchettes;
        }

        public int NbMaxiPassager { get; set; }

        public int NbChambres { get; set; }

        public int NbCouchettes { get; set; }

        public static int NbNavirePassager { get; set; }
    }
}
