using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    abstract class CialoNiebieskie
    {
        private static int nastepneID = 0;

        private int id;
        protected Punkt3d wspolrzedne;
        
        protected double promien;
        protected double masa;
        protected string nazwa;

        public CialoNiebieskie(Punkt3d punkt, double promien, double masa, string nazwa)
        {
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }

            if (promien < 0 && masa < 0)
            {
                throw new ArgumentOutOfRangeException("Promien i Masa nie moga byc ujemne");
            }
            if(promien < 0)
            {
                throw new ArgumentOutOfRangeException("Promien nie moze byc ujemny");
            }
            else if(masa < 0)
            {
                throw new ArgumentOutOfRangeException("Masa nie moze byc ujemna");
            }
            wspolrzedne = punkt;
            this.promien = promien;
            this.masa = masa;
            this.nazwa = nazwa;

            this.id = nastepneID;
            nastepneID++;
        }

        public CialoNiebieskie(double x, double y, double z, double promien, double masa, string nazwa) : this(new Punkt3d(x,y,z),promien,masa,nazwa)
        {
        }
        public CialoNiebieskie(double x, double y, double z, double promien, double masa) : this(x,y,z,promien,masa,"Cialo Niebieskie")
        {
        }
        public CialoNiebieskie(double x, double y, double z, double promien, string nazwa) : this(x,y,z,promien,1,nazwa)
        {
        }
        public CialoNiebieskie(double x, double y, double z, double promien) : this(x,y,z,promien,0)
        {
        }
        public CialoNiebieskie(double x, double y, double z) : this(x,y,z,0)
        {
        }
        public CialoNiebieskie(double x, double y) : this (x,y,0)
        {
        }
        public CialoNiebieskie() : this (0,0)
        {
        }

        public abstract void Usun();

        public override string ToString()
        {
            return String.Format($"{id}. {this.GetType().Name} {nazwa}");
        }
        
        public static int PodajNastepneID()
        {
            return nastepneID;
        }

        public Punkt3d PodajWspolrzedne()
        {
            return wspolrzedne;
        }
        public double PodajPromien()
        {
            return promien;
        }
        public double PodajMase()
        {
            return masa;
        }
        public string PodajNazwe()
        {
            return nazwa;
        }
        public abstract string PodajOpis();

        public double PodajObjetosc()
        {
            return Math.PI * Math.Pow(promien, 3) * 4 / 3;
        }

        public virtual void Przesun(double x,double y, double z)
        {
            wspolrzedne[0] += x;
            wspolrzedne[1] += y;
            wspolrzedne[2] += z;
        }
        public virtual void Przesun(double x, double y)
        {
            Przesun(x, y, 0);
        }
        

        public void ZmienMase(double masa)
        {
            if (this.masa+masa < 0)
            {
                throw new Exception("Masa nie moze spasc ponziej 0");
            }

            this.masa += masa;
        }
        public void ZmienPromien(double x)
        {
            if (this.promien + x < 0)
            {
                throw new Exception("Promien nie moze spasc ponizej 0");
            }

            this.promien += x;
        }
        public void ZmienRozmiar(double masa)
        {
            if (this.masa + masa < 0)
            {
                throw new Exception("Masa nie moze spasc ponziej 0");
            }

            promien = Math.Pow( ((Math.Pow(promien, 3) * (this.masa + masa)) / this.masa), (1.0 / 3));
            this.masa += masa;
        }

        public double PodajOdleglosc(Punkt3d punkt)
        {
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }

            return wspolrzedne.Odleglosc(punkt);
        }
    }
}