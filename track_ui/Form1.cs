﻿using System;
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
