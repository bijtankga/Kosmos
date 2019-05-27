using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class Punkt3d
    {
        double[] wspolrzedne;

        public Punkt3d(double[] wspolrzedne)
        {
            if (wspolrzedne.Length != 3)
            {
                throw new Exception("Punkt ma 3 wspolrzedne");
            }
            this.wspolrzedne = wspolrzedne;
        }
        public Punkt3d(double x, double y, double z) : this(new double[] { x, y, z })
        {

        }
        public Punkt3d(double x, double y) : this(x, y, 0)
        {

        }

        public Punkt3d(Punkt3d punkt) : this(punkt[0], punkt[1], punkt[2])
        {
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }
        }


        public double this[int x]
        {
            get
            {
                return wspolrzedne[x];
            }
            set
            {
                wspolrzedne[x] = value;
            }
        }

        public void Przesun(double x, double y, double z)
        {
            this[0] += x;
            this[1] += y;
            this[2] += z;
        }

        public void Przesun(double x, double y)
        {
            Przesun(x, y, 0);
        }

        private double StopnieNaRadiany(double x)
        {
            return x * Math.PI / 180;
        }

        public Punkt3d PunktPoObrocie(Punkt3d wektor, double kat)
        {
            if (wektor == null)
            {
                throw new ArgumentNullException("'Punkt3d wektor' nie może byc NULL");
            }
            kat = StopnieNaRadiany(kat);

            double A = 1 - Math.Cos(kat);
            double B = Math.Cos(kat);
            double C = Math.Sin(kat);
            double D = this[0] * wektor[0] + this[1] * wektor[1] + this[2] * wektor[2];

            return new Punkt3d(
                A * wektor[0] * D + this[0] * B             - this[1] * wektor[2] * C   + this[2] * wektor[1] * C,
                A * wektor[1] * D + this[0] * wektor[2] * C + this[1] * B               - this[2] * wektor[0] * C,
                A * wektor[2] * D - this[0] * wektor[1] * C + this[1] * wektor[0] * C   + this[2] * B);
        }

        public Punkt3d PunktPoObrocie(Punkt3d o, double kat, double plaszczyznaX, double plaszczyznaY)
        {
            if (o == null)
            {
                throw new ArgumentNullException("'Punkt3d o' nie może byc NULL");
            }

            Punkt3d wektor = new Punkt3d(0, 0, 1);

            //Punkt3d p = new Punkt3d(this[0],this[1],this[2]);
            Punkt3d p = new Punkt3d(this);
            

            wektor = wektor.PunktPoObrocie(new Punkt3d(0, 1), plaszczyznaX);
            wektor = wektor.PunktPoObrocie(new Punkt3d(1, 0, 0), plaszczyznaY);

            p.Przesun(-o[0], -o[1], -o[2]);
            p = p.PunktPoObrocie(wektor, kat);
            p.Przesun(o[0], o[1], o[2]);
            
            
            return p;
        }

        public double Odleglosc(Punkt3d punkt)
        {
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }

            return Math.Sqrt(Math.Pow(this[0] - punkt[0], 2) + Math.Pow(this[1] - punkt[1], 2) + Math.Pow(this[2] - punkt[2], 2));
        }
        public Punkt3d WektorPrzesuniecia(Punkt3d nowyPunkt)
        {
            if (nowyPunkt == null)
            {
                throw new ArgumentNullException("'Punkt3d nowyPunkt' nie może byc NULL");
            }

            return new Punkt3d(nowyPunkt[0] - this[0],
                               nowyPunkt[1] - this[1],
                               nowyPunkt[2] - this[2]);
        }
        public override string ToString()
        {
            return String.Format($"({this[0]},{this[1]},{this[2]})");
        }
    }
}
