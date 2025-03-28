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
        //Aliment
        AdministrareAliment adminAliment;

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

        //Persoana
        AdministrarePersoane adminPersoane;

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

        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 100;


        public Form1()
        {
            InitializeComponent();
            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;
            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisierPersoane"];

            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);
            int nrAlimente = 0;

            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);

            Aliment[] alimente = adminAliment.GetAlimente(out nrAlimente);

            //setate proprietati
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.ForeColor = Color.Yellow;
            this.Text = "Tracker";
            this.BackColor = Color.DarkBlue;

            //adaugare control tip label pt denumire
            lblaDenumire = new Label();
            lblaDenumire.Text = "Denumire";
            lblaDenumire.Width = LATIME_CONTROL;
            lblaDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            lblaDenumire.ForeColor = Color.Red;
            this.Controls.Add(lblaDenumire);

            //adaugare control tip label pt calorii
            lblaCalorii = new Label();
            lblaCalorii.Text = "Calorii";
            lblaCalorii.Width = LATIME_CONTROL;
            lblaCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            lblaCalorii.ForeColor = Color.Red;
            this.Controls.Add(lblaCalorii);

            //adaugare control tip label pt proteine
            lblaProteine = new Label();
            lblaProteine.Text = "Proteine";
            lblaProteine.Width = LATIME_CONTROL;
            lblaProteine.Left = 3 * DIMENSIUNE_PAS_X;
            lblaProteine.ForeColor = Color.Red;
            this.Controls.Add(lblaProteine);

            //adaugare control tip label pt carbohidrati
            lblaCarbohidrati = new Label();
            lblaCarbohidrati.Text = "Carbohidrati";
            lblaCarbohidrati.Width = LATIME_CONTROL;
            lblaCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            lblaCarbohidrati.ForeColor = Color.Red;
            this.Controls.Add(lblaCarbohidrati);

            //adaugare control tip label pt grasimi
            lblaGrasimi = new Label();
            lblaGrasimi.Text = "Grasimi";
            lblaGrasimi.Width = LATIME_CONTROL;
            lblaDenumire.Left = 5 * DIMENSIUNE_PAS_X;
            lblaGrasimi.ForeColor = Color.Red;
            this.Controls.Add(lblaGrasimi);

            //adaugare control tip label pt tip produs
            lblaTipProdus = new Label();
            lblaTipProdus.Text = "Tip Produs";
            lblaTipProdus.Width = LATIME_CONTROL;
            lblaTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            lblaTipProdus.ForeColor = Color.Red;
            this.Controls.Add(lblaTipProdus);

            //Persoana

            //adaugare control tip label pt nume
            lblpNume = new Label();
            lblpNume.Text = "Nume";
            lblpNume.Width = LATIME_CONTROL;
            lblpNume.Left = 1 * DIMENSIUNE_PAS_X;
            lblpNume.Top = 3 * DIMENISUNE_PAS_Y;
            lblpNume.ForeColor = Color.Red;
            this.Controls.Add(lblpNume);

            //adaugare control tip label pt calorii consumate
            lblpCaloriiConsumate = new Label();
            lblpCaloriiConsumate.Text = "Calorii Consumate";
            lblpCaloriiConsumate.Width = LATIME_CONTROL;
            lblpCaloriiConsumate.Left = 2 * DIMENSIUNE_PAS_X;
            lblpCaloriiConsumate.Top = 3 * DIMENISUNE_PAS_Y;
            lblpCaloriiConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpCaloriiConsumate);

            //adaugare control tip label pt proteine consumate
            lblpProteineConsumate = new Label();
            lblpProteineConsumate.Text = "Proteine Consumate";
            lblpProteineConsumate.Width = LATIME_CONTROL;
            lblpProteineConsumate.Left = 3 * DIMENSIUNE_PAS_X;
            lblpProteineConsumate.Top = 3 * DIMENISUNE_PAS_Y;
            lblpProteineConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpProteineConsumate);

            //adaugare control tip label pt carbohidrati consumati
            lblpCarbohidratiConsumati = new Label();
            lblpCarbohidratiConsumati.Text = "Carbohidrati Consumati";
            lblpCarbohidratiConsumati.Width = LATIME_CONTROL;
            lblpCarbohidratiConsumati.Left = 4 * DIMENSIUNE_PAS_X;
            lblpCarbohidratiConsumati.Top = 3 * DIMENISUNE_PAS_Y;
            lblpCarbohidratiConsumati.ForeColor = Color.Red;
            this.Controls.Add(lblpCarbohidratiConsumati);

            //adaugare control tip label pt grasimi consumate
            lblpGrasimiConsumate = new Label();
            lblpGrasimiConsumate.Text = "Grasimi Consumate";
            lblpGrasimiConsumate.Width = LATIME_CONTROL;
            lblpGrasimiConsumate.Left = 5 * DIMENSIUNE_PAS_X;
            lblpGrasimiConsumate.Top = 3 * DIMENISUNE_PAS_Y;
            lblpGrasimiConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpGrasimiConsumate);

            //adaugare control tip label pt calorii mentinere
            lblpCaloriiMentinere = new Label();
            lblpCaloriiMentinere.Text = "Calorii Mentinere";
            lblpCaloriiMentinere.Width = LATIME_CONTROL;
            lblpCaloriiMentinere.Left = 6 * DIMENSIUNE_PAS_X;
            lblpCaloriiMentinere.Top = 3 * DIMENISUNE_PAS_Y;
            lblpCaloriiMentinere.ForeColor = Color.Red;
            this.Controls.Add(lblpCaloriiMentinere);

            //adaugare control tip label pt mese
            lblpMese = new Label();
            lblpMese.Text = "Mese";
            lblpMese.Width = LATIME_CONTROL;
            lblpMese.Left = 7 * DIMENSIUNE_PAS_X;
            lblpMese.Top = 3 * DIMENISUNE_PAS_Y;
            lblpMese.ForeColor = Color.Red;
            this.Controls.Add(lblpMese);

            //adaugare control tip label pt activitate
            lblpActivitate = new Label();
            lblpActivitate.Text = "Activitate";
            lblpActivitate.Width = LATIME_CONTROL;
            lblpActivitate.Left = 8 * DIMENSIUNE_PAS_X;
            lblpActivitate.Top = 3 * DIMENISUNE_PAS_Y;
            lblpActivitate.ForeColor = Color.Red;
            this.Controls.Add(lblpActivitate);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AfisareAlimente();
            AfisarePersoane();

        }
        private void AfisareAlimente()
        {
            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);

            lblsaDenumire = new Label[nrAlimente];
            lblsaCalorii = new Label[nrAlimente];
            lblsaProteine = new Label[nrAlimente];
            lblsaCarbohidrati = new Label[nrAlimente];
            lblsaGrasimi = new Label[nrAlimente];
            lblsaTipProdus = new Label[nrAlimente];

            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                //Denumire
                lblsaDenumire[i] = new Label();
                lblsaDenumire[i].Width = LATIME_CONTROL;
                lblsaDenumire[i].Left = DIMENSIUNE_PAS_X;
                lblsaDenumire[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaDenumire[i].Text = aliment.denumire;
                this.Controls.Add(lblsaDenumire[i]);

                //Calorii
                lblsaCalorii[i] = new Label();
                lblsaCalorii[i].Width = LATIME_CONTROL;
                lblsaCalorii[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsaCalorii[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaCalorii[i].Text = aliment.calorii.ToString();
                this.Controls.Add(lblsaCalorii[i]);

                //Proteine
                lblsaProteine[i] = new Label();
                lblsaProteine[i].Width = LATIME_CONTROL;
                lblsaProteine[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsaProteine[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaProteine[i].Text = aliment.proteine.ToString();
                this.Controls.Add(lblsaProteine[i]);

                //Carbohidrati
                lblsaCarbohidrati[i] = new Label();
                lblsaCarbohidrati[i].Width = LATIME_CONTROL;
                lblsaCarbohidrati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsaCarbohidrati[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaCarbohidrati[i].Text = aliment.carbohidrati.ToString();
                this.Controls.Add(lblsaCarbohidrati[i]);

                //Grasimi
                lblsaGrasimi[i] = new Label();
                lblsaGrasimi[i].Width = LATIME_CONTROL;
                lblsaGrasimi[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsaGrasimi[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaGrasimi[i].Text = aliment.grasimi.ToString();
                this.Controls.Add(lblsaGrasimi[i]);

                //Tip Produs
                lblsaTipProdus[i] = new Label();
                lblsaTipProdus[i].Width = LATIME_CONTROL;
                lblsaTipProdus[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsaTipProdus[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblsaTipProdus[i].Text = aliment.tip_produs.ToString();
                this.Controls.Add(lblsaTipProdus[i]);

                i++;
            }
        }
        public void AfisarePersoane()
        {
            Persoana[] persoane = adminPersoane.GetPersoane(out int nrPersoane);
            lblspNume = new Label[nrPersoane];
            lblspCaloriiConsumate = new Label[nrPersoane];
            lblspProteineConsumate = new Label[nrPersoane];
            lblspCarbohidratiConsumati = new Label[nrPersoane];
            lblspGrasimiConsumate = new Label[nrPersoane];
            lblspCaloriiMentinere = new Label[nrPersoane];
            lblspMese = new Label[nrPersoane];
            lblspActivitate = new Label[nrPersoane];
            int i = 0;
            foreach (Persoana persoana in persoane)
            {
                //Nume
                lblspNume[i] = new Label();
                lblspNume[i].Width = LATIME_CONTROL;
                lblspNume[i].Left = DIMENSIUNE_PAS_X;
                lblspNume[i].Top = (i + 1) * DIMENISUNE_PAS_Y;
                lblspNume[i].Text = persoana.nume;
                this.Controls.Add(lblspNume[i]);
                //Calorii Consumate
                lblspCaloriiConsumate[i] = new Label();
                lblspCaloriiConsumate[i].Width = LATIME_CONTROL;
                lblspCaloriiConsumate[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblspCaloriiConsumate[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspCaloriiConsumate[i].Text = persoana.calorii_consumate.ToString();
                this.Controls.Add(lblspCaloriiConsumate[i]);
                //Proteine Consumate
                lblspProteineConsumate[i] = new Label();
                lblspProteineConsumate[i].Width = LATIME_CONTROL;
                lblspProteineConsumate[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblspProteineConsumate[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspProteineConsumate[i].Text = persoana.proteine_consumate.ToString();
                this.Controls.Add(lblspProteineConsumate[i]);
                //Carbohidrati Consumati
                lblspCarbohidratiConsumati[i] = new Label();
                lblspCarbohidratiConsumati[i].Width = LATIME_CONTROL;
                lblspCarbohidratiConsumati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblspCarbohidratiConsumati[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspCarbohidratiConsumati[i].Text = persoana.carbohidrati_consumati.ToString();
                this.Controls.Add(lblspCarbohidratiConsumati[i]);
                //Grasimi Consumate
                lblspGrasimiConsumate[i] = new Label();
                lblspGrasimiConsumate[i].Width = LATIME_CONTROL;
                lblspGrasimiConsumate[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblspGrasimiConsumate[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspGrasimiConsumate[i].Text = persoana.grasimi_consumate.ToString();
                this.Controls.Add(lblspGrasimiConsumate[i]);
                //Calorii Mentinere
                lblspCaloriiMentinere[i] = new Label();
                lblspCaloriiMentinere[i].Width = LATIME_CONTROL;
                lblspCaloriiMentinere[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblspCaloriiMentinere[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspCaloriiMentinere[i].Text = persoana.calorii_mentinere.ToString();
                this.Controls.Add(lblspCaloriiMentinere[i]);
                //Mese
                lblspMese[i] = new Label();
                lblspMese[i].Width = LATIME_CONTROL;
                lblspMese[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblspMese[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspMese[i].Text = persoana.mese.ToString();
                this.Controls.Add(lblspMese[i]);
                //Activitate
                lblspActivitate[i] = new Label();
                lblspActivitate[i].Width = LATIME_CONTROL;
                lblspActivitate[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblspActivitate[i].Top = (i + 4) * DIMENISUNE_PAS_Y;
                lblspActivitate[i].Text = persoana.activitate.ToString();
                this.Controls.Add(lblspActivitate[i]);


                i++;
            }
        }
    }
}
