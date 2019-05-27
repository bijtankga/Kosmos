using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class DaneDoRysowania
    {
        private double x;
        private double y;
        private double z;

        private double r;

        private string typ;

        public DaneDoRysowania(double x, double y, double z, double r, string typ)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.r = r;
            this.typ = typ;
        }

        public double this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                if (i == 2)
                    return z;
                return r;
            }
        }

        public string Typ()
        {
            return typ;
        }
    }
}
