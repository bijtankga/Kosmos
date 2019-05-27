using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    interface ISatelita
    {
        void Przesun(double x, double y, double z);
        void RuchPoOrbicie(double czas);

        string PodajNazwe();
        string PodajOpis();
        ICialoOkrazane PodajCialoOkrazane();
        double PodajPredkoscKatowa();
        Punkt3d PodajWspolrzedne();
        double PodajOdlegloscOdOkrazanego();
        List<ISatelita> PodajSatelity();
        void ZmienKatOrbity(double x, double y);
        void ZmienOrbite(ICialoOkrazane okrazane);

        void Usun();
    }
}
