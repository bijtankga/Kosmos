namespace KosmosOkno2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbWyporTypuCiala = new System.Windows.Forms.ComboBox();
            this.lbWyboruTypuCiala = new System.Windows.Forms.Label();
            this.lbWyboruKonstruktora = new System.Windows.Forms.Label();
            this.cbWyboruKonstruktora = new System.Windows.Forms.ComboBox();
            this.lbWprowadzaniaXYZ = new System.Windows.Forms.Label();
            this.lbWprowadzaniaR = new System.Windows.Forms.Label();
            this.lbWprowadzaniaM = new System.Windows.Forms.Label();
            this.lbWprowadzaniaNazwy = new System.Windows.Forms.Label();
            this.lbWprowadzaniaRodzaju = new System.Windows.Forms.Label();
            this.lbWprowadzaniaV = new System.Windows.Forms.Label();
            this.lbWprowadzaniaKatX = new System.Windows.Forms.Label();
            this.lbWprowadzaniaJasnosci = new System.Windows.Forms.Label();
            this.lbWyboruOrbity = new System.Windows.Forms.Label();
            this.tbWprowadzaniaX = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaY = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaZ = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaR = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaM = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaNazwy = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaRodzaju = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaV = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaKatX = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaKatY = new System.Windows.Forms.TextBox();
            this.tbWprowadzaniaJasnosci = new System.Windows.Forms.TextBox();
            this.cbWyboruOrbity = new System.Windows.Forms.ComboBox();
            this.btDodajCialo = new System.Windows.Forms.Button();
            this.cbUsuwania = new System.Windows.Forms.ComboBox();
            this.lbUsuwania = new System.Windows.Forms.Label();
            this.btUsuwania = new System.Windows.Forms.Button();
            this.chbModyfikacjiOrbity = new System.Windows.Forms.CheckBox();
            this.lbModWspolrzedne = new System.Windows.Forms.Label();
            this.tbModX = new System.Windows.Forms.TextBox();
            this.tbModY = new System.Windows.Forms.TextBox();
            this.tbModZ = new System.Windows.Forms.TextBox();
            this.lbModV = new System.Windows.Forms.Label();
            this.tbModV = new System.Windows.Forms.TextBox();
            this.lbModKat = new System.Windows.Forms.Label();
            this.tbModKatX = new System.Windows.Forms.TextBox();
            this.tbModKatY = new System.Windows.Forms.TextBox();
            this.lbOpisCiala = new System.Windows.Forms.Label();
            this.cbOpisCiala = new System.Windows.Forms.ComboBox();
            this.rtbOpisCiala = new System.Windows.Forms.RichTextBox();
            this.plKosmos = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbPrzesunX = new System.Windows.Forms.TextBox();
            this.tbPrzesunY = new System.Windows.Forms.TextBox();
            this.btPrzesun = new System.Windows.Forms.Button();
            this.lbPrzesunX = new System.Windows.Forms.Label();
            this.lbPrzesunY = new System.Windows.Forms.Label();
            this.chbPrzesun = new System.Windows.Forms.CheckBox();
            this.btKrok = new System.Windows.Forms.Button();
            this.nudPredkosc = new System.Windows.Forms.NumericUpDown();
            this.lbPredkosc = new System.Windows.Forms.Label();
            this.tbZmiany = new System.Windows.Forms.TextBox();
            this.btZmienPromien = new System.Windows.Forms.Button();
            this.btZmienMase = new System.Windows.Forms.Button();
            this.btZmienRozmiar = new System.Windows.Forms.Button();
            this.lbIlosc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPredkosc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbWyporTypuCiala
            // 
            this.cbWyporTypuCiala.FormattingEnabled = true;
            this.cbWyporTypuCiala.Items.AddRange(new object[] {
            "Gwiazda",
            "Planeta",
            "Księżyc"});
            this.cbWyporTypuCiala.Location = new System.Drawing.Point(15, 25);
            this.cbWyporTypuCiala.Name = "cbWyporTypuCiala";
            this.cbWyporTypuCiala.Size = new System.Drawing.Size(115, 21);
            this.cbWyporTypuCiala.TabIndex = 0;
            this.cbWyporTypuCiala.SelectedIndexChanged += new System.EventHandler(this.cbWyporTypuCiala_SelectedIndexChanged);
            // 
            // lbWyboruTypuCiala
            // 
            this.lbWyboruTypuCiala.AutoSize = true;
            this.lbWyboruTypuCiala.Location = new System.Drawing.Point(12, 9);
            this.lbWyboruTypuCiala.Name = "lbWyboruTypuCiala";
            this.lbWyboruTypuCiala.Size = new System.Drawing.Size(118, 13);
            this.lbWyboruTypuCiala.TabIndex = 1;
            this.lbWyboruTypuCiala.Text = "Typ Dodawanego Ciala";
            // 
            // lbWyboruKonstruktora
            // 
            this.lbWyboruKonstruktora.AutoSize = true;
            this.lbWyboruKonstruktora.Location = new System.Drawing.Point(12, 49);
            this.lbWyboruKonstruktora.Name = "lbWyboruKonstruktora";
            this.lbWyboruKonstruktora.Size = new System.Drawing.Size(103, 13);
            this.lbWyboruKonstruktora.TabIndex = 2;
            this.lbWyboruKonstruktora.Text = "Rodzaj Konstruktora";
            // 
            // cbWyboruKonstruktora
            // 
            this.cbWyboruKonstruktora.FormattingEnabled = true;
            this.cbWyboruKonstruktora.Location = new System.Drawing.Point(15, 65);
            this.cbWyboruKonstruktora.Name = "cbWyboruKonstruktora";
            this.cbWyboruKonstruktora.Size = new System.Drawing.Size(261, 21);
            this.cbWyboruKonstruktora.TabIndex = 3;
            this.cbWyboruKonstruktora.SelectedIndexChanged += new System.EventHandler(this.cbWyboruKonstruktora_SelectedIndexChanged);
            // 
            // lbWprowadzaniaXYZ
            // 
            this.lbWprowadzaniaXYZ.AutoSize = true;
            this.lbWprowadzaniaXYZ.Location = new System.Drawing.Point(12, 89);
            this.lbWprowadzaniaXYZ.Name = "lbWprowadzaniaXYZ";
            this.lbWprowadzaniaXYZ.Size = new System.Drawing.Size(69, 13);
            this.lbWprowadzaniaXYZ.TabIndex = 4;
            this.lbWprowadzaniaXYZ.Text = "Wspolrzedne";
            // 
            // lbWprowadzaniaR
            // 
            this.lbWprowadzaniaR.AutoSize = true;
            this.lbWprowadzaniaR.Location = new System.Drawing.Point(12, 128);
            this.lbWprowadzaniaR.Name = "lbWprowadzaniaR";
            this.lbWprowadzaniaR.Size = new System.Drawing.Size(45, 13);
            this.lbWprowadzaniaR.TabIndex = 5;
            this.lbWprowadzaniaR.Text = "Promień";
            // 
            // lbWprowadzaniaM
            // 
            this.lbWprowadzaniaM.AutoSize = true;
            this.lbWprowadzaniaM.Location = new System.Drawing.Point(118, 128);
            this.lbWprowadzaniaM.Name = "lbWprowadzaniaM";
            this.lbWprowadzaniaM.Size = new System.Drawing.Size(33, 13);
            this.lbWprowadzaniaM.TabIndex = 6;
            this.lbWprowadzaniaM.Text = "Masa";
            // 
            // lbWprowadzaniaNazwy
            // 
            this.lbWprowadzaniaNazwy.AutoSize = true;
            this.lbWprowadzaniaNazwy.Location = new System.Drawing.Point(12, 167);
            this.lbWprowadzaniaNazwy.Name = "lbWprowadzaniaNazwy";
            this.lbWprowadzaniaNazwy.Size = new System.Drawing.Size(40, 13);
            this.lbWprowadzaniaNazwy.TabIndex = 7;
            this.lbWprowadzaniaNazwy.Text = "Nazwa";
            // 
            // lbWprowadzaniaRodzaju
            // 
            this.lbWprowadzaniaRodzaju.AutoSize = true;
            this.lbWprowadzaniaRodzaju.Location = new System.Drawing.Point(12, 206);
            this.lbWprowadzaniaRodzaju.Name = "lbWprowadzaniaRodzaju";
            this.lbWprowadzaniaRodzaju.Size = new System.Drawing.Size(40, 13);
            this.lbWprowadzaniaRodzaju.TabIndex = 8;
            this.lbWprowadzaniaRodzaju.Text = "Rodzaj";
            // 
            // lbWprowadzaniaV
            // 
            this.lbWprowadzaniaV.AutoSize = true;
            this.lbWprowadzaniaV.Location = new System.Drawing.Point(12, 245);
            this.lbWprowadzaniaV.Name = "lbWprowadzaniaV";
            this.lbWprowadzaniaV.Size = new System.Drawing.Size(91, 13);
            this.lbWprowadzaniaV.TabIndex = 9;
            this.lbWprowadzaniaV.Text = "Prędkość Kątowa";
            // 
            // lbWprowadzaniaKatX
            // 
            this.lbWprowadzaniaKatX.AutoSize = true;
            this.lbWprowadzaniaKatX.Location = new System.Drawing.Point(127, 245);
            this.lbWprowadzaniaKatX.Name = "lbWprowadzaniaKatX";
            this.lbWprowadzaniaKatX.Size = new System.Drawing.Size(120, 13);
            this.lbWprowadzaniaKatX.TabIndex = 10;
            this.lbWprowadzaniaKatX.Text = "Odchylenie Plaszczyzny";
            // 
            // lbWprowadzaniaJasnosci
            // 
            this.lbWprowadzaniaJasnosci.AutoSize = true;
            this.lbWprowadzaniaJasnosci.Location = new System.Drawing.Point(12, 284);
            this.lbWprowadzaniaJasnosci.Name = "lbWprowadzaniaJasnosci";
            this.lbWprowadzaniaJasnosci.Size = new System.Drawing.Size(46, 13);
            this.lbWprowadzaniaJasnosci.TabIndex = 11;
            this.lbWprowadzaniaJasnosci.Text = "Jasność";
            // 
            // lbWyboruOrbity
            // 
            this.lbWyboruOrbity.AutoSize = true;
            this.lbWyboruOrbity.Location = new System.Drawing.Point(12, 323);
            this.lbWyboruOrbity.Name = "lbWyboruOrbity";
            this.lbWyboruOrbity.Size = new System.Drawing.Size(57, 13);
            this.lbWyboruOrbity.TabIndex = 12;
            this.lbWyboruOrbity.Text = "Na Orbicie";
            // 
            // tbWprowadzaniaX
            // 
            this.tbWprowadzaniaX.Location = new System.Drawing.Point(15, 105);
            this.tbWprowadzaniaX.Name = "tbWprowadzaniaX";
            this.tbWprowadzaniaX.Size = new System.Drawing.Size(83, 20);
            this.tbWprowadzaniaX.TabIndex = 16;
            // 
            // tbWprowadzaniaY
            // 
            this.tbWprowadzaniaY.Location = new System.Drawing.Point(104, 105);
            this.tbWprowadzaniaY.Name = "tbWprowadzaniaY";
            this.tbWprowadzaniaY.Size = new System.Drawing.Size(83, 20);
            this.tbWprowadzaniaY.TabIndex = 17;
            // 
            // tbWprowadzaniaZ
            // 
            this.tbWprowadzaniaZ.Location = new System.Drawing.Point(193, 105);
            this.tbWprowadzaniaZ.Name = "tbWprowadzaniaZ";
            this.tbWprowadzaniaZ.Size = new System.Drawing.Size(83, 20);
            this.tbWprowadzaniaZ.TabIndex = 18;
            // 
            // tbWprowadzaniaR
            // 
            this.tbWprowadzaniaR.Location = new System.Drawing.Point(15, 144);
            this.tbWprowadzaniaR.Name = "tbWprowadzaniaR";
            this.tbWprowadzaniaR.Size = new System.Drawing.Size(100, 20);
            this.tbWprowadzaniaR.TabIndex = 19;
            // 
            // tbWprowadzaniaM
            // 
            this.tbWprowadzaniaM.Location = new System.Drawing.Point(121, 144);
            this.tbWprowadzaniaM.Name = "tbWprowadzaniaM";
            this.tbWprowadzaniaM.Size = new System.Drawing.Size(100, 20);
            this.tbWprowadzaniaM.TabIndex = 20;
            // 
            // tbWprowadzaniaNazwy
            // 
            this.tbWprowadzaniaNazwy.Location = new System.Drawing.Point(15, 183);
            this.tbWprowadzaniaNazwy.Name = "tbWprowadzaniaNazwy";
            this.tbWprowadzaniaNazwy.Size = new System.Drawing.Size(261, 20);
            this.tbWprowadzaniaNazwy.TabIndex = 21;
            // 
            // tbWprowadzaniaRodzaju
            // 
            this.tbWprowadzaniaRodzaju.Location = new System.Drawing.Point(15, 222);
            this.tbWprowadzaniaRodzaju.Name = "tbWprowadzaniaRodzaju";
            this.tbWprowadzaniaRodzaju.Size = new System.Drawing.Size(261, 20);
            this.tbWprowadzaniaRodzaju.TabIndex = 22;
            // 
            // tbWprowadzaniaV
            // 
            this.tbWprowadzaniaV.Location = new System.Drawing.Point(15, 261);
            this.tbWprowadzaniaV.Name = "tbWprowadzaniaV";
            this.tbWprowadzaniaV.Size = new System.Drawing.Size(100, 20);
            this.tbWprowadzaniaV.TabIndex = 23;
            // 
            // tbWprowadzaniaKatX
            // 
            this.tbWprowadzaniaKatX.Location = new System.Drawing.Point(130, 261);
            this.tbWprowadzaniaKatX.Name = "tbWprowadzaniaKatX";
            this.tbWprowadzaniaKatX.Size = new System.Drawing.Size(70, 20);
            this.tbWprowadzaniaKatX.TabIndex = 24;
            // 
            // tbWprowadzaniaKatY
            // 
            this.tbWprowadzaniaKatY.Location = new System.Drawing.Point(206, 261);
            this.tbWprowadzaniaKatY.Name = "tbWprowadzaniaKatY";
            this.tbWprowadzaniaKatY.Size = new System.Drawing.Size(70, 20);
            this.tbWprowadzaniaKatY.TabIndex = 25;
            // 
            // tbWprowadzaniaJasnosci
            // 
            this.tbWprowadzaniaJasnosci.Location = new System.Drawing.Point(15, 300);
            this.tbWprowadzaniaJasnosci.Name = "tbWprowadzaniaJasnosci";
            this.tbWprowadzaniaJasnosci.Size = new System.Drawing.Size(100, 20);
            this.tbWprowadzaniaJasnosci.TabIndex = 26;
            // 
            // cbWyboruOrbity
            // 
            this.cbWyboruOrbity.FormattingEnabled = true;
            this.cbWyboruOrbity.Location = new System.Drawing.Point(15, 339);
            this.cbWyboruOrbity.Name = "cbWyboruOrbity";
            this.cbWyboruOrbity.Size = new System.Drawing.Size(261, 21);
            this.cbWyboruOrbity.TabIndex = 27;
            // 
            // btDodajCialo
            // 
            this.btDodajCialo.Enabled = false;
            this.btDodajCialo.Location = new System.Drawing.Point(136, 7);
            this.btDodajCialo.Name = "btDodajCialo";
            this.btDodajCialo.Size = new System.Drawing.Size(140, 52);
            this.btDodajCialo.TabIndex = 28;
            this.btDodajCialo.Text = "Dodaj Ciało Niebieskie";
            this.btDodajCialo.UseVisualStyleBackColor = true;
            this.btDodajCialo.Click += new System.EventHandler(this.btDodajCialo_Click);
            // 
            // cbUsuwania
            // 
            this.cbUsuwania.FormattingEnabled = true;
            this.cbUsuwania.Location = new System.Drawing.Point(12, 583);
            this.cbUsuwania.Name = "cbUsuwania";
            this.cbUsuwania.Size = new System.Drawing.Size(261, 21);
            this.cbUsuwania.TabIndex = 29;
            this.cbUsuwania.SelectedIndexChanged += new System.EventHandler(this.cbUsuwania_SelectedIndexChanged);
            // 
            // lbUsuwania
            // 
            this.lbUsuwania.AutoSize = true;
            this.lbUsuwania.Location = new System.Drawing.Point(9, 567);
            this.lbUsuwania.Name = "lbUsuwania";
            this.lbUsuwania.Size = new System.Drawing.Size(147, 13);
            this.lbUsuwania.TabIndex = 30;
            this.lbUsuwania.Text = "Cialo Niebieskie do Usuniecia";
            // 
            // btUsuwania
            // 
            this.btUsuwania.Enabled = false;
            this.btUsuwania.Location = new System.Drawing.Point(12, 616);
            this.btUsuwania.Name = "btUsuwania";
            this.btUsuwania.Size = new System.Drawing.Size(140, 50);
            this.btUsuwania.TabIndex = 31;
            this.btUsuwania.Text = "Usuń Ciało Niebieskie";
            this.btUsuwania.UseVisualStyleBackColor = true;
            this.btUsuwania.Click += new System.EventHandler(this.btUsuwania_Click);
            // 
            // chbModyfikacjiOrbity
            // 
            this.chbModyfikacjiOrbity.AutoSize = true;
            this.chbModyfikacjiOrbity.Enabled = false;
            this.chbModyfikacjiOrbity.Location = new System.Drawing.Point(15, 387);
            this.chbModyfikacjiOrbity.Name = "chbModyfikacjiOrbity";
            this.chbModyfikacjiOrbity.Size = new System.Drawing.Size(108, 17);
            this.chbModyfikacjiOrbity.TabIndex = 32;
            this.chbModyfikacjiOrbity.Text = "Zmodyfikuj Orbite";
            this.chbModyfikacjiOrbity.UseVisualStyleBackColor = true;
            this.chbModyfikacjiOrbity.CheckedChanged += new System.EventHandler(this.chbModyfikacjiOrbity_CheckedChanged);
            // 
            // lbModWspolrzedne
            // 
            this.lbModWspolrzedne.AutoSize = true;
            this.lbModWspolrzedne.Location = new System.Drawing.Point(12, 407);
            this.lbModWspolrzedne.Name = "lbModWspolrzedne";
            this.lbModWspolrzedne.Size = new System.Drawing.Size(71, 13);
            this.lbModWspolrzedne.TabIndex = 33;
            this.lbModWspolrzedne.Text = "Współrzędne";
            // 
            // tbModX
            // 
            this.tbModX.Enabled = false;
            this.tbModX.Location = new System.Drawing.Point(15, 423);
            this.tbModX.Name = "tbModX";
            this.tbModX.Size = new System.Drawing.Size(83, 20);
            this.tbModX.TabIndex = 34;
            // 
            // tbModY
            // 
            this.tbModY.Enabled = false;
            this.tbModY.Location = new System.Drawing.Point(104, 423);
            this.tbModY.Name = "tbModY";
            this.tbModY.Size = new System.Drawing.Size(83, 20);
            this.tbModY.TabIndex = 35;
            // 
            // tbModZ
            // 
            this.tbModZ.Enabled = false;
            this.tbModZ.Location = new System.Drawing.Point(193, 423);
            this.tbModZ.Name = "tbModZ";
            this.tbModZ.Size = new System.Drawing.Size(83, 20);
            this.tbModZ.TabIndex = 36;
            // 
            // lbModV
            // 
            this.lbModV.AutoSize = true;
            this.lbModV.Location = new System.Drawing.Point(12, 446);
            this.lbModV.Name = "lbModV";
            this.lbModV.Size = new System.Drawing.Size(185, 13);
            this.lbModV.TabIndex = 37;
            this.lbModV.Text = "Predkosc Katowa Na Glownej Orbicie";
            // 
            // tbModV
            // 
            this.tbModV.Enabled = false;
            this.tbModV.Location = new System.Drawing.Point(15, 462);
            this.tbModV.Name = "tbModV";
            this.tbModV.Size = new System.Drawing.Size(100, 20);
            this.tbModV.TabIndex = 38;
            // 
            // lbModKat
            // 
            this.lbModKat.AutoSize = true;
            this.lbModKat.Location = new System.Drawing.Point(12, 485);
            this.lbModKat.Name = "lbModKat";
            this.lbModKat.Size = new System.Drawing.Size(120, 13);
            this.lbModKat.TabIndex = 39;
            this.lbModKat.Text = "Odchylenie Plaszczyzny";
            // 
            // tbModKatX
            // 
            this.tbModKatX.Enabled = false;
            this.tbModKatX.Location = new System.Drawing.Point(15, 501);
            this.tbModKatX.Name = "tbModKatX";
            this.tbModKatX.Size = new System.Drawing.Size(70, 20);
            this.tbModKatX.TabIndex = 40;
            // 
            // tbModKatY
            // 
            this.tbModKatY.Enabled = false;
            this.tbModKatY.Location = new System.Drawing.Point(91, 501);
            this.tbModKatY.Name = "tbModKatY";
            this.tbModKatY.Size = new System.Drawing.Size(70, 20);
            this.tbModKatY.TabIndex = 41;
            // 
            // lbOpisCiala
            // 
            this.lbOpisCiala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbOpisCiala.AutoSize = true;
            this.lbOpisCiala.Location = new System.Drawing.Point(431, 556);
            this.lbOpisCiala.Name = "lbOpisCiala";
            this.lbOpisCiala.Size = new System.Drawing.Size(54, 13);
            this.lbOpisCiala.TabIndex = 42;
            this.lbOpisCiala.Text = "Opis Ciala";
            // 
            // cbOpisCiala
            // 
            this.cbOpisCiala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbOpisCiala.FormattingEnabled = true;
            this.cbOpisCiala.Location = new System.Drawing.Point(491, 556);
            this.cbOpisCiala.Name = "cbOpisCiala";
            this.cbOpisCiala.Size = new System.Drawing.Size(261, 21);
            this.cbOpisCiala.TabIndex = 43;
            this.cbOpisCiala.SelectedIndexChanged += new System.EventHandler(this.cbOpisCiala_SelectedIndexChanged);
            // 
            // rtbOpisCiala
            // 
            this.rtbOpisCiala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbOpisCiala.Enabled = false;
            this.rtbOpisCiala.Location = new System.Drawing.Point(434, 583);
            this.rtbOpisCiala.Name = "rtbOpisCiala";
            this.rtbOpisCiala.Size = new System.Drawing.Size(318, 96);
            this.rtbOpisCiala.TabIndex = 44;
            this.rtbOpisCiala.Text = "";
            // 
            // plKosmos
            // 
            this.plKosmos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plKosmos.BackColor = System.Drawing.Color.Black;
            this.plKosmos.Location = new System.Drawing.Point(288, 25);
            this.plKosmos.Name = "plKosmos";
            this.plKosmos.Size = new System.Drawing.Size(843, 525);
            this.plKosmos.TabIndex = 45;
            // 
            // btStart
            // 
            this.btStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btStart.Location = new System.Drawing.Point(991, 632);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(140, 50);
            this.btStart.TabIndex = 46;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbPrzesunX
            // 
            this.tbPrzesunX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrzesunX.Location = new System.Drawing.Point(328, 608);
            this.tbPrzesunX.Name = "tbPrzesunX";
            this.tbPrzesunX.Size = new System.Drawing.Size(100, 20);
            this.tbPrzesunX.TabIndex = 47;
            // 
            // tbPrzesunY
            // 
            this.tbPrzesunY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPrzesunY.Location = new System.Drawing.Point(328, 628);
            this.tbPrzesunY.Name = "tbPrzesunY";
            this.tbPrzesunY.Size = new System.Drawing.Size(100, 20);
            this.tbPrzesunY.TabIndex = 48;
            // 
            // btPrzesun
            // 
            this.btPrzesun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrzesun.Enabled = false;
            this.btPrzesun.Location = new System.Drawing.Point(288, 556);
            this.btPrzesun.Name = "btPrzesun";
            this.btPrzesun.Size = new System.Drawing.Size(140, 46);
            this.btPrzesun.TabIndex = 49;
            this.btPrzesun.Text = "Przesun";
            this.btPrzesun.UseVisualStyleBackColor = true;
            this.btPrzesun.Click += new System.EventHandler(this.btPrzesun_Click);
            // 
            // lbPrzesunX
            // 
            this.lbPrzesunX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrzesunX.AutoSize = true;
            this.lbPrzesunX.Location = new System.Drawing.Point(308, 611);
            this.lbPrzesunX.Name = "lbPrzesunX";
            this.lbPrzesunX.Size = new System.Drawing.Size(14, 13);
            this.lbPrzesunX.TabIndex = 50;
            this.lbPrzesunX.Text = "X";
            // 
            // lbPrzesunY
            // 
            this.lbPrzesunY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPrzesunY.AutoSize = true;
            this.lbPrzesunY.Location = new System.Drawing.Point(308, 631);
            this.lbPrzesunY.Name = "lbPrzesunY";
            this.lbPrzesunY.Size = new System.Drawing.Size(14, 13);
            this.lbPrzesunY.TabIndex = 51;
            this.lbPrzesunY.Text = "Y";
            // 
            // chbPrzesun
            // 
            this.chbPrzesun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbPrzesun.AutoSize = true;
            this.chbPrzesun.Location = new System.Drawing.Point(328, 650);
            this.chbPrzesun.Name = "chbPrzesun";
            this.chbPrzesun.Size = new System.Drawing.Size(72, 17);
            this.chbPrzesun.TabIndex = 53;
            this.chbPrzesun.Text = "Wszystko";
            this.chbPrzesun.UseVisualStyleBackColor = true;
            // 
            // btKrok
            // 
            this.btKrok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btKrok.Location = new System.Drawing.Point(991, 556);
            this.btKrok.Name = "btKrok";
            this.btKrok.Size = new System.Drawing.Size(140, 50);
            this.btKrok.TabIndex = 54;
            this.btKrok.Text = "Krok";
            this.btKrok.UseVisualStyleBackColor = true;
            this.btKrok.Click += new System.EventHandler(this.btKrok_Click);
            // 
            // nudPredkosc
            // 
            this.nudPredkosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nudPredkosc.Location = new System.Drawing.Point(1050, 609);
            this.nudPredkosc.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPredkosc.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.nudPredkosc.Name = "nudPredkosc";
            this.nudPredkosc.Size = new System.Drawing.Size(81, 20);
            this.nudPredkosc.TabIndex = 56;
            this.nudPredkosc.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lbPredkosc
            // 
            this.lbPredkosc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPredkosc.AutoSize = true;
            this.lbPredkosc.Location = new System.Drawing.Point(992, 615);
            this.lbPredkosc.Name = "lbPredkosc";
            this.lbPredkosc.Size = new System.Drawing.Size(52, 13);
            this.lbPredkosc.TabIndex = 57;
            this.lbPredkosc.Text = "Prędkość";
            // 
            // tbZmiany
            // 
            this.tbZmiany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbZmiany.Location = new System.Drawing.Point(758, 659);
            this.tbZmiany.Name = "tbZmiany";
            this.tbZmiany.Size = new System.Drawing.Size(98, 20);
            this.tbZmiany.TabIndex = 58;
            // 
            // btZmienPromien
            // 
            this.btZmienPromien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZmienPromien.Enabled = false;
            this.btZmienPromien.Location = new System.Drawing.Point(758, 632);
            this.btZmienPromien.Name = "btZmienPromien";
            this.btZmienPromien.Size = new System.Drawing.Size(98, 23);
            this.btZmienPromien.TabIndex = 59;
            this.btZmienPromien.Text = "Zmien Promien";
            this.btZmienPromien.UseVisualStyleBackColor = true;
            this.btZmienPromien.Click += new System.EventHandler(this.btZmienPromien_Click);
            // 
            // btZmienMase
            // 
            this.btZmienMase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZmienMase.Enabled = false;
            this.btZmienMase.Location = new System.Drawing.Point(758, 608);
            this.btZmienMase.Name = "btZmienMase";
            this.btZmienMase.Size = new System.Drawing.Size(98, 23);
            this.btZmienMase.TabIndex = 60;
            this.btZmienMase.Text = "Zmień Mase";
            this.btZmienMase.UseVisualStyleBackColor = true;
            this.btZmienMase.Click += new System.EventHandler(this.btZmienMase_Click);
            // 
            // btZmienRozmiar
            // 
            this.btZmienRozmiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btZmienRozmiar.Enabled = false;
            this.btZmienRozmiar.Location = new System.Drawing.Point(758, 583);
            this.btZmienRozmiar.Name = "btZmienRozmiar";
            this.btZmienRozmiar.Size = new System.Drawing.Size(98, 23);
            this.btZmienRozmiar.TabIndex = 61;
            this.btZmienRozmiar.Text = "Zmień Rozmiar";
            this.btZmienRozmiar.UseVisualStyleBackColor = true;
            this.btZmienRozmiar.Click += new System.EventHandler(this.btZmienRozmiar_Click);
            // 
            // lbIlosc
            // 
            this.lbIlosc.AutoSize = true;
            this.lbIlosc.Location = new System.Drawing.Point(285, 7);
            this.lbIlosc.Name = "lbIlosc";
            this.lbIlosc.Size = new System.Drawing.Size(153, 13);
            this.lbIlosc.TabIndex = 62;
            this.lbIlosc.Text = "W kosmosie znajduje sie 0 ciał";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 689);
            this.Controls.Add(this.lbIlosc);
            this.Controls.Add(this.btZmienRozmiar);
            this.Controls.Add(this.btZmienMase);
            this.Controls.Add(this.btZmienPromien);
            this.Controls.Add(this.tbZmiany);
            this.Controls.Add(this.lbPredkosc);
            this.Controls.Add(this.nudPredkosc);
            this.Controls.Add(this.btKrok);
            this.Controls.Add(this.chbPrzesun);
            this.Controls.Add(this.lbPrzesunY);
            this.Controls.Add(this.lbPrzesunX);
            this.Controls.Add(this.btPrzesun);
            this.Controls.Add(this.tbPrzesunY);
            this.Controls.Add(this.tbPrzesunX);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.plKosmos);
            this.Controls.Add(this.rtbOpisCiala);
            this.Controls.Add(this.cbOpisCiala);
            this.Controls.Add(this.lbOpisCiala);
            this.Controls.Add(this.tbModKatY);
            this.Controls.Add(this.tbModKatX);
            this.Controls.Add(this.lbModKat);
            this.Controls.Add(this.tbModV);
            this.Controls.Add(this.lbModV);
            this.Controls.Add(this.tbModZ);
            this.Controls.Add(this.tbModY);
            this.Controls.Add(this.tbModX);
            this.Controls.Add(this.lbModWspolrzedne);
            this.Controls.Add(this.chbModyfikacjiOrbity);
            this.Controls.Add(this.btUsuwania);
            this.Controls.Add(this.lbUsuwania);
            this.Controls.Add(this.cbUsuwania);
            this.Controls.Add(this.btDodajCialo);
            this.Controls.Add(this.cbWyboruOrbity);
            this.Controls.Add(this.tbWprowadzaniaJasnosci);
            this.Controls.Add(this.tbWprowadzaniaKatY);
            this.Controls.Add(this.tbWprowadzaniaKatX);
            this.Controls.Add(this.tbWprowadzaniaV);
            this.Controls.Add(this.tbWprowadzaniaRodzaju);
            this.Controls.Add(this.tbWprowadzaniaNazwy);
            this.Controls.Add(this.tbWprowadzaniaM);
            this.Controls.Add(this.tbWprowadzaniaR);
            this.Controls.Add(this.tbWprowadzaniaZ);
            this.Controls.Add(this.tbWprowadzaniaY);
            this.Controls.Add(this.tbWprowadzaniaX);
            this.Controls.Add(this.lbWyboruOrbity);
            this.Controls.Add(this.lbWprowadzaniaJasnosci);
            this.Controls.Add(this.lbWprowadzaniaKatX);
            this.Controls.Add(this.lbWprowadzaniaV);
            this.Controls.Add(this.lbWprowadzaniaRodzaju);
            this.Controls.Add(this.lbWprowadzaniaNazwy);
            this.Controls.Add(this.lbWprowadzaniaM);
            this.Controls.Add(this.lbWprowadzaniaR);
            this.Controls.Add(this.lbWprowadzaniaXYZ);
            this.Controls.Add(this.cbWyboruKonstruktora);
            this.Controls.Add(this.lbWyboruKonstruktora);
            this.Controls.Add(this.lbWyboruTypuCiala);
            this.Controls.Add(this.cbWyporTypuCiala);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kosmos";
            ((System.ComponentModel.ISupportInitialize)(this.nudPredkosc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWyporTypuCiala;
        private System.Windows.Forms.Label lbWyboruTypuCiala;
        private System.Windows.Forms.Label lbWyboruKonstruktora;
        private System.Windows.Forms.ComboBox cbWyboruKonstruktora;
        private System.Windows.Forms.Label lbWprowadzaniaXYZ;
        private System.Windows.Forms.Label lbWprowadzaniaR;
        private System.Windows.Forms.Label lbWprowadzaniaM;
        private System.Windows.Forms.Label lbWprowadzaniaNazwy;
        private System.Windows.Forms.Label lbWprowadzaniaRodzaju;
        private System.Windows.Forms.Label lbWprowadzaniaV;
        private System.Windows.Forms.Label lbWprowadzaniaKatX;
        private System.Windows.Forms.Label lbWprowadzaniaJasnosci;
        private System.Windows.Forms.Label lbWyboruOrbity;
        private System.Windows.Forms.TextBox tbWprowadzaniaX;
        private System.Windows.Forms.TextBox tbWprowadzaniaY;
        private System.Windows.Forms.TextBox tbWprowadzaniaZ;
        private System.Windows.Forms.TextBox tbWprowadzaniaR;
        private System.Windows.Forms.TextBox tbWprowadzaniaM;
        private System.Windows.Forms.TextBox tbWprowadzaniaNazwy;
        private System.Windows.Forms.TextBox tbWprowadzaniaRodzaju;
        private System.Windows.Forms.TextBox tbWprowadzaniaV;
        private System.Windows.Forms.TextBox tbWprowadzaniaKatX;
        private System.Windows.Forms.TextBox tbWprowadzaniaKatY;
        private System.Windows.Forms.TextBox tbWprowadzaniaJasnosci;
        private System.Windows.Forms.ComboBox cbWyboruOrbity;
        private System.Windows.Forms.Button btDodajCialo;
        private System.Windows.Forms.ComboBox cbUsuwania;
        private System.Windows.Forms.Label lbUsuwania;
        private System.Windows.Forms.Button btUsuwania;
        private System.Windows.Forms.CheckBox chbModyfikacjiOrbity;
        private System.Windows.Forms.Label lbModWspolrzedne;
        private System.Windows.Forms.TextBox tbModX;
        private System.Windows.Forms.TextBox tbModY;
        private System.Windows.Forms.TextBox tbModZ;
        private System.Windows.Forms.Label lbModV;
        private System.Windows.Forms.TextBox tbModV;
        private System.Windows.Forms.Label lbModKat;
        private System.Windows.Forms.TextBox tbModKatX;
        private System.Windows.Forms.TextBox tbModKatY;
        private System.Windows.Forms.Label lbOpisCiala;
        private System.Windows.Forms.ComboBox cbOpisCiala;
        private System.Windows.Forms.RichTextBox rtbOpisCiala;
        private System.Windows.Forms.Panel plKosmos;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbPrzesunX;
        private System.Windows.Forms.TextBox tbPrzesunY;
        private System.Windows.Forms.Button btPrzesun;
        private System.Windows.Forms.Label lbPrzesunX;
        private System.Windows.Forms.Label lbPrzesunY;
        private System.Windows.Forms.CheckBox chbPrzesun;
        private System.Windows.Forms.Button btKrok;
        private System.Windows.Forms.NumericUpDown nudPredkosc;
        private System.Windows.Forms.Label lbPredkosc;
        private System.Windows.Forms.TextBox tbZmiany;
        private System.Windows.Forms.Button btZmienPromien;
        private System.Windows.Forms.Button btZmienMase;
        private System.Windows.Forms.Button btZmienRozmiar;
        private System.Windows.Forms.Label lbIlosc;
    }
}

