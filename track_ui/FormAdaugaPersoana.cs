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
    public partial class FormAdaugaPersoana: MetroForm
    {
        public int top = 2;

        //Persoana
        AdministrarePersoane adminPersoane;


        private MetroLabel lblpNume1;
        private MetroLabel lblpCaloriiMentinere1;
        private MetroLabel lblpActivitate1;


        private MetroLabel txtpersoana;
        private MetroTextBox txtNume;
        private MetroTextBox txtCaloriiMentinere;
        private ListBox txtActivitate;

        //Butoane
        private MetroButton AddPersoana;

        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 125;


        public FormAdaugaPersoana()
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
            this.Text = "AdaugaPersoana";


        }

        private void FormAdaugaPersoana_Load(object sender, EventArgs e)
        {
            AfisareTxtPersoana();
        }
        private void AfisareTxtPersoana()
        {
            top++;

            txtpersoana = new MetroLabel();
            txtpersoana.Text = "Adauga Pers.";
            txtpersoana.Width = LATIME_CONTROL;
            txtpersoana.AutoSize = true;
            txtpersoana.Top = top * DIMENISUNE_PAS_Y;

            this.Controls.Add(txtpersoana);

            //adauga control tip MetroLabel pt nume
            lblpNume1 = new MetroLabel();
            lblpNume1.Text = "Nume";
            lblpNume1.Width = LATIME_CONTROL;
            lblpNume1.Left = 1 * DIMENSIUNE_PAS_X;
            lblpNume1.Top = top * DIMENISUNE_PAS_Y;
            this.Controls.Add(lblpNume1);

            txtNume = new MetroTextBox();
            txtNume.Width = LATIME_CONTROL;
            txtNume.Left = 1 * DIMENSIUNE_PAS_X;
            txtNume.Top = (top + 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtNume);

            //adauga control tip MetroLabel pt calorii mentinere
            lblpCaloriiMentinere1 = new MetroLabel();
            lblpCaloriiMentinere1.Text = "Calorii Ment.";
            lblpCaloriiMentinere1.Width = LATIME_CONTROL;
            lblpCaloriiMentinere1.Left = 2 * DIMENSIUNE_PAS_X;
            lblpCaloriiMentinere1.Top = top * DIMENISUNE_PAS_Y;
            lblpCaloriiMentinere1.AutoSize = true;
            this.Controls.Add(lblpCaloriiMentinere1);

            txtCaloriiMentinere = new MetroTextBox();
            txtCaloriiMentinere.Width = LATIME_CONTROL;
            txtCaloriiMentinere.Left = 2 * DIMENSIUNE_PAS_X;
            txtCaloriiMentinere.Top = (top + 1) * DIMENISUNE_PAS_Y;
            this.Controls.Add(txtCaloriiMentinere);

            //adauga control tip MetroLabel pt activitate
            lblpActivitate1 = new MetroLabel();
            lblpActivitate1.Text = "Activitate";
            lblpActivitate1.Width = LATIME_CONTROL;
            lblpActivitate1.Left = 3 * DIMENSIUNE_PAS_X;
            lblpActivitate1.Top = top * DIMENISUNE_PAS_Y;
            lblpActivitate1.AutoSize = true;
            this.Controls.Add(lblpActivitate1);

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
            AddPersoana = new MetroButton();
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
        private void AdaugaPersoana(object sender, EventArgs e)
        {
            int ok = 1;
            string nume = txtNume.Text;
            double calorii_mentinere;
            if (string.IsNullOrEmpty(nume))
            {
                lblpNume1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblpNume1.ForeColor = Color.Yellow;
            }
            if (!double.TryParse(txtCaloriiMentinere.Text, out calorii_mentinere))
            {
                lblpCaloriiMentinere1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblpCaloriiMentinere1.ForeColor = Color.Yellow;
            }

            Persoana.TipActivitate activitate = Persoana.TipActivitate.Niciuna;
            foreach (var item in txtActivitate.SelectedItems)
            {
                activitate |= (Persoana.TipActivitate)item;
            }
            if (txtActivitate.SelectedIndex == -1)
            {
                lblpActivitate1.ForeColor = Color.Red;
                ok = 0;
            }
            else
            {
                lblpActivitate1.ForeColor = Color.Yellow;
            }
            if (ok == 1)
            {
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
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
        }
    }
}
