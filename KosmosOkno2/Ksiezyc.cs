using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class Ksiezyc : CialoNiebieskie, ISatelita
    {
        protected ICialoOkrazane okrazane;

        protected double predkoscKatowa;
        protected double katPlaszczyznyX;
        protected double katPlaszczyznyY;

        public Ksiezyc(Punkt3d punkt, double promien, double masa, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
            : base(punkt, promien, masa, nazwa)
        {
            if (okrazane == null)
            {
                throw new ArgumentNullException("'ICialoOkrazane okrazane' nie może byc NULL");
            }
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }


            this.okrazane = okrazane;
            this.predkoscKatowa = predkoscKatowa;
            this.katPlaszczyznyX = katPlaszczyznyX;
            this.katPlaszczyznyY = katPlaszczyznyY;

            okrazane.DodajSatelite(this);
        }
        public Ksiezyc(double x, double y, double z, double promien, double masa, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
            : this(new Punkt3d(x,y,z),promien,masa,nazwa,okrazane,predkoscKatowa,katPlaszczyznyX,katPlaszczyznyY)
        {
        }
        public Ksiezyc(double x, double y, double z, double promien, double masa, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, masa, nazwa, okrazane, predkoscKatowa, 0, 0)
        {
        }
        public Ksiezyc(double x, double y, double z, double promien, string nazwa, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, 0, nazwa, okrazane, predkoscKatowa)
        {
        }
        public Ksiezyc(double x, double y, double z, double promien, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, promien, "Ksiezyc", okrazane, predkoscKatowa)
        {
        }
        public Ksiezyc(double x, double y, double z, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, z, 1, okrazane, predkoscKatowa)
        {
        }
        public Ksiezyc(double x, double y, ICialoOkrazane okrazane, double predkoscKatowa)
            : this(x, y, 0, okrazane, predkoscKatowa)
        {
        }
        public Ksiezyc(double x, double y, ICialoOkrazane okrazane)
            : this(x, y, okrazane, 1)
        {
        }
        public Ksiezyc(ICialoOkrazane okrazane)
            : this(0, 0, okrazane)
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
            okrazane.UsunSatelite(this);
            okrazane = null;
        }


        public void RuchPoOrbicie(double czas)
        {
            Punkt3d wektor = wspolrzedne.WektorPrzesuniecia(
                wspolrzedne.PunktPoObrocie(
                    okrazane.PodajWspolrzedne(), predkoscKatowa * czas, katPlaszczyznyX, katPlaszczyznyY));
            Przesun(wektor[0], wektor[1], wektor[2]);
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
        public List<ISatelita> PodajSatelity()
        {
            return null;
        }
        public void ZmienKatOrbity(double x, double y)
        {
            katPlaszczyznyX += x;
            katPlaszczyznyY += y;
        }

        public override string PodajOpis()
        {
            return String.Format($"Księżyc {nazwa} o promieniu {promien} orbituje w odległosci {PodajOdlegloscOdOkrazanego()} {okrazane.PodajNazwe()} z prędkością {predkoscKatowa}, znajduje się na pozycji {wspolrzedne}, posiada mase {masa}, objetosc {PodajObjetosc()}");
        }
    }
}
