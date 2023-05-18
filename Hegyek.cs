using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MHegyek
{
    internal class Hegyek
    {
        string hegyNev;
        string hegyseg;
        int magassag;

        public Hegyek(string hegynev, string hegyseg, int magassag)
        {
            this.hegyNev = hegynev;
            this.hegyseg = hegyseg;
            this.magassag = magassag;
        }

        public string HegyNev { get => hegyNev; }
        public string Hegyseg { get => hegyseg; }
        public int Magassag { get => magassag; }
    }
}

