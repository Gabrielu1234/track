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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using SiticoneNetFrameworkUI;



namespace track_ui
{


    public partial class FormAliment: MetroForm
    {
        public int top = 2;
        //Aliment
        AdministrareAliment adminAliment;

        public AdaugaAliment adaugaAliment;
        public CautaAliment cautaAliment;


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

        }

        private void metroAfiseaza_Click_1(object sender, EventArgs e)
        {
            AfiseazaMetroGrid(adminAliment.GetAlimente(out int nrAlimente).ToList());
            metroGridAliment.Show();
            if (adaugaAliment != null)
                adaugaAliment.Hide();
            if (cautaAliment != null)
                cautaAliment.Hide();

        }

        private void metroTile1_Click_2(object sender, EventArgs e)
        {
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


        }

        private void metroGridAliment_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
