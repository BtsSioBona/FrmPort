namespace Enhanced
{
    public class NavireFret : ToutNavire
    {
        public NavireFret(string libelleFret, int qteFret, int noLloyds, string nomNavire, string pavillon, int longeur, int largeur, int tirantEau)
            : base(noLloyds, nomNavire, pavillon, longeur, largeur, tirantEau)
        {
            LibelleFret = libelleFret;
            QteFret = qteFret;
        }

        public string LibelleFret { get; set; }

        public int QteFret { get; set; }

        public static int NbNavireFret { get; set; }
    }
}
