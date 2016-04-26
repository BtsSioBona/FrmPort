using System.Collections.ObjectModel;
using static Enhanced.NavireFret;
using static Enhanced.NavirePassager;

namespace Enhanced
{
    public class Port
    {
        private Collection<ToutNavire> TousLesNaviresPort;

        public Port(string nomPort)
        {
            NomPort = nomPort;
        }

        public string NomPort { get; set; }

        public int NbNaviresFret()
        {
            return NbNavireFret;
        }

        public int NbNaviresPassager()
        {
            return NbNavirePassager;
        }

        public int NbNavireTotal()
        {
            return NbNavirePassager + NbNavireFret;
        }

        /// <summary>
        /// Créer un nouveau navire de type fret
        /// </summary>
        /// <param name="pUnNavireFret">Navire fret à ajouter</param>
        public void AjouterNavire(NavireFret pUnNavireFret)
        {
            
        }

        /// <summary>
        /// Créer un nouveau navire pouvant accueillir des passagers
        /// </summary>
        /// <param name="pUnNavirePassager">Navire passager à ajouter</param>
        public void AjouterNavire(NavirePassager pUnNavirePassager)
        {
            
        }
        
        /// <summary>
        /// Supprime un navire à l'indice i
        /// </summary>
        /// <param name="i">Indice</param>
        public void SupprimerNavire(int i)
        {
            
        }

        /// <summary>
        /// Retoure le navire à l'indice i
        /// </summary>
        /// <param name="i">indice</param>
        /// <returns>Navire fret ou passager</returns>
        public ToutNavire ExtraireNavire(int i)
        {
            
        }
    }
}
