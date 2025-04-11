using System;
using System.Collections.Generic;
using MetroFramework.Forms;
using MetroFramework.Controls;
using MetroFramework.Components;
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
    public partial class FormPersoana: MetroForm
    {
        public int top = 2;
        AdministrarePersoane adminPersoane;

        private MetroLabel lblPersoane;
        private MetroLabel lblpNume;
        private MetroLabel lblpCaloriiConsumate;
        private MetroLabel lblpProteineConsumate;
        private MetroLabel lblpCarbohidratiConsumati;
        private MetroLabel lblpGrasimiConsumate;
        private MetroLabel lblpCaloriiMentinere;
        private MetroLabel lblpMese;
        private MetroLabel lblpActivitate;

        private MetroLabel[] lblspNume;
        private MetroLabel[] lblspCaloriiConsumate;
        private MetroLabel[] lblspProteineConsumate;
        private MetroLabel[] lblspCarbohidratiConsumati;
        private MetroLabel[] lblspGrasimiConsumate;
        private MetroLabel[] lblspCaloriiMentinere;
        private MetroLabel[] lblspMese;
        private MetroLabel[] lblspActivitate;

        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 125;

        public FormPersoana()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisierPersoane"];
            
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);

            //setate proprietati
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Persoane";
        }

        private void FormPersoana_Load(object sender, EventArgs e)
        {
            AfisarePersoane();
        }
        private void AfisarePersoane()
        {
            Persoana[] persoane = adminPersoane.GetPersoane(out int nrPersoane);


            //adauga o linie care sa scrie Persoane in mijloc
            lblPersoane = new MetroLabel();
            lblPersoane.Text = "Persoane";
            lblPersoane.Width = LATIME_CONTROL;
            lblPersoane.Left = 4 * DIMENSIUNE_PAS_X;
            lblPersoane.Top = top * DIMENISUNE_PAS_Y;
            lblPersoane.ForeColor = Color.Orange;
            this.Controls.Add(lblPersoane);

            top++;

            //adaugare control tip MetroLabel pt nume
            lblpNume = new MetroLabel();
            lblpNume.Text = "Nume";
            lblpNume.Width = LATIME_CONTROL;
            lblpNume.Left = 1 * DIMENSIUNE_PAS_X;
            lblpNume.Top = top * DIMENISUNE_PAS_Y;
            lblpNume.ForeColor = Color.Red;
            this.Controls.Add(lblpNume);

            //adaugare control tip MetroLabel pt calorii consumate
            lblpCaloriiConsumate = new MetroLabel();
            lblpCaloriiConsumate.Text = "Calorii Cons.";
            lblpCaloriiConsumate.Width = LATIME_CONTROL;
            lblpCaloriiConsumate.Left = 2 * DIMENSIUNE_PAS_X;
            lblpCaloriiConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiConsumate.ForeColor = Color.Red;
            lblpCaloriiConsumate.AutoSize = true;
            this.Controls.Add(lblpCaloriiConsumate);

            //adaugare control tip MetroLabel pt proteine consumate
            lblpProteineConsumate = new MetroLabel();
            lblpProteineConsumate.Text = "Proteine Consumate";
            lblpProteineConsumate.Width = LATIME_CONTROL;
            lblpProteineConsumate.Left = 3 * DIMENSIUNE_PAS_X;
            lblpProteineConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpProteineConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpProteineConsumate);

            //adaugare control tip MetroLabel pt carbohidrati consumati
            lblpCarbohidratiConsumati = new MetroLabel();
            lblpCarbohidratiConsumati.Text = "Carbohidrati Consumati";
            lblpCarbohidratiConsumati.Width = LATIME_CONTROL;
            lblpCarbohidratiConsumati.Left = 4 * DIMENSIUNE_PAS_X;
            lblpCarbohidratiConsumati.Top = top * DIMENISUNE_PAS_Y;
            lblpCarbohidratiConsumati.ForeColor = Color.Red;
            this.Controls.Add(lblpCarbohidratiConsumati);

            //adaugare control tip MetroLabel pt grasimi consumate
            lblpGrasimiConsumate = new MetroLabel();
            lblpGrasimiConsumate.Text = "Grasimi Consumate";
            lblpGrasimiConsumate.Width = LATIME_CONTROL;
            lblpGrasimiConsumate.Left = 5 * DIMENSIUNE_PAS_X;
            lblpGrasimiConsumate.Top = top * DIMENISUNE_PAS_Y;
            lblpGrasimiConsumate.ForeColor = Color.Red;
            this.Controls.Add(lblpGrasimiConsumate);

            //adaugare control tip MetroLabel pt calorii mentinere
            lblpCaloriiMentinere = new MetroLabel();
            lblpCaloriiMentinere.Text = "Calorii Ment.";
            lblpCaloriiMentinere.Width = LATIME_CONTROL;
            lblpCaloriiMentinere.Left = 6 * DIMENSIUNE_PAS_X;
            lblpCaloriiMentinere.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiMentinere.ForeColor = Color.Red;
            lblpCaloriiMentinere.AutoSize = true;
            this.Controls.Add(lblpCaloriiMentinere);

            //adaugare control tip MetroLabel pt mese
            lblpMese = new MetroLabel();
            lblpMese.Text = "Mese";
            lblpMese.Width = LATIME_CONTROL;
            lblpMese.Left = 7 * DIMENSIUNE_PAS_X;
            lblpMese.Top = top * DIMENISUNE_PAS_Y;
            lblpMese.ForeColor = Color.Red;
            this.Controls.Add(lblpMese);

            //adaugare control tip MetroLabel pt activitate
            lblpActivitate = new MetroLabel();
            lblpActivitate.Text = "Activitate";
            lblpActivitate.Width = LATIME_CONTROL;
            lblpActivitate.Left = 8 * DIMENSIUNE_PAS_X;
            lblpActivitate.Top = top * DIMENISUNE_PAS_Y;
            lblpActivitate.ForeColor = Color.Red;
            this.Controls.Add(lblpActivitate);

            lblspNume = new MetroLabel[nrPersoane];
            lblspCaloriiConsumate = new MetroLabel[nrPersoane];
            lblspProteineConsumate = new MetroLabel[nrPersoane];
            lblspCarbohidratiConsumati = new MetroLabel[nrPersoane];
            lblspGrasimiConsumate = new MetroLabel[nrPersoane];
            lblspCaloriiMentinere = new MetroLabel[nrPersoane];
            lblspMese = new MetroLabel[nrPersoane];
            lblspActivitate = new MetroLabel[nrPersoane];

            top++;

            int i = 0;
            foreach (Persoana persoana in persoane)
            {
                //Nume
                lblspNume[i] = new MetroLabel();
                lblspNume[i].Width = LATIME_CONTROL;
                lblspNume[i].Left = DIMENSIUNE_PAS_X;
                lblspNume[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspNume[i].Text = persoana.nume;
                this.Controls.Add(lblspNume[i]);
                //Calorii Consumate
                lblspCaloriiConsumate[i] = new MetroLabel();
                lblspCaloriiConsumate[i].Width = LATIME_CONTROL;
                lblspCaloriiConsumate[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblspCaloriiConsumate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspCaloriiConsumate[i].Text = persoana.calorii_consumate.ToString();
                this.Controls.Add(lblspCaloriiConsumate[i]);
                //Proteine Consumate
                lblspProteineConsumate[i] = new MetroLabel();
                lblspProteineConsumate[i].Width = LATIME_CONTROL;
                lblspProteineConsumate[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblspProteineConsumate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspProteineConsumate[i].Text = persoana.proteine_consumate.ToString();
                this.Controls.Add(lblspProteineConsumate[i]);
                //Carbohidrati Consumati
                lblspCarbohidratiConsumati[i] = new MetroLabel();
                lblspCarbohidratiConsumati[i].Width = LATIME_CONTROL;
                lblspCarbohidratiConsumati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblspCarbohidratiConsumati[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspCarbohidratiConsumati[i].Text = persoana.carbohidrati_consumati.ToString();
                this.Controls.Add(lblspCarbohidratiConsumati[i]);
                //Grasimi Consumate
                lblspGrasimiConsumate[i] = new MetroLabel();
                lblspGrasimiConsumate[i].Width = LATIME_CONTROL;
                lblspGrasimiConsumate[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblspGrasimiConsumate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspGrasimiConsumate[i].Text = persoana.grasimi_consumate.ToString();
                this.Controls.Add(lblspGrasimiConsumate[i]);
                //Calorii Mentinere
                lblspCaloriiMentinere[i] = new MetroLabel();
                lblspCaloriiMentinere[i].Width = LATIME_CONTROL;
                lblspCaloriiMentinere[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblspCaloriiMentinere[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspCaloriiMentinere[i].Text = persoana.calorii_mentinere.ToString();
                this.Controls.Add(lblspCaloriiMentinere[i]);
                //Mese
                lblspMese[i] = new MetroLabel();
                lblspMese[i].Width = LATIME_CONTROL;
                lblspMese[i].Left = 7 * DIMENSIUNE_PAS_X;
                lblspMese[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspMese[i].Text = persoana.mese.ToString();
                this.Controls.Add(lblspMese[i]);
                //Activitate
                lblspActivitate[i] = new MetroLabel();
                lblspActivitate[i].Width = LATIME_CONTROL + 50;
                lblspActivitate[i].Left = 8 * DIMENSIUNE_PAS_X;
                lblspActivitate[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblspActivitate[i].Text = persoana.GetActivitatiString(persoana.activitate);
                lblspActivitate[i].AutoSize = true;
                this.Controls.Add(lblspActivitate[i]);

                i++;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
    }
}
