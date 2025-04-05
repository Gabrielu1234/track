using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LibrarieClase;
using LibrarieDate;
using System.Configuration;


namespace track_ui
{
    public partial class Form1 : Form
    {
        public int top = 2;
        private Label lblTitlu;

        //Aliment
        AdministrareAliment adminAliment;

        private Label lblAlimente;
        private Label lblaDenumire;
        private Label lblaCalorii;
        private Label lblaProteine;
        private Label lblaCarbohidrati;
        private Label lblaGrasimi;
        private Label lblaTipProdus;

        private Label[] lblsaDenumire;
        private Label[] lblsaCalorii;
        private Label[] lblsaProteine;
        private Label[] lblsaCarbohidrati;
        private Label[] lblsaGrasimi;
        private Label[] lblsaTipProdus;

        private Label txtaliment;
        private TextBox txtDenumire;
        private TextBox txtCalorii;
        private TextBox txtProteine;
        private TextBox txtCarbohidrati;
        private TextBox txtGrasimi;
        private ComboBox txtTipProdus;


        //Persoana
        AdministrarePersoane adminPersoane;

        private Label lblPersoane;
        private Label lblpNume;
        private Label lblpCaloriiConsumate;
        private Label lblpProteineConsumate;
        private Label lblpCarbohidratiConsumati;
        private Label lblpGrasimiConsumate;
        private Label lblpCaloriiMentinere;
        private Label lblpMese;
        private Label lblpActivitate;

        private Label[] lblspNume;
        private Label[] lblspCaloriiConsumate;
        private Label[] lblspProteineConsumate;
        private Label[] lblspCarbohidratiConsumati;
        private Label[] lblspGrasimiConsumate;
        private Label[] lblspCaloriiMentinere;
        private Label[] lblspMese;
        private Label[] lblspActivitate;

        private Label txtpersoana;
        private TextBox txtNume;
        private TextBox txtCaloriiMentinere;
        private ListBox txtActivitate;

        //Butoane
        private Button AddPersoana;
        private Button AddAliment;
        private Button RefreshDate;

        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 125;


        public Form1()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;

            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisierPersoane"];

            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);


            //setate proprietati
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.ForeColor = Color.Yellow;
            this.Text = "Tracker";
            this.BackColor = Color.DarkBlue;

            //Titlu
            lblTitlu = new Label();
            lblTitlu.Text = "Tracker";
            lblTitlu.Width = LATIME_CONTROL;
            lblTitlu.Left = 4 * DIMENSIUNE_PAS_X;
            lblTitlu.Top = 0;
            lblTitlu.AutoSize = true;
            lblTitlu.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTitlu.ForeColor = Color.Orange;
            this.Controls.Add(lblTitlu);

            //adauga buton refresh
            RefreshDate = new Button();
            RefreshDate.Text = "Refresh Date";
            RefreshDate.Width = LATIME_CONTROL;
            RefreshDate.Left = 7 * DIMENSIUNE_PAS_X;
            RefreshDate.Top = 0;
            RefreshDate.Click += RefreshDate_Click;
            RefreshDate.AutoSize = true;
            RefreshDate.BackColor = Color.White;
            RefreshDate.ForeColor = Color.Black;
            this.Controls.Add(RefreshDate);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareTxtAliment();
            AfisareTxtPersoana();
            AfisareAlimente();
            AfisarePersoane();

        }

        private void RefreshDate_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(lblTitlu);
            this.Controls.Add(RefreshDate);
            top = 2;
            AfisareTxtAliment();
            AfisareTxtPersoana();
            AfisareAlimente();
            AfisarePersoane();
        }
        //Alimente
        private void AfisareTxtAliment()
        {
            top++;

            txtaliment = new Label();
            txtaliment.Text = "Adauga Aliment";
            txtaliment.Width = LATIME_CONTROL;
            txtaliment.AutoSize = true;
            txtaliment.Top = (top-1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtaliment);


            //adauga control tip label pt denumire
            lblaDenumire = new Label();
            lblaDenumire.Text = "Denumire";
            lblaDenumire.Width = LATIME_CONTROL;
            lblaDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            lblaDenumire.Top = (top-1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaDenumire);

            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL;
            txtDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            txtDenumire.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtDenumire);

            //adauga control tip label pt calorii
            lblaCalorii = new Label();
            lblaCalorii.Text = "Calorii";
            lblaCalorii.Width = LATIME_CONTROL;
            lblaCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            lblaCalorii.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaCalorii);

            txtCalorii = new TextBox();
            txtCalorii.Width = LATIME_CONTROL;
            txtCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            txtCalorii.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCalorii);

            //adauga control tip label pt proteine
            lblaProteine = new Label();
            lblaProteine.Text = "Proteine";
            lblaProteine.Width = LATIME_CONTROL;
            lblaProteine.Left = 3 * DIMENSIUNE_PAS_X;
            lblaProteine.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaProteine);

            txtProteine = new TextBox();
            txtProteine.Width = LATIME_CONTROL;
            txtProteine.Left = 3 * DIMENSIUNE_PAS_X;
            txtProteine.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtProteine);

            //adauga control tip label pt carbohidrati
            lblaCarbohidrati = new Label();
            lblaCarbohidrati.Text = "Carbohidrati";
            lblaCarbohidrati.Width = LATIME_CONTROL;
            lblaCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            lblaCarbohidrati.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaCarbohidrati);

            txtCarbohidrati = new TextBox();
            txtCarbohidrati.Width = LATIME_CONTROL;
            txtCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            txtCarbohidrati.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCarbohidrati);

            //adauga control tip label pt grasimi
            lblaGrasimi = new Label();
            lblaGrasimi.Text = "Grasimi";
            lblaGrasimi.Width = LATIME_CONTROL;
            lblaGrasimi.Left = 5 * DIMENSIUNE_PAS_X;
            lblaGrasimi.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaGrasimi);

            txtGrasimi = new TextBox();
            txtGrasimi.Width = LATIME_CONTROL;
            txtGrasimi.Left = 5 * DIMENSIUNE_PAS_X;
            txtGrasimi.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtGrasimi);

            //adauga control tip label pt tip produs
            lblaTipProdus = new Label();
            lblaTipProdus.Text = "Tip Produs";
            lblaTipProdus.Width = LATIME_CONTROL;
            lblaTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            lblaTipProdus.Top = (top - 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblaTipProdus);

            txtTipProdus = new ComboBox ();
            txtTipProdus.Width = LATIME_CONTROL;
            txtTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            txtTipProdus.Top = top * DIMENISUNE_PAS_Y;
            txtTipProdus.Items.Add(Aliment.TipProdus.Fructe);
            txtTipProdus.Items.Add(Aliment.TipProdus.Legume);
            txtTipProdus.Items.Add(Aliment.TipProdus.Carne);
            txtTipProdus.Items.Add(Aliment.TipProdus.Lactate);
            txtTipProdus.Items.Add(Aliment.TipProdus.Cereale);
            txtTipProdus.Items.Add(Aliment.TipProdus.Dulciuri);
            txtTipProdus.Items.Add(Aliment.TipProdus.Bauturi);
            txtTipProdus.Items.Add(Aliment.TipProdus.Altele);
            this.Controls.Add(txtTipProdus);

            //adauga control tip buton pt adauga aliment
            AddAliment = new Button();
            AddAliment.Text = "Adauga Aliment";
            AddAliment.Width = LATIME_CONTROL;
            AddAliment.Left = 7 * DIMENSIUNE_PAS_X;
            AddAliment.Top = top * DIMENISUNE_PAS_Y;
            AddAliment.Click += AdaugaAliment;
            AddAliment.AutoSize = true;
            AddAliment.BackColor = Color.White;
            AddAliment.ForeColor = Color.Black;
            this.Controls.Add(AddAliment);

        }
        private void AfisareAlimente()
        {
            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);

            top = top + 5;

            //adauga o linie care sa scrie Alimente in mijloc
            lblAlimente = new Label();
            lblAlimente.Text = "Alimente";
            lblAlimente.Width = LATIME_CONTROL;
            lblAlimente.Left = 4 * DIMENSIUNE_PAS_X;
            lblAlimente.Top = top * DIMENISUNE_PAS_Y;
            lblAlimente.ForeColor = Color.Orange;
            this.Controls.Add(lblAlimente);

            top++; 

            //adaugare control tip label pt denumire
            lblaDenumire = new Label();
            lblaDenumire.Text = "Denumire";
            lblaDenumire.Width = LATIME_CONTROL;
            lblaDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            lblaDenumire.Top = top * DIMENISUNE_PAS_Y;
            lblaDenumire.ForeColor = Color.Red;
            this.Controls.Add(lblaDenumire);

            //adaugare control tip label pt calorii
            lblaCalorii = new Label();
            lblaCalorii.Text = "Calorii";
            lblaCalorii.Width = LATIME_CONTROL;
            lblaCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            lblaCalorii.Top = top * DIMENISUNE_PAS_Y;
            lblaCalorii.ForeColor = Color.Red;
            this.Controls.Add(lblaCalorii);

            //adaugare control tip label pt proteine
            lblaProteine = new Label();
            lblaProteine.Text = "Proteine";
            lblaProteine.Width = LATIME_CONTROL;
            lblaProteine.Left = 3 * DIMENSIUNE_PAS_X;
            lblaProteine.Top = top * DIMENISUNE_PAS_Y;
            lblaProteine.ForeColor = Color.Red;
            this.Controls.Add(lblaProteine);

            //adaugare control tip label pt carbohidrati
            lblaCarbohidrati = new Label();
            lblaCarbohidrati.Text = "Carbohidrati";
            lblaCarbohidrati.Width = LATIME_CONTROL;
            lblaCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            lblaCarbohidrati.Top = top * DIMENISUNE_PAS_Y;
            lblaCarbohidrati.ForeColor = Color.Red;
            this.Controls.Add(lblaCarbohidrati);

            //adaugare control tip label pt grasimi
            lblaGrasimi = new Label();
            lblaGrasimi.Text = "Grasimi";
            lblaGrasimi.Width = LATIME_CONTROL;
            lblaGrasimi.Left = 5 * DIMENSIUNE_PAS_X;
            lblaGrasimi.Top = top * DIMENISUNE_PAS_Y;
            lblaGrasimi.ForeColor = Color.Red;
            this.Controls.Add(lblaGrasimi);

            //adaugare control tip label pt tip produs
            lblaTipProdus = new Label();
            lblaTipProdus.Text = "Tip Produs";
            lblaTipProdus.Width = LATIME_CONTROL;
            lblaTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            lblaTipProdus.Top = top * DIMENISUNE_PAS_Y;
            lblaTipProdus.ForeColor = Color.Red;
            this.Controls.Add(lblaTipProdus);

            lblsaDenumire = new Label[nrAlimente];
            lblsaCalorii = new Label[nrAlimente];
            lblsaProteine = new Label[nrAlimente];
            lblsaCarbohidrati = new Label[nrAlimente];
            lblsaGrasimi = new Label[nrAlimente];
            lblsaTipProdus = new Label[nrAlimente];

            top++; 
            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                //Denumire
                lblsaDenumire[i] = new Label();
                lblsaDenumire[i].Width = LATIME_CONTROL;
                lblsaDenumire[i].Left = DIMENSIUNE_PAS_X;
                lblsaDenumire[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaDenumire[i].Text = aliment.denumire;
                this.Controls.Add(lblsaDenumire[i]);

                //Calorii
                lblsaCalorii[i] = new Label();
                lblsaCalorii[i].Width = LATIME_CONTROL;
                lblsaCalorii[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsaCalorii[i].Top = (i + top ) * DIMENISUNE_PAS_Y;
                lblsaCalorii[i].Text = aliment.calorii.ToString();
                this.Controls.Add(lblsaCalorii[i]);

                //Proteine
                lblsaProteine[i] = new Label();
                lblsaProteine[i].Width = LATIME_CONTROL;
                lblsaProteine[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsaProteine[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaProteine[i].Text = aliment.proteine.ToString();
                this.Controls.Add(lblsaProteine[i]);

                //Carbohidrati
                lblsaCarbohidrati[i] = new Label();
                lblsaCarbohidrati[i].Width = LATIME_CONTROL;
                lblsaCarbohidrati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsaCarbohidrati[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaCarbohidrati[i].Text = aliment.carbohidrati.ToString();
                this.Controls.Add(lblsaCarbohidrati[i]);

                //Grasimi
                lblsaGrasimi[i] = new Label();
                lblsaGrasimi[i].Width = LATIME_CONTROL;
                lblsaGrasimi[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsaGrasimi[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaGrasimi[i].Text = aliment.grasimi.ToString();
                this.Controls.Add(lblsaGrasimi[i]);

                //Tip Produs
                lblsaTipProdus[i] = new Label();
                lblsaTipProdus[i].Width = LATIME_CONTROL;
                lblsaTipProdus[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsaTipProdus[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaTipProdus[i].Text = aliment.tip_produs.ToString();
                this.Controls.Add(lblsaTipProdus[i]);

                i++;
            }
            top = top + i;
        }
        private void AdaugaAliment(object sender, EventArgs e)
        {
            string denumire = txtDenumire.Text;
            int calorii = int.Parse(txtCalorii.Text);
            int proteine = int.Parse(txtProteine.Text);
            int carbohidrati = int.Parse(txtCarbohidrati.Text);
            int grasimi = int.Parse(txtGrasimi.Text);
            int tip_produs = txtTipProdus.SelectedIndex + 1;

            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);
            int nextId;
            if (nrAlimente > 0)
            {
                nextId = alimente.Max(a => a.id_aliment) + 1;
            }
            else
            {
                nextId = 1;
            }

            Aliment aliment = new Aliment(nextId, denumire, calorii, proteine, carbohidrati, grasimi, (Aliment.TipProdus)tip_produs);
            adminAliment.AdaugaAliment(aliment);
        }

        //Persoane
        private void AfisareTxtPersoana()
        {
            top++;

            txtpersoana = new Label();
            txtpersoana.Text = "Adauga Pers.";
            txtpersoana.Width = LATIME_CONTROL;
            txtpersoana.AutoSize = true;
            txtpersoana.Top = top * DIMENISUNE_PAS_Y;

            this.Controls.Add(txtpersoana);

            //adauga control tip label pt nume
            lblpNume = new Label();
            lblpNume.Text = "Nume";
            lblpNume.Width = LATIME_CONTROL;
            lblpNume.Left = 1 * DIMENSIUNE_PAS_X;
            lblpNume.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblpNume);

            txtNume = new TextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = 1 * DIMENSIUNE_PAS_X;
            txtNume.Top = (top+1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtNume);

            //adauga control tip label pt calorii mentinere
            lblpCaloriiMentinere = new Label();
            lblpCaloriiMentinere.Text = "Calorii Ment.";
            lblpCaloriiMentinere.Width = LATIME_CONTROL;
            lblpCaloriiMentinere.Left = 2 * DIMENSIUNE_PAS_X;
            lblpCaloriiMentinere.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiMentinere.AutoSize = true;
            this.Controls.Add(lblpCaloriiMentinere);

            txtCaloriiMentinere = new TextBox();
            txtCaloriiMentinere.Width = LATIME_CONTROL;
            txtCaloriiMentinere.Left = 2 * DIMENSIUNE_PAS_X;
            txtCaloriiMentinere.Top = (top+1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCaloriiMentinere);

            //adauga control tip label pt activitate
            lblpActivitate = new Label();
            lblpActivitate.Text = "Activitate";
            lblpActivitate.Width = LATIME_CONTROL;
            lblpActivitate.Left = 3 * DIMENSIUNE_PAS_X;
            lblpActivitate.Top = top * DIMENISUNE_PAS_Y;
            lblpActivitate.AutoSize = true;
            this.Controls.Add(lblpActivitate);

            txtActivitate = new ListBox();
            txtActivitate.SelectionMode = SelectionMode.MultiSimple;
            txtActivitate.Items.Add(Persoana.TipActivitate.Cardio);
            txtActivitate.Items.Add(Persoana.TipActivitate.Forta);
            txtActivitate.Items.Add(Persoana.TipActivitate.Mobilitate);
            txtActivitate.Items.Add(Persoana.TipActivitate.Sporturi);
            txtActivitate.Items.Add(Persoana.TipActivitate.Altele);
            txtActivitate.Items.Add(Persoana.TipActivitate.Niciuna);
            txtActivitate.Width = LATIME_CONTROL;
            txtActivitate.Left = 3 * DIMENSIUNE_PAS_X;
            txtActivitate.Top = (top + 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtActivitate);

            //adauga control tip buton pt adauga persoana
            AddPersoana = new Button();
            AddPersoana.Text = "Adauga Pers.";
            AddPersoana.Width = LATIME_CONTROL;
            AddPersoana.Left = 4 * DIMENSIUNE_PAS_X;
            AddPersoana.Top = (top + 1) * DIMENISUNE_PAS_Y;
            AddPersoana.Click += AdaugaPersoana;
            AddPersoana.AutoSize = true;
            AddPersoana.BackColor = Color.White;
            AddPersoana.ForeColor = Color.Black;
            this.Controls.Add(AddPersoana);

        }
        private void AfisarePersoane()
        {
            Persoana[] persoane = adminPersoane.GetPersoane(out int nrPersoane);


            //adauga o linie care sa scrie Persoane in mijloc
            lblPersoane = new Label();
            lblPersoane.Text = "Persoane";
            lblPersoane.Width = LATIME_CONTROL;
            lblPersoane.Left = 4 * DIMENSIUNE_PAS_X;
            lblPersoane.Top = top * DIMENISUNE_PAS_Y;
            lblPersoane.ForeColor = Color.Orange;
            this.Controls.Add(lblPersoane);

            top++;

            //adaugare control tip label pt nume
            lblpNume = new Label();
            lblpNume.Text = "Nume";
            lblpNume.Width = LATIME_CONTROL;
            lblpNume.Left = 1 * DIMENSIUNE_PAS_X;
            lblpNume.Top = top * DIMENISUNE_PAS_Y;
            lblpNume.ForeColor = Color.Red;
            this.Controls.Add(lblpNume);

            //adaugare control tip label pt calorii consumate
            lblpCaloriiConsumate = new Label();
            lblpCaloriiConsumate.Text = "Calorii Consumate";
            lblpCaloriiConsumate.Width = LATIME_CONTROL;
            lblpCaloriiConsumate.Left = 2 * DIMENSIUNE_PAS_X;
            lblpCaloriiConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpCaloriiConsumate);

            //adaugare control tip label pt proteine consumate
            lblpProteineConsumate = new Label();
            lblpProteineConsumate.Text = "Proteine Consumate";
            lblpProteineConsumate.Width = LATIME_CONTROL;
            lblpProteineConsumate.Left = 3 * DIMENSIUNE_PAS_X;
            lblpProteineConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpProteineConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpProteineConsumate);

            //adaugare control tip label pt carbohidrati consumati
            lblpCarbohidratiConsumati = new Label();
            lblpCarbohidratiConsumati.Text = "Carbohidrati Consumati";
            lblpCarbohidratiConsumati.Width = LATIME_CONTROL;
            lblpCarbohidratiConsumati.Left = 4 * DIMENSIUNE_PAS_X;
            lblpCarbohidratiConsumati.Top = top * DIMENISUNE_PAS_Y;
            lblpCarbohidratiConsumati.ForeColor = Color.Red;
            this.Controls.Add(lblpCarbohidratiConsumati);

            //adaugare control tip label pt grasimi consumate
            lblpGrasimiConsumate = new Label();
            lblpGrasimiConsumate.Text = "Grasimi Consumate";
            lblpGrasimiConsumate.Width = LATIME_CONTROL;
            lblpGrasimiConsumate.Left = 5 * DIMENSIUNE_PAS_X;
            lblpGrasimiConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpGrasimiConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpGrasimiConsumate);

            //adaugare control tip label pt calorii mentinere
            lblpCaloriiMentinere = new Label();
            lblpCaloriiMentinere.Text = "Calorii Mentinere";
            lblpCaloriiMentinere.Width = LATIME_CONTROL;
            lblpCaloriiMentinere.Left = 6 * DIMENSIUNE_PAS_X;
            lblpCaloriiMentinere.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiMentinere.ForeColor = Color.Red;
            this.Controls.Add(lblpCaloriiMentinere);

            //adaugare control tip label pt mese
            lblpMese = new Label();
            lblpMese.Text = "Mese";
            lblpMese.Width = LATIME_CONTROL;
            lblpMese.Left = 7 * DIMENSIUNE_PAS_X;
            lblpMese.Top = top * DIMENISUNE_PAS_Y;
            lblpMese.ForeColor = Color.Red;
            this.Controls.Add(lblpMese);

            //adaugare control tip label pt activitate
            lblpActivitate = new Label();
            lblpActivitate.Text = "Activitate";
            lblpActivitate.Width = LATIME_CONTROL;
            lblpActivitate.Left = 8 * DIMENSIUNE_PAS_X;
            lblpActivitate.Top = top * DIMENISUNE_PAS_Y;
            lblpActivitate.ForeColor = Color.Red;
            this.Controls.Add(lblpActivitate);

            lblspNume = new Label[nrPersoane];
            lblspCaloriiConsumate = new Label[nrPersoane];
            lblspProteineConsumate = new Label[nrPersoane];
            lblspCarbohidratiConsumati = new Label[nrPersoane];
            lblspGrasimiConsumate = new Label[nrPersoane];
            lblspCaloriiMentinere = new Label[nrPersoane];
            lblspMese = new Label[nrPersoane];
            lblspActivitate = new Label[nrPersoane];

            top++; 

            int i = 0;
            foreach (Persoana persoana in persoane)
            {
                //Nume
                lblspNume[i] = new Label();
                lblspNume[i].Width = LATIME_CONTROL;
                lblspNume[i].Left = DIMENSIUNE_PAS_X;
                lblspNume[i].Top = (i +top) * DIMENISUNE_PAS_Y;
                lblspNume[i].Text = persoana.nume;
                this.Controls.Add(lblspNume[i]);
                //Calorii Consumate
                lblspCaloriiConsumate[i] = new Label();
                lblspCaloriiConsumate[i].Width = LATIME_CONTROL;
                lblspCaloriiConsumate[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblspCaloriiConsumate[i].Top = (i+top) * DIMENISUNE_PAS_Y;
                lblspCaloriiConsumate[i].Text = persoana.calorii_consumate.ToString();
                this.Controls.Add(lblspCaloriiConsumate[i]);
                //Proteine Consumate
                lblspProteineConsumate[i] = new Label();
                lblspProteineConsumate[i].Width = LATIME_CONTROL;
                lblspProteineConsumate[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblspProteineConsumate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspProteineConsumate[i].Text = persoana.proteine_consumate.ToString();
                this.Controls.Add(lblspProteineConsumate[i]);
                //Carbohidrati Consumati
                lblspCarbohidratiConsumati[i] = new Label();
                lblspCarbohidratiConsumati[i].Width = LATIME_CONTROL;
                lblspCarbohidratiConsumati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblspCarbohidratiConsumati[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspCarbohidratiConsumati[i].Text = persoana.carbohidrati_consumati.ToString();
                this.Controls.Add(lblspCarbohidratiConsumati[i]);
                //Grasimi Consumate
                lblspGrasimiConsumate[i] = new Label();
                lblspGrasimiConsumate[i].Width = LATIME_CONTROL;
                lblspGrasimiConsumate[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblspGrasimiConsumate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspGrasimiConsumate[i].Text = persoana.grasimi_consumate.ToString();
                this.Controls.Add(lblspGrasimiConsumate[i]);
                //Calorii Mentinere
                lblspCaloriiMentinere[i] = new Label();
                lblspCaloriiMentinere[i].Width = LATIME_CONTROL;
                lblspCaloriiMentinere[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblspCaloriiMentinere[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspCaloriiMentinere[i].Text = persoana.calorii_mentinere.ToString();
                this.Controls.Add(lblspCaloriiMentinere[i]);
                //Mese
                lblspMese[i] = new Label();
                lblspMese[i].Width = LATIME_CONTROL;
                lblspMese[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblspMese[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspMese[i].Text = persoana.mese.ToString();
                this.Controls.Add(lblspMese[i]);
                //Activitate
                lblspActivitate[i] = new Label();
                lblspActivitate[i].Width = LATIME_CONTROL + 50; 
                lblspActivitate[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblspActivitate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspActivitate[i].Text = persoana.GetActivitatiString(persoana.activitate);
                lblspActivitate[i].AutoSize = true; 
                this.Controls.Add(lblspActivitate[i]);

                i++;
            }
        }
        private void AdaugaPersoana(object sender, EventArgs e)
        {
            string nume = txtNume.Text;
            double calorii_mentinere = double.Parse(txtCaloriiMentinere.Text);

            Persoana.TipActivitate activitate = Persoana.TipActivitate.Niciuna;
            foreach (var item in txtActivitate.SelectedItems)
            {
                activitate |= (Persoana.TipActivitate)item;
            }

            Persoana[] persoane = adminPersoane.GetPersoane(out int nrPersoane);
            int nextId;
            if (nrPersoane > 0)
            {
                nextId = persoane.Max(p => p.id_persoana) + 1;
            }
            else
            {
                nextId = 1;
            }

            Persoana persoana = new Persoana(nextId, nume, calorii_mentinere);
            persoana.activitate = activitate;
            adminPersoane.AdaugaPersoana(persoana);
        }
    }
}
