using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosmosOkno2
{
    partial class Kosmos
    {
        private ModyfikatorOrbity wolnyModyfikator;
        private List<CialoNiebieskie> cialaNiebieskie;

        public Kosmos()
        {
            cialaNiebieskie = new List<CialoNiebieskie>();
        }
        
        public List<DaneDoRysowania> PodajDaneDoRysowania()
        {
            List<DaneDoRysowania> lista = new List<DaneDoRysowania>();
            foreach (CialoNiebieskie cialo in cialaNiebieskie)
            {
                Punkt3d p = cialo.PodajWspolrzedne();
                lista.Add(new DaneDoRysowania(p[0], p[1], p[2], cialo.PodajPromien(), cialo.GetType().Name));
            }
            return lista;
        }

        public static int IleZaistanialoCialWWszechswiecie()
        {
            return CialoNiebieskie.PodajNastepneID();
        }

        public void PrzygotujModyfikatorOrbity(string okrazane, double x, double y, double z, double predkoscKatowa, double katPlaszczyznyX, double katPlaszczyznyY)
        {
            CialoNiebieskie okrazaj = PodajCialo(okrazane);
            if (okrazaj.GetType().Name != "Gwiazda" || okrazaj.GetType().Name != "Planeta")
            {
                wolnyModyfikator = new ModyfikatorOrbity((ICialoOkrazane)okrazaj, x, y, z, predkoscKatowa, katPlaszczyznyX, katPlaszczyznyY);
            }
            else throw new Exception(okrazane + " NIE MOZE BYC CIALEM OKRAZANYM");

        }

        partial void UsunDoatkoweSatelity();

        public void UsunCialoNiebieskie(string tekst)
        {
            CialoNiebieskie doUsuniecia = PodajCialo(tekst);
            
            doUsuniecia.Usun();
            cialaNiebieskie.Remove(doUsuniecia);
            doUsuniecia = null;
            
            UsunDoatkoweSatelity();
        }

        public int PodajIloscCial()
        {
            return cialaNiebieskie.Count;
        }

        public void RuchPoOrbitach(double czas)
        {
            
            foreach (CialoNiebieskie cialoNiebieskie in cialaNiebieskie)
            {
                if (cialoNiebieskie.GetType().Name == "Gwiazda")
                {
                    /*
                    ICialoOkrazane gwiazda = (Gwiazda)cialoNiebieskie;
                    foreach (ISatelita satelita in gwiazda.PodajSatelity())
                    {
                        satelita.RuchPoOrbicie(czas);
                    }*/
                    Gwiazda gwiazda = (Gwiazda)cialoNiebieskie;
                    gwiazda.RuchSatelitPoOrbicie(czas);
                }
            }
        }

        public void Przesun(string nazwa, double x, double y, double z)
        {
            foreach (CialoNiebieskie cialoNiebieskie in cialaNiebieskie)
            {
                if (cialoNiebieskie.ToString() == nazwa)
                {
                    cialoNiebieskie.Przesun(x, y, z);
                    break;
                }
            }
        }
        public void Przesun(string nazwa, double x, double y)
        {
            Przesun(nazwa, x, y, 0);
        }

        public void Przesun(double x, double y, double z)
        {
            foreach(CialoNiebieskie cialoNiebieskie in cialaNiebieskie)
            {
                if (cialoNiebieskie.GetType().Name == "Gwiazda")
                    cialoNiebieskie.Przesun(x, y, z);
            }
        }
        public void Przesun(double x, double y)
        {
            foreach (CialoNiebieskie cialoNiebieskie in cialaNiebieskie)
            {
                if(cialoNiebieskie.GetType().Name == "Gwiazda")
                    cialoNiebieskie.Przesun(x, y);
            }
        }
        public List<string> PodajCialaNiebieskie(string typ)
        {
            List<string> lista = new List<string>();

            if (typ == "CialoNiebieskie")
            {
                foreach (CialoNiebieskie cialo in cialaNiebieskie)
                {
                        lista.Add(cialo.ToString());
                }
            }
            else
            {
                foreach (CialoNiebieskie cialo in cialaNiebieskie)
                {
                    if (cialo.GetType().Name == typ)
                        lista.Add(cialo.ToString());
                }
            }
            return lista;
        }

        private CialoNiebieskie PodajCialo(string nazwa)
        {
            foreach (CialoNiebieskie cialo in cialaNiebieskie)
            {
                if (cialo.ToString() == nazwa)
                {
                    return cialo;
                }
            }
            return null;
        }

        public String PodajOpis(string nazwa)
        {
            return PodajCialo(nazwa).PodajOpis();
        }

        public void ZmienMase(string nazwa, double masa)
        {
            CialoNiebieskie cialo = PodajCialo(nazwa);

            cialo.ZmienMase(masa);
        }
        public void ZmienPromien(string nazwa, double promien)
        {
            CialoNiebieskie cialo = PodajCialo(nazwa);

            cialo.ZmienPromien(promien);
        }
        public void ZmienRozmiar(string nazwa, double masa)
        {
            CialoNiebieskie cialo = PodajCialo(nazwa);

            cialo.ZmienRozmiar(masa);
        }
        
        private ICialoOkrazane PodajCialoOkrazane(string nazwa)
        {
            ICialoOkrazane okrazaj = null;
            if (nazwa == "m")
            {
                if (wolnyModyfikator == null)
                    throw new Exception("Nie przygotowano modyfikatora orbity");
                else
                    okrazaj = wolnyModyfikator;
            }
            else
            {
                CialoNiebieskie cia = PodajCialo(nazwa);
                if (cia.GetType().Name == "Ksiezyc")
                    throw new Exception(nazwa + " NIE MOZE BYC OKRAZANY");
                okrazaj = (ICialoOkrazane)cia;
            }

            if (okrazaj == null)
                throw new Exception("Nie istnieje takie CialoOkrazane");

            return okrazaj;
        }
        
        protected string DodajGwiazde(int konstruktor, String[] parametry)
        {
            CialoNiebieskie cialo;
            
            try
            {
                switch (konstruktor)
                {
                    case 0:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6], parametry[7],
                                            Double.Parse(parametry[8]));
                        break;
                    case 1:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6], parametry[7]);
                        break;
                    case 2:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6]);
                        break;
                    case 3:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            parametry[6]);
                        break;
                    case 4:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]));
                        break;
                    case 5:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]));
                        break;
                    case 6:
                        cialo = new Gwiazda(Double.Parse(parametry[1]), Double.Parse(parametry[2]));
                        break;
                    case 7:
                        cialo = new Gwiazda();
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    throw new Exception("W wymaganych miejsach na liczby nie wprowadzono ich poprawnie");
                throw new Exception("Nie istnieje taki konstruktor dla Gwiazdy");
            }
            cialaNiebieskie.Add(cialo);

            return cialo.ToString();
        }

        protected string DodajPlanete(int konstruktor, String[] parametry)
        {
            CialoNiebieskie cialo;

            ICialoOkrazane okrazaj = PodajCialoOkrazane(parametry[0]);
            
            try
            {
                switch (konstruktor)
                {
                    case 0:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6],
                                            okrazaj, parametry[7], Double.Parse(parametry[9]),
                                            Double.Parse(parametry[10]), Double.Parse(parametry[11]));
                        break;
                    case 1:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6],
                                            okrazaj, parametry[7], Double.Parse(parametry[9]));
                        break;
                    case 2:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6],
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 3:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            parametry[6],
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 4:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 5:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 6:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 7:
                        cialo = new Planeta(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            okrazaj);
                        break;
                    case 8:
                        cialo = new Planeta(okrazaj);
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    throw new Exception("W wymaganych miejsach na liczby nie wprowadzono ich poprawnie");
                throw new Exception("Nie istnieje taki konstruktor dla Planety");
            }
            cialaNiebieskie.Add(cialo);

            return cialo.ToString();
        }

        protected string DodajKsiezyc(int konstruktor, String[] parametry)
        {
            CialoNiebieskie cialo;
            ICialoOkrazane okrazaj = PodajCialoOkrazane(parametry[0]);
            
        
            try
            {
                switch (konstruktor)
                {
                    case 0:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6],
                                            okrazaj, Double.Parse(parametry[9]),
                                            Double.Parse(parametry[10]), Double.Parse(parametry[11]));
                        break;
                    case 1:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            Double.Parse(parametry[5]), parametry[6],
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 2:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            parametry[6],
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 3:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]), Double.Parse(parametry[4]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 4:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            Double.Parse(parametry[3]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 5:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            okrazaj, Double.Parse(parametry[9]));
                        break;
                    case 6:
                        cialo = new Ksiezyc(Double.Parse(parametry[1]), Double.Parse(parametry[2]),
                                            okrazaj);
                        break;
                    case 7:
                        cialo = new Ksiezyc(okrazaj);
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    throw new Exception("W wymaganych miejsach na liczby nie wprowadzono ich poprawnie");
                throw new Exception("Nie istnieje taki konstruktor dla Ksiezyca");
            }
            cialaNiebieskie.Add(cialo);

            return cialo.ToString();
        }


        public string DodajCialo(int typ, int konstruktor, String [] parametry)
        {
            string nazwa = "";
            switch (typ)
            {
                case 0:
                    nazwa = DodajGwiazde(konstruktor, parametry);
                    break;
                case 1:
                    nazwa = DodajPlanete(konstruktor, parametry);
                    break;
                case 2:
                    nazwa = DodajKsiezyc(konstruktor, parametry);
                    break;
                default:
                    throw new Exception("Typ ciała nie odpowiada istniejącym możliwością");
            }
            return nazwa;
        }

    }
}