using LibrarieClase;
using LibrarieDate;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace track_ui
{


    public partial class FormAliment: MetroForm
    {
        public int top = 2;
        AdministrareAliment adminAliment;

        public AdaugaAliment adaugaAliment;
        public CautaAliment cautaAliment;
        public EditAliment editAliment;


        public FormAliment()
        {

            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;


            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);


            //setate proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Theme = MetroFramework.MetroThemeStyle.Default;

            AdaugaAliment adaugaAliment = new AdaugaAliment();
            adaugaAliment.Location = new Point(279, 63);
            this.Controls.Add(adaugaAliment);
            adaugaAliment.Hide();

            CautaAliment cautaAliment = new CautaAliment();
            cautaAliment.Location = new Point(279, 63);
            this.Controls.Add(cautaAliment);
            cautaAliment.Hide();

            

        }

        private void FormAliment_Load(object sender, EventArgs e)
        {
            AfiseazaMetroGrid(adminAliment.GetAlimente(out int nrAlimente).ToList());
        }

        public void AfiseazaMetroGrid(List<Aliment> alimente)
        {
            metroGridAliment.DataSource = null;

            if (alimente != null && alimente.Any())
            {
                metroGridAliment.DataSource = alimente.Select(s => new
                {
                    ID = s.id_aliment,
                    Denumire = s.denumire,
                    Calorii = s.calorii,
                    Proteine = s.proteine,
                    Carbohidrati = s.carbohidrati,
                    Grasimi = s.grasimi,
                    TipProdus = s.tip_produs
                }).ToList();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void metroGridAliment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroAfiseaza_Click(object sender, EventArgs e)
        {

        }

        private void metroAdauga_Click(object sender, EventArgs e)
        {
            

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(800, 425);
            this.Location = new Point(400, 100);
            this.Text = "Adauga Aliment";
            metroGridAliment.Hide();
            if (adaugaAliment != null)
            {
                adaugaAliment.Show();
            }
            else
            {
                adaugaAliment = new AdaugaAliment();
                adaugaAliment.Location = new Point(279, 63);
                this.Controls.Add(adaugaAliment);
                adaugaAliment.Show();
            }
            if (cautaAliment != null)
            {
                cautaAliment.Hide();
            }
            if (editAliment != null)
                editAliment.Hide();

        }

        private void metroAfiseaza_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 425);
            this.Location = new Point(100, 100);
            this.Text = "Administrare Alimente";
            AfiseazaMetroGrid(adminAliment.GetAlimente(out int nrAlimente).ToList());
            metroGridAliment.Show();
            if (adaugaAliment != null)
                adaugaAliment.Hide();
            if (cautaAliment != null)
                cautaAliment.Hide();
            if (editAliment != null)
                editAliment.Hide();

        }

        private void metroTile1_Click_2(object sender, EventArgs e)
        {
            this.Size = new Size(1250, 425);
            this.Location = new Point(100, 100);
            this.Text = "Cauta Aliment";
            if (cautaAliment != null)
            {
                cautaAliment.Show();
            }
            else
            {
                cautaAliment = new CautaAliment();
                cautaAliment.Location = new Point(279, 63);
                this.Controls.Add(cautaAliment);
                cautaAliment.Show();
            }
            if (adaugaAliment != null)
                adaugaAliment.Hide();
            if(metroGridAliment != null)
                metroGridAliment.Hide();
            if(editAliment != null)
                editAliment.Hide();


        }

        private void metroGridAliment_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            EditareAliment editAliment = new EditareAliment(Convert.ToInt32(metroGridAliment.CurrentRow.Cells[0].Value));
            editAliment.ShowDialog();
            List<Aliment> alimente = adminAliment.GetAlimente(out int nrAlimente).ToList();
            AfiseazaMetroGrid(alimente);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Aliment aliment = adminAliment.GetAlimentByIndex(Convert.ToInt32(metroGridAliment.CurrentRow.Cells[0].Value));
            adminAliment.StergeAliment(aliment);
            List<Aliment> alimente = adminAliment.GetAlimente(out int nrAlimente).ToList();
            AfiseazaMetroGrid(alimente);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {

        }
    }
}
