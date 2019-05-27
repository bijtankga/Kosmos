using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    class Gwiazda : CialoNiebieskie, ICialoOkrazane
    {
        protected List<ISatelita> satelity;
        protected string rodzaj;
        protected double jasnosc;

        public Gwiazda(Punkt3d punkt, double promien, double masa, string nazwa, string rodzaj, double jasnosc) : base(punkt, promien, masa, nazwa)
        {
            if(jasnosc < 0)
            {
                if (promien < 0 && jasnosc < 0)
                {
                    throw new Exception("Promien, Masa i Jasnosc nie moga byc ujemne");
                }
                if (promien < 0)
                {
                    throw new Exception("Promien i Jasnosc nie moga byc ujemne");
                }
                if (masa < 0)
                {
                    throw new Exception("Masa i Jasnosc nie moga byc ujemne");
                }
                throw new Exception("Jasnosc nie moze byc ujemna");
            }
            this.rodzaj = rodzaj;
            this.jasnosc = jasnosc;
            this.satelity = new List<ISatelita>();
        }
        public Gwiazda(double x, double y, double z, double promien, double masa, string nazwa, string rodzaj, double jasnosc) : this(new Punkt3d(x, y, z), promien, masa, nazwa, rodzaj, jasnosc)
        {
        }
        public Gwiazda(double x, double y, double z, double promien, double masa, string nazwa, string rodzaj) : this(x, y, z, promien, masa, nazwa, rodzaj, 1)
        {
        }
        public Gwiazda(double x, double y, double z, double promien, double masa, string nazwa) : this(x, y, z, promien, masa, nazwa, "Czerwony Karzeł")
        {
        }
        public Gwiazda(double x, double y, double z, double promien, string nazwa) : this(x, y, z, promien, 1, nazwa)
        {
        }
        public Gwiazda(double x, double y, double z, double promien) : this(x, y, z, promien, "Gwiazda")
        {
        }
        public Gwiazda(double x, double y, double z) : this(x, y, z, 1)
        {
        }
        public Gwiazda(double x, double y) : this(x, y, 0)
        {
        }
        public Gwiazda() : this(0, 0)
        {
        }

        public override void Usun()
        {
            List<ISatelita> doUsuniecia = new List<ISatelita>();

            foreach(ISatelita satelita in satelity)
            {
                doUsuniecia.Add(satelita);
            }

            foreach (ISatelita satelita in doUsuniecia)
            {
                satelita.Usun();
                satelity.Remove(satelita);
            }
        }
        public void UsunSatelite(ISatelita satelita)
        {
            if (satelita == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            satelity.Remove(satelita);
        }

        public List<ISatelita> PodajSatelity()
        {
            return satelity;
        }
        public string PodajRodzaj()
        {
            return rodzaj;
        }
        public double PodajJasnosc()
        {
            return jasnosc;
        }
        public override String PodajOpis()
        {
            return String.Format($"{rodzaj} {nazwa} o prominiu {promien}, znajduje sie na pozycji {wspolrzedne}, posiada mase {masa}, objetosc {PodajObjetosc()}, {satelity.Count} satelit i swieci z jasnoscia {jasnosc}");
        }

        public void DodajSatelite(ISatelita satelita)
        {
            if (satelita == null)
            {
                throw new ArgumentNullException("'ISatelita satelita' nie może byc NULL");
            }

            satelity.Add(satelita);
        }
        public override void Przesun(double x, double y, double z)
        {
            foreach(ISatelita satelita in satelity)
            {
                satelita.Przesun(x, y, z);
            }
            base.Przesun(x, y, z);
        }

        public void RuchSatelitPoOrbicie(Double czas)
        {
            foreach (ISatelita satelita in PodajSatelity())
            {
                satelita.RuchPoOrbicie(czas);
            }
        }
    }
}
