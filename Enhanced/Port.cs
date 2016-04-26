using static Enhanced.NavireFret;
using static Enhanced.NavirePassager;

namespace Enhanced
{
    public class Port
    {
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
    }
}
