using MetroFramework.Forms;
using System;
using System.Drawing;


namespace track_ui
{
    public partial class Form1 : MetroForm
    {


        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.TransparencyKey=Color.Empty;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formapersoana = new FormPersoana();
            formapersoana.Closed += (s, args) => this.Close();
            formapersoana.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formaliment = new FormAliment();
            formaliment.Closed += (s, args) => this.Close();
            formaliment.Show();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var formapersoana = new FormPersoana();
            formapersoana.Closed += (s, args) => this.Close();
            formapersoana.Show();
        }
    }
}
