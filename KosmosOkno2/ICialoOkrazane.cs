using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    interface ICialoOkrazane
    {
        string PodajNazwe();
        string PodajOpis();

        Punkt3d PodajWspolrzedne();
        List<ISatelita> PodajSatelity();
        double PodajOdleglosc(Punkt3d punkt);
        void DodajSatelite(ISatelita satelita);
        void UsunSatelite(ISatelita satelita);

        void RuchSatelitPoOrbicie(double czas);

        void Usun();
    }
}
