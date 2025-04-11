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


    public partial class FormAliment: MetroForm
    {
        public int top = 2;
        //Aliment
        AdministrareAliment adminAliment;

        private MetroLabel lblAlimente;
        private MetroLabel lblaDenumire;
        private MetroLabel lblaCalorii;
        private MetroLabel lblaProteine;
        private MetroLabel lblaCarbohidrati;
        private MetroLabel lblaGrasimi;
        private MetroLabel lblaTipProdus;

        private MetroLabel[] lblsaDenumire;
        private MetroLabel[] lblsaCalorii;
        private MetroLabel[] lblsaProteine;
        private MetroLabel[] lblsaCarbohidrati;
        private MetroLabel[] lblsaGrasimi;
        private MetroLabel[] lblsaTipProdus;


        //Dimensiuni
        private const int LATIME_CONTROL = 100;
        private const int DIMENISUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 125;


        public FormAliment()
        {

            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string numeFisierAlimente = ConfigurationManager.AppSettings["NumeFisierAlimente"];
            string caleCompletaFisierAlimente = locatieFisierSolutie + "\\" + numeFisierAlimente;

            adminAliment = new AdministrareAliment(caleCompletaFisierAlimente);

            //setate proprietati
            this.Size = new Size(800, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Alimente";
        }

        private void FormAliment_Load(object sender, EventArgs e)
        {
            AfisareAlimente();
        }
        private void AfisareAlimente()
        {
            Aliment[] alimente = adminAliment.GetAlimente(out int nrAlimente);

            top = top + 5;

            //adauga o linie care sa scrie Alimente in mijloc
            lblAlimente = new MetroLabel();
            lblAlimente.Text = "Alimente";
            lblAlimente.Width = LATIME_CONTROL;
            lblAlimente.Left = 4 * DIMENSIUNE_PAS_X;
            lblAlimente.Top = top * DIMENISUNE_PAS_Y;
            lblAlimente.ForeColor = Color.Orange;
            this.Controls.Add(lblAlimente);

            top++;

            //adaugare control tip MetroLabel pt denumire
            lblaDenumire = new MetroLabel();
            lblaDenumire.Text = "Denumire";
            lblaDenumire.Width = LATIME_CONTROL;
            lblaDenumire.Left = 1 * DIMENSIUNE_PAS_X;
            lblaDenumire.Top = top * DIMENISUNE_PAS_Y;
            lblaDenumire.ForeColor = Color.Red;
            this.Controls.Add(lblaDenumire);

            //adaugare control tip MetroLabel pt calorii
            lblaCalorii = new MetroLabel();
            lblaCalorii.Text = "Calorii";
            lblaCalorii.Width = LATIME_CONTROL;
            lblaCalorii.Left = 2 * DIMENSIUNE_PAS_X;
            lblaCalorii.Top = top * DIMENISUNE_PAS_Y;
            lblaCalorii.ForeColor = Color.Red;
            this.Controls.Add(lblaCalorii);

            //adaugare control tip MetroLabel pt proteine
            lblaProteine = new MetroLabel();
            lblaProteine.Text = "Proteine";
            lblaProteine.Width = LATIME_CONTROL;
            lblaProteine.Left = 3 * DIMENSIUNE_PAS_X;
            lblaProteine.Top = top * DIMENISUNE_PAS_Y;
            lblaProteine.ForeColor = Color.Red;
            this.Controls.Add(lblaProteine);

            //adaugare control tip MetroLabel pt carbohidrati
            lblaCarbohidrati = new MetroLabel();
            lblaCarbohidrati.Text = "Carbohidrati";
            lblaCarbohidrati.Width = LATIME_CONTROL;
            lblaCarbohidrati.Left = 4 * DIMENSIUNE_PAS_X;
            lblaCarbohidrati.Top = top * DIMENISUNE_PAS_Y;
            lblaCarbohidrati.ForeColor = Color.Red;
            this.Controls.Add(lblaCarbohidrati);

            //adaugare control tip MetroLabel pt grasimi
            lblaGrasimi = new MetroLabel();
            lblaGrasimi.Text = "Grasimi";
            lblaGrasimi.Width = LATIME_CONTROL;
            lblaGrasimi.Left = 5 * DIMENSIUNE_PAS_X;
            lblaGrasimi.Top = top * DIMENISUNE_PAS_Y;
            lblaGrasimi.ForeColor = Color.Red;
            this.Controls.Add(lblaGrasimi);

            //adaugare control tip MetroLabel pt tip produs
            lblaTipProdus = new MetroLabel();
            lblaTipProdus.Text = "Tip Produs";
            lblaTipProdus.Width = LATIME_CONTROL;
            lblaTipProdus.Left = 6 * DIMENSIUNE_PAS_X;
            lblaTipProdus.Top = top * DIMENISUNE_PAS_Y;
            lblaTipProdus.ForeColor = Color.Red;
            this.Controls.Add(lblaTipProdus);

            lblsaDenumire = new MetroLabel[nrAlimente];
            lblsaCalorii = new MetroLabel[nrAlimente];
            lblsaProteine = new MetroLabel[nrAlimente];
            lblsaCarbohidrati = new MetroLabel[nrAlimente];
            lblsaGrasimi = new MetroLabel[nrAlimente];
            lblsaTipProdus = new MetroLabel[nrAlimente];

            top++;
            int i = 0;
            foreach (Aliment aliment in alimente)
            {
                //Denumire
                lblsaDenumire[i] = new MetroLabel();
                lblsaDenumire[i].Width = LATIME_CONTROL;
                lblsaDenumire[i].Left = DIMENSIUNE_PAS_X;
                lblsaDenumire[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaDenumire[i].Text = aliment.denumire;
                this.Controls.Add(lblsaDenumire[i]);

                //Calorii
                lblsaCalorii[i] = new MetroLabel();
                lblsaCalorii[i].Width = LATIME_CONTROL;
                lblsaCalorii[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsaCalorii[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaCalorii[i].Text = aliment.calorii.ToString();
                this.Controls.Add(lblsaCalorii[i]);

                //Proteine
                lblsaProteine[i] = new MetroLabel();
                lblsaProteine[i].Width = LATIME_CONTROL;
                lblsaProteine[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsaProteine[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaProteine[i].Text = aliment.proteine.ToString();
                this.Controls.Add(lblsaProteine[i]);

                //Carbohidrati
                lblsaCarbohidrati[i] = new MetroLabel();
                lblsaCarbohidrati[i].Width = LATIME_CONTROL;
                lblsaCarbohidrati[i].Left = 4 * DIMENSIUNE_PAS_X;
                lblsaCarbohidrati[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaCarbohidrati[i].Text = aliment.carbohidrati.ToString();
                this.Controls.Add(lblsaCarbohidrati[i]);

                //Grasimi
                lblsaGrasimi[i] = new MetroLabel();
                lblsaGrasimi[i].Width = LATIME_CONTROL;
                lblsaGrasimi[i].Left = 5 * DIMENSIUNE_PAS_X;
                lblsaGrasimi[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaGrasimi[i].Text = aliment.grasimi.ToString();
                this.Controls.Add(lblsaGrasimi[i]);

                //Tip Produs
                lblsaTipProdus[i] = new MetroLabel();
                lblsaTipProdus[i].Width = LATIME_CONTROL;
                lblsaTipProdus[i].Left = 6 * DIMENSIUNE_PAS_X;
                lblsaTipProdus[i].Top = (i + top) * DIMENISUNE_PAS_Y;
                lblsaTipProdus[i].Text = aliment.tip_produs.ToString();
                this.Controls.Add(lblsaTipProdus[i]);

                i++;
            }
            top = top + i;
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
