using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class Planeta : CialoNiebieskie, ICialoOkrazane, ISatelita
    {
        protected List<ISatelita> satelity;
        protected ICialoOkrazane okrazane;

        protected string rodzaj;

        protected double predkoscKatowa;
        protected double katPlaszczyznyX;
        protected double katPlaszczyznyY;

        public Planeta(Punkt3d punkt, double promien, double masa, string nazwa, ICialoOkrazane okrazane, string rodzaj, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
            : base(punkt,promien,masa,nazwa)
        {
            if (okrazane == null)
            {
                throw new Exception("Tworzenie planety bez okrazanego ciala");
            }
            this.satelity = new List<ISatelita>();
            this.okrazane = okrazane;
            this.rodzaj = rodzaj;
            this.predkoscKatowa = predkoscKatowa;
            this.katPlaszczyznyX = katPlaszczyznyX;
            this.katPlaszczyznyY = katPlaszczyznyY;

            okrazane.DodajSatelite(this);
        }
        public Planeta(double x, double y, double z, double promien, double masa, string nazwa, ICialoOkrazane okrazane, string rodzaj, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
            : this(new Punkt3d(x,y,z),promien,masa,nazwa,okrazane,rodzaj,predkoscKatowa,katPlaszczyznyX, katPlaszczyznyY)
        {
        }
        public Planeta(double x, double y, double z, double promien, double masa, string nazwa, ICialoOkrazane okrazane, string rodzaj, double predkoscKatowa)
            : this(x, y ,z , promien, masa, nazwa, okrazane, rodzaj, predkoscKatowa, 0, 0)
        {
        }
        public Planeta(double x, double y, double z, double promien, double masa, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, masa, nazwa, okrazane, "Gazowy Gigant", predkoscKatowa)
        {
        }
        public Planeta(double x, double y, double z, double promien, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, 0, nazwa, okrazane, predkoscKatowa)
        {
        }
        public Planeta(double x, double y, double z, double promien, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, "Planeta", okrazane, predkoscKatowa)
        {
        }
        public Planeta(double x, double y, double z, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, 1, okrazane, predkoscKatowa)
        {
        }
        public Planeta(double x, double y, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, 0, okrazane, predkoscKatowa)
        {
        }
        public Planeta(double x, double y, ICialoOkrazane okrazane)
            : this(x, y, okrazane, 1)
        {
        }
        public Planeta(ICialoOkrazane okrazane)
            : this(0,0,okrazane)
        {
        }

        public void ZmienOrbite(ICialoOkrazane okrazane)
        {
            if (okrazane == null)
            {
                throw new ArgumentNullException("'ICialoOkrazane okrazane' nie może byc NULL");
            }

            this.okrazane.UsunSatelite(this);
            this.okrazane = okrazane;
        }

        public override void Usun()
        {
            List<ISatelita> doUsuniecia = new List<ISatelita>();

            okrazane.UsunSatelite(this);
            okrazane = null;

            foreach(ISatelita satelita in satelity)
            {
                doUsuniecia.Add(satelita);
            }
            foreach(ISatelita satelita in doUsuniecia)
            {
                satelita.Usun();
                satelity.Remove(satelita);
            }
        }

        public List<ISatelita> PodajSatelity()
        {
            return satelity;
        }
        public void DodajSatelite(ISatelita satelita)
        {
            if (okrazane == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            satelity.Add(satelita);
        }
        public void UsunSatelite(ISatelita satelita)
        {
            if (okrazane == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            satelity.Remove(satelita);
        }

        public void RuchSatelitPoOrbicie(double czas)
        {
            foreach (ISatelita satelita in PodajSatelity())
            {
                satelita.RuchPoOrbicie(czas);
            }
        }

        public void RuchPoOrbicie(double czas)
        {
            RuchSatelitPoOrbicie(czas);
            
            Punkt3d wektor = wspolrzedne.WektorPrzesuniecia(
                wspolrzedne.PunktPoObrocie(okrazane.PodajWspolrzedne(), predkoscKatowa * czas, katPlaszczyznyX, katPlaszczyznyY));
            Przesun(wektor[0], wektor[1], wektor[2]);
        }
        public override void Przesun(double x, double y, double z)
        {
            foreach (ISatelita satelita in satelity)
            {
                satelita.Przesun(x, y, z);
            }
            base.Przesun(x, y, z);
        }

        public ICialoOkrazane PodajCialoOkrazane()
        {
            return okrazane;
        }
        public double PodajPredkoscKatowa()
        {
            return predkoscKatowa;
        }
        public double PodajOdlegloscOdOkrazanego()
        {
            return okrazane.PodajOdleglosc(wspolrzedne);
        }
        public void ZmienKatOrbity(double katX, double katY)
        {
            katPlaszczyznyX += katX;
            katPlaszczyznyY += katY;
        }

        public override string PodajOpis()
        {
            return String.Format($"{rodzaj} {nazwa} o promieniu {promien} orbituje w odległosci {PodajOdlegloscOdOkrazanego()} {okrazane.PodajNazwe()} z prędkością {predkoscKatowa}, znajduje się na pozycji {wspolrzedne}, posiada mase {masa}, objetosc {PodajObjetosc()}, {satelity.Count()} satelit");
        }
    }
}
