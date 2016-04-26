namespace Port_classes_console
{
    class Stockage
    {
        private int capaDispo;
        private int capaTotal;

        public Stockage(int pCapaDispo, int pCapaTotal)
        {
            this.capaDispo = pCapaDispo;
            this.capaTotal = pCapaTotal;
        }
        public int obtenirCapaDispo()
        {
            return this.capaDispo;
        }
        public void stocker(int qte)
        {
            this.capaDispo = this.capaDispo - qte;
        }
        public bool estVide()
        {
            return this.capaDispo == this.capaTotal;
        }
        public bool estRemplie()
        {
            return this.capaDispo == 0;
        }
    }
}
