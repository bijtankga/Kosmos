using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosmosOkno2
{
    public partial class Form1 : Form
    {
        private Kosmos kosmos;
        private bool czyOrbituje = false;

        public Form1()
        {
            InitializeComponent();

            kosmos = new Kosmos();
            cbWyboruKonstruktora.Enabled = false;
            ZablokujKontrolkiTypuCiala();


            try
            {
                string gwiazda = kosmos.DodajCialo(0, 0, new string[] { "","0", "0", "0", "5", "1989100000", "Slońce", "Żółty karzeł", "1","","","" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 25.18, 0, 0, 4.15282, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "30,357", "0", "0", "2", "330", "Merkury", "Planeta Skalista","", "-4,15282","","" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 47.05, 0, 0, 1.62549, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "47,366", "0", "0", "4,96", "4868", "Wenus", "Planeta Skalista", "", "-1,62549", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 65.04, 0, 0, -1.0, 0, 0);
                string ziemia = kosmos.DodajCialo(1, 1, new string[] { "m", "66,13", "0", "0", "5,23", "5974", "Ziemia", "Planeta Skalista", "", "-1,0", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 99.13, 0, 0, 0.53169, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "108,26", "0", "0", "2,79", "642", "Mars", "Planeta Skalista", "", "-0,53169", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 338.7, 0, 0, 0.08429, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "355,217", "0", "0", "58,61", "1898600", "Jowisz", "Gazowy Olbrzym", "", "-0,08429", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 621.74, 0, 0, 0.03396, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "656,522", "0", "0", "49,41", "568517", "Saturn", "Gazowy Olbrzym", "", "-0,03396", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 1249.83, 0, 0, 0.01189, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "1304,348", "0", "0", "20,95", "8641", "Uran", "Lodowy Olbrzym", "", "-0,01189", "", "" });
                kosmos.PrzygotujModyfikatorOrbity(gwiazda, 1932.6, 0, 0, 0.00607, 0, 0);
                kosmos.DodajCialo(1, 1, new string[] { "m", "1934,783", "0", "0", "20,3", "1024396", "Neptun", "Lodowy Olbrzym", "", "-0,00607", "", "" });
                kosmos.DodajCialo(2, 1, new string[] { ziemia, "60,90", "0", "0", "2", "73,48", "Księżyc", "", "", "-12,35714", "", "" });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UaktualnijOpisUsuwanie();

            IleCial();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            RysujKosmos(plKosmos.CreateGraphics());
        }

        private void IleCial()
        {
            lbIlosc.Text = String.Format($"We wszechświecie zaistaniało {Kosmos.IleZaistanialoCialWWszechswiecie()}; " +
                                        $"Z czego w tym kosmosie znajduje się {kosmos.PodajIloscCial()} ciał niebieskich");
        }

        private void RysujKosmos(Graphics grafika)
        {
            grafika.Clear(Color.Black);
            double[] srodek = new double[] { plKosmos.Width/2, plKosmos.Height/2 };

            foreach (DaneDoRysowania cialo in kosmos.PodajDaneDoRysowania())
            {
                if (cialo.Typ() == "Gwiazda")
                    grafika.FillEllipse(Brushes.Yellow, ((float)(cialo[0] + srodek[0] - cialo[4])), 
                                                        ((float)(cialo[1] + srodek[1] - cialo[4])), 
                                                        ((float)(2 * cialo[4])), ((float)(2 * cialo[4])));
                if (cialo.Typ() == "Planeta")
                    grafika.FillEllipse(Brushes.Green, ((float)(cialo[0] + srodek[0] - cialo[4])),
                                                        ((float)(cialo[1] + srodek[1] - cialo[4])),
                                                        ((float)(2 * cialo[4])), ((float)(2 * cialo[4])));
                if (cialo.Typ() == "Ksiezyc")
                    grafika.FillEllipse(Brushes.Blue, ((float)(cialo[0] + srodek[0] - cialo[4])),
                                                        ((float)(cialo[1] + srodek[1] - cialo[4])),
                                                        ((float)(2 * cialo[4])), ((float)(2 * cialo[4])));
            }
        }

        private void ZablokujWszystkieKontrolki()
        {
            ZablokujKonrolkiModyfikatoraOrbity();
            ZablokujKontrolkiTypuCiala();
            cbWyporTypuCiala.Enabled = false;

            btPrzesun.Enabled = false;
        }

        private void ZablokujKonrolkiModyfikatoraOrbity()
        {
            tbModKatX.Enabled = false;
            tbModKatY.Enabled = false;
            tbModX.Enabled = false;
            tbModY.Enabled = false;
            tbModZ.Enabled = false;
            tbModV.Enabled = false;
            
            tbModKatX.Text = "";
            tbModKatY.Text = "";
            tbModX.Text = "";
            tbModY.Text = "";
            tbModZ.Text = "";
            tbModV.Text = "";
        }

        private void OdblokujKonrolkiModyfikatoraOrbity()
        {
            tbModKatX.Enabled = true;
            tbModKatY.Enabled = true;
            tbModX.Enabled = true;
            tbModY.Enabled = true;
            tbModZ.Enabled = true;
            tbModV.Enabled = true;
        }

        private void ZablokujKontrolkiTypuCiala()
        {
            tbWprowadzaniaX.Enabled = false;
            tbWprowadzaniaY.Enabled = false;
            tbWprowadzaniaZ.Enabled = false;
            tbWprowadzaniaR.Enabled = false;
            tbWprowadzaniaM.Enabled = false;
            tbWprowadzaniaNazwy.Enabled = false;
            tbWprowadzaniaRodzaju.Enabled = false;
            tbWprowadzaniaV.Enabled = false;
            tbWprowadzaniaKatX.Enabled = false;
            tbWprowadzaniaKatY.Enabled = false;
            tbWprowadzaniaJasnosci.Enabled = false;
            cbWyboruOrbity.Enabled = false;

            tbWprowadzaniaX.Text = "";
            tbWprowadzaniaY.Text = "";
            tbWprowadzaniaZ.Text = "";
            tbWprowadzaniaR.Text = "";
            tbWprowadzaniaM.Text = "";
            tbWprowadzaniaNazwy.Text = "";
            tbWprowadzaniaRodzaju.Text = "";
            tbWprowadzaniaV.Text = "";
            tbWprowadzaniaKatX.Text = "";
            tbWprowadzaniaKatY.Text = "";
            tbWprowadzaniaJasnosci.Text = "";

            chbModyfikacjiOrbity.Enabled = false;
            chbModyfikacjiOrbity.Checked = false;
        }

        private void OdblokujWprowadzanieGwiazdy(int x)
        {
            ZablokujKontrolkiTypuCiala();

            if (x < 7)
            {
                tbWprowadzaniaX.Enabled = true;
                tbWprowadzaniaY.Enabled = true;
            }
            if (x < 6) tbWprowadzaniaZ.Enabled = true;
            if (x < 5) tbWprowadzaniaR.Enabled = true;
            if (x < 4) tbWprowadzaniaNazwy.Enabled = true;
            if (x < 3) tbWprowadzaniaM.Enabled = true;
            if (x < 2) tbWprowadzaniaRodzaju.Enabled = true;
            if (x < 1) tbWprowadzaniaJasnosci.Enabled = true;
        }
        private void OdblokujWprowadzaniePlanety(int x)
        {
            ZablokujKontrolkiTypuCiala();

            cbWyboruOrbity.Items.Clear();
            foreach (string gwiazda in kosmos.PodajCialaNiebieskie("Gwiazda"))
            {
                cbWyboruOrbity.Items.Add(gwiazda.ToString());
            }

            cbWyboruOrbity.Enabled = true;
            if (x < 8)
            {
                tbWprowadzaniaX.Enabled = true;
                tbWprowadzaniaY.Enabled = true;
            }
            if (x < 7) tbWprowadzaniaV.Enabled = true;
            if (x < 6) tbWprowadzaniaZ.Enabled = true;
            if (x < 5) tbWprowadzaniaR.Enabled = true;
            if (x < 4) tbWprowadzaniaNazwy.Enabled = true;
            if (x < 3) tbWprowadzaniaM.Enabled = true;
            if (x < 2) tbWprowadzaniaRodzaju.Enabled = true;
            if (x < 1)
            {
                tbWprowadzaniaKatX.Enabled = true;
                tbWprowadzaniaKatY.Enabled = true;
            }
            chbModyfikacjiOrbity.Enabled = true;
        }
        private void OdblokujWprowadzanieKsiezyca(int x)
        {
            ZablokujKontrolkiTypuCiala();

            cbWyboruOrbity.Items.Clear();
            foreach(string planeta in kosmos.PodajCialaNiebieskie("Planeta"))
            {
                cbWyboruOrbity.Items.Add(planeta.ToString());
            }
            cbWyboruOrbity.Enabled = true;

            if (x < 7)
            {
                tbWprowadzaniaX.Enabled = true;
                tbWprowadzaniaY.Enabled = true;
            }
            if (x < 6) tbWprowadzaniaV.Enabled = true;
            if (x < 5) tbWprowadzaniaZ.Enabled = true;
            if (x < 4) tbWprowadzaniaR.Enabled = true;
            if (x < 3) tbWprowadzaniaNazwy.Enabled = true;
            if (x < 2) tbWprowadzaniaM.Enabled = true;
            if (x < 1)
            {
                tbWprowadzaniaKatX.Enabled = true;
                tbWprowadzaniaKatY.Enabled = true;
            }
            chbModyfikacjiOrbity.Enabled = true;
        }

        private void cbWyporTypuCiala_SelectedIndexChanged(object sender, EventArgs e)
        {
            btDodajCialo.Enabled = false;
            cbWyboruKonstruktora.Items.Clear();
            cbWyboruKonstruktora.Enabled = true;
            ZablokujKontrolkiTypuCiala();

            if (cbWyporTypuCiala.SelectedItem.ToString() == "Gwiazda")
            {
                cbWyboruKonstruktora.Items.AddRange(new object[] {
                    "(X,Y,Z) r, m, Nazwa, Rodzaj, Jasnosc",
                    "(X,Y,Z) r, m, Nazwa, Rodzaj",
                    "(X,Y,Z) r, m, Nazwa",
                    "(X,Y,Z) r, Nazwa",
                    "(X,Y,Z) r",
                    "(X,Y,Z)",
                    "(X,Y)",
                    "DOMYŚLNY" });
            }
            else if (cbWyporTypuCiala.SelectedItem.ToString() == "Planeta")
            {
                cbWyboruKonstruktora.Items.AddRange(new object[] {
                    "(X,Y,Z) r, m, Nazwa, Orbita, Rodzaj, Predkosc, Plaszczyzna(x,y)",
                    "(X,Y,Z) r, m, Nazwa, Orbita, Rodzaj, Predkosc",
                    "(X,Y,Z) r, m, Nazwa, Orbita, Predkosc",
                    "(X,Y,Z) r, Nazwa, Orbita, Predkosc",
                    "(X,Y,Z) r, Orbita, Predkosc",
                    "(X,Y,Z) Orbita, Predkosc",
                    "(X,Y) Orbita, Predkosc",
                    "(X,Y) Orbita",
                    "Orbita"});
            }
            else if (cbWyporTypuCiala.SelectedItem.ToString() == "Księżyc")
            {
                cbWyboruKonstruktora.Items.AddRange(new object[] {
                    "(X,Y,Z) r, m, Nazwa, Orbita Predkosc, Plaszczyzna(x,y)",
                    "(X,Y,Z) r, m, Nazwa, Orbita Predkosc",
                    "(X,Y,Z) r, Nazwa, Orbita, Predkosc",
                    "(X,Y,Z) r, Orbita, Predkosc",
                    "(X,Y,Z) Orbita, Predkosc",
                    "(X,Y) Orbita, Predkosc",
                    "(X,Y) Orbita",
                    "Orbita"});
            }
        }

        private void cbWyboruKonstruktora_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbWyporTypuCiala.SelectedIndex)
            {
                case 0:
                    OdblokujWprowadzanieGwiazdy(cbWyboruKonstruktora.SelectedIndex);
                    break;
                case 1:
                    OdblokujWprowadzaniePlanety(cbWyboruKonstruktora.SelectedIndex);
                    break;
                case 2:
                    OdblokujWprowadzanieKsiezyca(cbWyboruKonstruktora.SelectedIndex);
                    break;
            }
            btDodajCialo.Enabled = true;
        }

        private void btDodajCialo_Click(object sender, EventArgs e)
        {
            string cialo = "";
            string okrazaj = "";

            try
            {
                if (cbWyporTypuCiala.SelectedIndex != 0)
                    try
                    {
                        okrazaj = cbWyboruOrbity.SelectedItem.ToString();
                    }
                    catch
                    {
                        throw new Exception("Nie wybrano ciala orbitowanego");
                    }

                if (chbModyfikacjiOrbity.Checked == true)
                {
                    kosmos.PrzygotujModyfikatorOrbity(okrazaj, Double.Parse(tbModX.Text), Double.Parse(tbModY.Text), Double.Parse(tbModZ.Text), Double.Parse(tbModV.Text), Double.Parse(tbModKatX.Text), Double.Parse(tbModKatY.Text));
                    okrazaj = "m";
                }
                cialo = kosmos.DodajCialo(cbWyporTypuCiala.SelectedIndex, cbWyboruKonstruktora.SelectedIndex,
                                            new string[] { okrazaj, tbWprowadzaniaX.Text, tbWprowadzaniaY.Text, tbWprowadzaniaZ.Text,
                                                           tbWprowadzaniaR.Text, tbWprowadzaniaM.Text, tbWprowadzaniaNazwy.Text,
                                                           tbWprowadzaniaRodzaju.Text, tbWprowadzaniaJasnosci.Text,
                                                           tbWprowadzaniaV.Text,tbWprowadzaniaKatX.Text, tbWprowadzaniaKatY.Text});

                MessageBox.Show("Dodano:\n" + cialo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUpewnij sie że prawidłowo wprowadziłeś dane!");
            }
            UaktualnijOpisUsuwanie();

            IleCial();
            this.Invalidate();
        }
        
        private void UaktualnijOpisUsuwanie()
        {
            cbOpisCiala.Items.Clear();
            cbUsuwania.Items.Clear();
            foreach (string cialoNiebieskie in kosmos.PodajCialaNiebieskie("CialoNiebieskie"))
            {
                cbOpisCiala.Items.Add(cialoNiebieskie);
                cbUsuwania.Items.Add(cialoNiebieskie);
            }
        }

        private void btUsuwania_Click(object sender, EventArgs e)
        {
            try
            {
                kosmos.UsunCialoNiebieskie(cbUsuwania.SelectedItem.ToString());


                MessageBox.Show("Usunieto:\n" + cbUsuwania.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UaktualnijOpisUsuwanie();



            cbUsuwania.Text = "";
            cbOpisCiala.Text = "";
            btUsuwania.Enabled = false;
            btZmienMase.Enabled = false;
            btZmienPromien.Enabled = false;
            btZmienRozmiar.Enabled = false;

            IleCial();
            //RysujKosmos();
            this.Invalidate();
        }

        private void cbUsuwania_SelectedIndexChanged(object sender, EventArgs e)
        {
            btUsuwania.Enabled = true;
        }

        private void chbModyfikacjiOrbity_CheckedChanged(object sender, EventArgs e)
        {
            if (chbModyfikacjiOrbity.Checked == false)
                ZablokujKonrolkiModyfikatoraOrbity();
            else
                OdblokujKonrolkiModyfikatoraOrbity();
        }

        private void cbOpisCiala_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbOpisCiala.Text = kosmos.PodajOpis(cbOpisCiala.SelectedItem.ToString());

            if(!czyOrbituje)
            {
                btPrzesun.Enabled = true;
            }
            btZmienMase.Enabled = true;
            btZmienRozmiar.Enabled = true;
            btZmienPromien.Enabled = true;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if(btStart.Text == "Start")
            {
                ZablokujWszystkieKontrolki();
                btStart.Text = "Stop";

                timer1.Start();
            }
            else
            {
                timer1.Stop();

                cbWyporTypuCiala.Enabled = true;
                btStart.Text = "Start";

                if(cbOpisCiala.Text != "")
                {
                    btPrzesun.Enabled = true;
                }
            }
        }

        private void btPrzesun_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbPrzesun.Checked)
                    kosmos.Przesun(Double.Parse(tbPrzesunX.Text), Double.Parse(tbPrzesunY.Text));
                else
                    kosmos.Przesun(cbOpisCiala.SelectedItem.ToString(), Double.Parse(tbPrzesunX.Text), Double.Parse(tbPrzesunY.Text));
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    MessageBox.Show("W conajmniej jednym polu przesuwania nie wprowadzono poprawnie liczby");
                else MessageBox.Show(ex.Message);
            }

            rtbOpisCiala.Text = kosmos.PodajOpis(cbOpisCiala.SelectedItem.ToString());
        }

        private void btKrok_Click(object sender, EventArgs e)
        {
            kosmos.RuchPoOrbitach((double)nudPredkosc.Value);
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kosmos.RuchPoOrbitach((double)nudPredkosc.Value);
            this.Invalidate();
        }

        private void btZmienRozmiar_Click(object sender, EventArgs e)
        {
            try
            {
                kosmos.ZmienRozmiar(cbOpisCiala.SelectedItem.ToString(), Double.Parse(tbZmiany.Text));
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    MessageBox.Show("W polu nie wprowadzono poprawnie liczby");
                else MessageBox.Show(ex.Message);
            }
            this.Invalidate();
        }

        private void btZmienMase_Click(object sender, EventArgs e)
        {
            try
            {
                kosmos.ZmienMase(cbOpisCiala.SelectedItem.ToString(), Double.Parse(tbZmiany.Text));
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    MessageBox.Show("W polu nie wprowadzono poprawnie liczby");
                else MessageBox.Show(ex.Message);
            }
        }

        private void btZmienPromien_Click(object sender, EventArgs e)
        {
            try
            {
                kosmos.ZmienPromien(cbOpisCiala.SelectedItem.ToString(), Double.Parse(tbZmiany.Text));
            }
            catch (Exception ex)
            {
                if (ex is FormatException || ex is OverflowException || ex is ArgumentNullException)
                    MessageBox.Show("W polu nie wprowadzono poprawnie liczby");
                else MessageBox.Show(ex.Message);
            }
            this.Invalidate();
        }
    }
}
