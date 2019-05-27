using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class ModyfikatorOrbity : ICialoOkrazane, ISatelita
    {
        protected ICialoOkrazane okrazane;
        protected ISatelita satelita;
        private bool usuniete = false;

        protected Punkt3d wspolrzedne;

        protected double predkoscKatowa;
        protected double katPlaszczyznyX;
        protected double katPlaszczyznyY;

        public ModyfikatorOrbity(ICialoOkrazane okrazane, Punkt3d wspolrzedne, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
        {
            this.okrazane = okrazane;
            this.wspolrzedne = wspolrzedne;
            this.predkoscKatowa = predkoscKatowa;
            this.katPlaszczyznyX = katPlaszczyznyX;
            this.katPlaszczyznyY = katPlaszczyznyY;

            okrazane.DodajSatelite(this);
        }
        public ModyfikatorOrbity(ICialoOkrazane okrazane, double x, double y ,double z, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
            : this(okrazane,new Punkt3d(x,y,z),predkoscKatowa,katPlaszczyznyX,katPlaszczyznyY)
        {
        }
        public ModyfikatorOrbity(ICialoOkrazane okrazane, double x, double y, double z, double predkoscKatowa)
            : this(okrazane, new Punkt3d(x, y, z), predkoscKatowa, 0, 0)
        {
        }
        public ModyfikatorOrbity(ICialoOkrazane okrazane, double x, double y, double z) : this(okrazane, x, y, z, 1)
        {
        }
        public ModyfikatorOrbity(ICialoOkrazane okrazane, double x, double y) : this(okrazane, x, y, 0)
        {
        }
        public ModyfikatorOrbity(ICialoOkrazane okrazane) : this(okrazane, 0, 0)
        {
        }

        public void Usun()
        {
            if (!usuniete)
            {
                usuniete = true;
                satelita.Usun();
                satelita = null;

                okrazane.UsunSatelite(this);
                okrazane = null;
            }
        }
        void ICialoOkrazane.UsunSatelite(ISatelita satelita)
        {
            if (satelita == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            if (this.satelita == satelita)
                Usun();
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


        string ICialoOkrazane.PodajNazwe()
        {
            return okrazane.PodajNazwe();
        }
        string ICialoOkrazane.PodajOpis()
        {
            return okrazane.PodajOpis();
        }
        Punkt3d ICialoOkrazane.PodajWspolrzedne()
        {
            return wspolrzedne;
        }
        List<ISatelita> ICialoOkrazane.PodajSatelity()
        {
            return okrazane.PodajSatelity();
        }
        void ICialoOkrazane.DodajSatelite(ISatelita satelita)
        {
            if (satelita == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            this.satelita = satelita;
        }
        double ICialoOkrazane.PodajOdleglosc(Punkt3d punkt)
        {
            if (punkt == null)
            {
                throw new ArgumentNullException("'Punkt3d punkt' nie może byc NULL");
            }

            return okrazane.PodajOdleglosc(punkt);
        }

        public void Przesun(double x, double y, double z)
        {
            satelita.Przesun(x, y, z);
            wspolrzedne.Przesun(x, y, z);
        }
        public void RuchSatelitPoOrbicie(double czas)
        {
            satelita.RuchPoOrbicie(czas);
        }

        public void RuchPoOrbicie(double czas)
        {
            RuchSatelitPoOrbicie(czas);

            Punkt3d wektor = wspolrzedne.WektorPrzesuniecia(
                wspolrzedne.PunktPoObrocie(okrazane.PodajWspolrzedne(), predkoscKatowa * czas, katPlaszczyznyX, katPlaszczyznyY));
            Przesun(wektor[0], wektor[1], wektor[2]);
        }
        string ISatelita.PodajNazwe()
        {
            return satelita.PodajNazwe();
        }
        string ISatelita.PodajOpis()
        {
            return satelita.PodajNazwe();
        }
        ICialoOkrazane ISatelita.PodajCialoOkrazane()
        {
            return okrazane;
        }
        double ISatelita.PodajPredkoscKatowa()
        {
            return satelita.PodajPredkoscKatowa();
        }
        Punkt3d ISatelita.PodajWspolrzedne()
        {
            return wspolrzedne;
        }
        public double PodajOdlegloscOdOkrazanego()
        {
            return okrazane.PodajOdleglosc(satelita.PodajWspolrzedne());
        }
        List<ISatelita> ISatelita.PodajSatelity()
        {
            return satelita.PodajSatelity();
        }
        void ISatelita.ZmienKatOrbity(double x, double y)
        {
            satelita.ZmienKatOrbity(x, y);
            katPlaszczyznyX += x;
            katPlaszczyznyY += y;
        }


    }
}
