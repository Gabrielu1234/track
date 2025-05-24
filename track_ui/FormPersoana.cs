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

        public AdaugaPersoana adaugaPersoana;
        public CautaPersoana cautaPersoana;

        public FormPersoana()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisierPersoana = locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisierPersoane"];
            
            adminPersoane = new AdministrarePersoane(caleCompletaFisierPersoana);

            //setate proprietati
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Theme = MetroFramework.MetroThemeStyle.Default;

            AdaugaPersoana adaugaPersoana = new AdaugaPersoana();
            adaugaPersoana.Location = new Point(280, 63);
            this.Controls.Add(adaugaPersoana);
            adaugaPersoana.Hide();

            CautaPersoana cautaPersoana = new CautaPersoana();
            cautaPersoana.Location = new Point(280, 63);
            this.Controls.Add(cautaPersoana);
            cautaPersoana.Hide();




        }
        public void AfiseazaMetroGrid(List<Persoana> persoane)
        {
            metroGridPersoana.DataSource = null;

            if (persoane != null && persoane.Any())
            {
                metroGridPersoana.DataSource = persoane.Select(s => new
                {
                    Id = s.id_persoana,
                    Denumire = s.nume,
                    Calorii = s.calorii_consumate,
                    Proteine = s.proteine_consumate,
                    Carbohidratii =s.carbohidrati_consumati,
                    Grasimi = s.grasimi_consumate,
                    Mentinere = s.calorii_mentinere,
                    Mese = s.mese,
                    Activitate = s.GetActivitatiString(s.activitate)
                }).ToList();
            }
        }

        private void FormPersoana_Load(object sender, EventArgs e)
        {
            AfiseazaMetroGrid(adminPersoane.GetPersoane(out int nrPersoane).ToList());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AfiseazaMetroGrid(adminPersoane.GetPersoane(out int nrPersoane).ToList());
            metroGridPersoana.Show();
            if (adaugaPersoana != null)
            {
                adaugaPersoana.Hide();
            }
            if (cautaPersoana != null)
            {
                cautaPersoana.Hide();
            }

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroGridPersoana.Hide();
            if(adaugaPersoana!=null)
            {
                adaugaPersoana.Show();
            }
            else
            {
                adaugaPersoana = new AdaugaPersoana();
                adaugaPersoana.Location = new Point(280, 63);
                this.Controls.Add(adaugaPersoana);
                adaugaPersoana.Show();
            }
            if (cautaPersoana != null)
            {
                cautaPersoana.Hide();
            }


        }
        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroGridPersoana.Hide();
            if (adaugaPersoana != null)
            {
                adaugaPersoana.Hide();
            }
            if (cautaPersoana != null)
            {
                cautaPersoana.Show();
            }
            else
            {
                cautaPersoana = new CautaPersoana();
                cautaPersoana.Location = new Point(280, 63);
                this.Controls.Add(cautaPersoana);
                cautaPersoana.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            EditarePersoana editarePersoana = new EditarePersoana(Convert.ToInt32(metroGridPersoana.CurrentRow.Cells[0].Value));
            editarePersoana.ShowDialog();
            List<Persoana> persoane = adminPersoane.GetPersoane(out int nrPersoane).ToList();
            AfiseazaMetroGrid(persoane);
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Persoana persoana = adminPersoane.GetPersoanaByIndex(Convert.ToInt32(metroGridPersoana.CurrentRow.Cells[0].Value));
            adminPersoane.StergePersoanaFisier(persoana);
            List<Persoana> persoane = adminPersoane.GetPersoane(out int nrPersoane).ToList();
            AfiseazaMetroGrid(persoane);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ConsumAlimentar consumAlimentar = new ConsumAlimentar(Convert.ToInt32(metroGridPersoana.CurrentRow.Cells[0].Value));
            consumAlimentar.ShowDialog();
            List<Persoana> persoane = adminPersoane.GetPersoane(out int nrPersoane).ToList();
            AfiseazaMetroGrid(persoane);
        }
    }
}
