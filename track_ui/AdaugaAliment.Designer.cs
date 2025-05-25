namespace track_ui
{
    partial class AdaugaAliment
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugaAliment));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDenumire = new MetroFramework.Controls.MetroTextBox();
            this.metroCalorii = new MetroFramework.Controls.MetroTextBox();
            this.metroProteine = new MetroFramework.Controls.MetroTextBox();
            this.metroCarbohidratii = new MetroFramework.Controls.MetroTextBox();
            this.metroGrasimi = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.groupTipProdus = new System.Windows.Forms.GroupBox();
            this.metroAltele = new MetroFramework.Controls.MetroRadioButton();
            this.metroLegume = new MetroFramework.Controls.MetroRadioButton();
            this.metroBauturi = new MetroFramework.Controls.MetroRadioButton();
            this.metroCarne = new MetroFramework.Controls.MetroRadioButton();
            this.metroDulciuri = new MetroFramework.Controls.MetroRadioButton();
            this.metroFructe = new MetroFramework.Controls.MetroRadioButton();
            this.metroCereale = new MetroFramework.Controls.MetroRadioButton();
            this.metroLactate = new MetroFramework.Controls.MetroRadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupTipProdus.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Black;
            this.metroLabel1.Location = new System.Drawing.Point(103, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Denumire";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Black;
            this.metroLabel2.Location = new System.Drawing.Point(175, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Calorii";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(228, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(61, 20);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Proteine";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Black;
            this.metroLabel4.Location = new System.Drawing.Point(292, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 20);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Carbohidratii";
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Black;
            this.metroLabel5.Location = new System.Drawing.Point(384, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 20);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Grasimi";
            this.metroLabel5.UseCustomForeColor = true;
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroDenumire
            // 
            // 
            // 
            // 
            this.metroDenumire.CustomButton.Image = null;
            this.metroDenumire.CustomButton.Location = new System.Drawing.Point(44, 1);
            this.metroDenumire.CustomButton.Name = "";
            this.metroDenumire.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroDenumire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroDenumire.CustomButton.TabIndex = 1;
            this.metroDenumire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroDenumire.CustomButton.UseSelectable = true;
            this.metroDenumire.CustomButton.Visible = false;
            this.metroDenumire.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroDenumire.Lines = new string[0];
            this.metroDenumire.Location = new System.Drawing.Point(103, 37);
            this.metroDenumire.MaxLength = 32767;
            this.metroDenumire.Name = "metroDenumire";
            this.metroDenumire.PasswordChar = '\0';
            this.metroDenumire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroDenumire.SelectedText = "";
            this.metroDenumire.SelectionLength = 0;
            this.metroDenumire.SelectionStart = 0;
            this.metroDenumire.ShortcutsEnabled = true;
            this.metroDenumire.Size = new System.Drawing.Size(66, 23);
            this.metroDenumire.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroDenumire.TabIndex = 7;
            this.metroDenumire.UseSelectable = true;
            this.metroDenumire.UseStyleColors = true;
            this.metroDenumire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroDenumire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroDenumire.Click += new System.EventHandler(this.metroDenumire_Click);
            // 
            // metroCalorii
            // 
            // 
            // 
            // 
            this.metroCalorii.CustomButton.Image = null;
            this.metroCalorii.CustomButton.Location = new System.Drawing.Point(25, 1);
            this.metroCalorii.CustomButton.Name = "";
            this.metroCalorii.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroCalorii.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCalorii.CustomButton.TabIndex = 1;
            this.metroCalorii.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCalorii.CustomButton.UseSelectable = true;
            this.metroCalorii.CustomButton.Visible = false;
            this.metroCalorii.Lines = new string[0];
            this.metroCalorii.Location = new System.Drawing.Point(175, 37);
            this.metroCalorii.MaxLength = 32767;
            this.metroCalorii.Name = "metroCalorii";
            this.metroCalorii.PasswordChar = '\0';
            this.metroCalorii.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroCalorii.SelectedText = "";
            this.metroCalorii.SelectionLength = 0;
            this.metroCalorii.SelectionStart = 0;
            this.metroCalorii.ShortcutsEnabled = true;
            this.metroCalorii.Size = new System.Drawing.Size(47, 23);
            this.metroCalorii.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroCalorii.TabIndex = 8;
            this.metroCalorii.UseSelectable = true;
            this.metroCalorii.UseStyleColors = true;
            this.metroCalorii.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroCalorii.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroProteine
            // 
            // 
            // 
            // 
            this.metroProteine.CustomButton.Image = null;
            this.metroProteine.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.metroProteine.CustomButton.Name = "";
            this.metroProteine.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroProteine.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProteine.CustomButton.TabIndex = 1;
            this.metroProteine.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroProteine.CustomButton.UseSelectable = true;
            this.metroProteine.CustomButton.Visible = false;
            this.metroProteine.Lines = new string[0];
            this.metroProteine.Location = new System.Drawing.Point(228, 37);
            this.metroProteine.MaxLength = 32767;
            this.metroProteine.Name = "metroProteine";
            this.metroProteine.PasswordChar = '\0';
            this.metroProteine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroProteine.SelectedText = "";
            this.metroProteine.SelectionLength = 0;
            this.metroProteine.SelectionStart = 0;
            this.metroProteine.ShortcutsEnabled = true;
            this.metroProteine.Size = new System.Drawing.Size(58, 23);
            this.metroProteine.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroProteine.TabIndex = 9;
            this.metroProteine.UseSelectable = true;
            this.metroProteine.UseStyleColors = true;
            this.metroProteine.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroProteine.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCarbohidratii
            // 
            // 
            // 
            // 
            this.metroCarbohidratii.CustomButton.Image = null;
            this.metroCarbohidratii.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.metroCarbohidratii.CustomButton.Name = "";
            this.metroCarbohidratii.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroCarbohidratii.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroCarbohidratii.CustomButton.TabIndex = 1;
            this.metroCarbohidratii.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroCarbohidratii.CustomButton.UseSelectable = true;
            this.metroCarbohidratii.CustomButton.Visible = false;
            this.metroCarbohidratii.Lines = new string[0];
            this.metroCarbohidratii.Location = new System.Drawing.Point(292, 37);
            this.metroCarbohidratii.MaxLength = 32767;
            this.metroCarbohidratii.Name = "metroCarbohidratii";
            this.metroCarbohidratii.PasswordChar = '\0';
            this.metroCarbohidratii.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroCarbohidratii.SelectedText = "";
            this.metroCarbohidratii.SelectionLength = 0;
            this.metroCarbohidratii.SelectionStart = 0;
            this.metroCarbohidratii.ShortcutsEnabled = true;
            this.metroCarbohidratii.Size = new System.Drawing.Size(86, 23);
            this.metroCarbohidratii.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroCarbohidratii.TabIndex = 10;
            this.metroCarbohidratii.UseSelectable = true;
            this.metroCarbohidratii.UseStyleColors = true;
            this.metroCarbohidratii.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroCarbohidratii.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrasimi
            // 
            // 
            // 
            // 
            this.metroGrasimi.CustomButton.Image = null;
            this.metroGrasimi.CustomButton.Location = new System.Drawing.Point(31, 1);
            this.metroGrasimi.CustomButton.Name = "";
            this.metroGrasimi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroGrasimi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrasimi.CustomButton.TabIndex = 1;
            this.metroGrasimi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrasimi.CustomButton.UseSelectable = true;
            this.metroGrasimi.CustomButton.Visible = false;
            this.metroGrasimi.Lines = new string[0];
            this.metroGrasimi.Location = new System.Drawing.Point(384, 37);
            this.metroGrasimi.MaxLength = 32767;
            this.metroGrasimi.Name = "metroGrasimi";
            this.metroGrasimi.PasswordChar = '\0';
            this.metroGrasimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroGrasimi.SelectedText = "";
            this.metroGrasimi.SelectionLength = 0;
            this.metroGrasimi.SelectionStart = 0;
            this.metroGrasimi.ShortcutsEnabled = true;
            this.metroGrasimi.Size = new System.Drawing.Size(53, 23);
            this.metroGrasimi.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGrasimi.TabIndex = 11;
            this.metroGrasimi.UseSelectable = true;
            this.metroGrasimi.UseStyleColors = true;
            this.metroGrasimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroGrasimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(175, 162);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(203, 68);
            this.metroTile1.TabIndex = 13;
            this.metroTile1.Text = "Adaugă";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // groupTipProdus
            // 
            this.groupTipProdus.Controls.Add(this.metroAltele);
            this.groupTipProdus.Controls.Add(this.metroLegume);
            this.groupTipProdus.Controls.Add(this.metroBauturi);
            this.groupTipProdus.Controls.Add(this.metroCarne);
            this.groupTipProdus.Controls.Add(this.metroDulciuri);
            this.groupTipProdus.Controls.Add(this.metroFructe);
            this.groupTipProdus.Controls.Add(this.metroCereale);
            this.groupTipProdus.Controls.Add(this.metroLactate);
            this.groupTipProdus.Location = new System.Drawing.Point(103, 67);
            this.groupTipProdus.Name = "groupTipProdus";
            this.groupTipProdus.Size = new System.Drawing.Size(334, 79);
            this.groupTipProdus.TabIndex = 14;
            this.groupTipProdus.TabStop = false;
            this.groupTipProdus.Text = "Tip Produs";
            // 
            // metroAltele
            // 
            this.metroAltele.AutoSize = true;
            this.metroAltele.Location = new System.Drawing.Point(220, 44);
            this.metroAltele.Name = "metroAltele";
            this.metroAltele.Size = new System.Drawing.Size(56, 17);
            this.metroAltele.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroAltele.TabIndex = 22;
            this.metroAltele.Text = "Altele";
            this.metroAltele.UseSelectable = true;
            // 
            // metroLegume
            // 
            this.metroLegume.AutoSize = true;
            this.metroLegume.Location = new System.Drawing.Point(80, 21);
            this.metroLegume.Name = "metroLegume";
            this.metroLegume.Size = new System.Drawing.Size(70, 17);
            this.metroLegume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLegume.TabIndex = 16;
            this.metroLegume.Text = "Legume";
            this.metroLegume.UseSelectable = true;
            // 
            // metroBauturi
            // 
            this.metroBauturi.AutoSize = true;
            this.metroBauturi.Location = new System.Drawing.Point(153, 44);
            this.metroBauturi.Name = "metroBauturi";
            this.metroBauturi.Size = new System.Drawing.Size(64, 17);
            this.metroBauturi.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroBauturi.TabIndex = 21;
            this.metroBauturi.Text = "Bauturi";
            this.metroBauturi.UseSelectable = true;
            // 
            // metroCarne
            // 
            this.metroCarne.AutoSize = true;
            this.metroCarne.Location = new System.Drawing.Point(153, 21);
            this.metroCarne.Name = "metroCarne";
            this.metroCarne.Size = new System.Drawing.Size(58, 17);
            this.metroCarne.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroCarne.TabIndex = 17;
            this.metroCarne.Text = "Carne";
            this.metroCarne.UseSelectable = true;
            this.metroCarne.CheckedChanged += new System.EventHandler(this.metroCarne_CheckedChanged);
            // 
            // metroDulciuri
            // 
            this.metroDulciuri.AutoSize = true;
            this.metroDulciuri.Location = new System.Drawing.Point(80, 44);
            this.metroDulciuri.Name = "metroDulciuri";
            this.metroDulciuri.Size = new System.Drawing.Size(67, 17);
            this.metroDulciuri.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroDulciuri.TabIndex = 20;
            this.metroDulciuri.Text = "Dulciuri";
            this.metroDulciuri.UseSelectable = true;
            // 
            // metroFructe
            // 
            this.metroFructe.AutoSize = true;
            this.metroFructe.Location = new System.Drawing.Point(6, 21);
            this.metroFructe.Name = "metroFructe";
            this.metroFructe.Size = new System.Drawing.Size(59, 17);
            this.metroFructe.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroFructe.TabIndex = 15;
            this.metroFructe.Text = "Fructe";
            this.metroFructe.UseSelectable = true;
            // 
            // metroCereale
            // 
            this.metroCereale.AutoSize = true;
            this.metroCereale.Location = new System.Drawing.Point(6, 44);
            this.metroCereale.Name = "metroCereale";
            this.metroCereale.Size = new System.Drawing.Size(68, 17);
            this.metroCereale.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroCereale.TabIndex = 19;
            this.metroCereale.Text = "Cereale";
            this.metroCereale.UseSelectable = true;
            // 
            // metroLactate
            // 
            this.metroLactate.AutoSize = true;
            this.metroLactate.Location = new System.Drawing.Point(220, 21);
            this.metroLactate.Name = "metroLactate";
            this.metroLactate.Size = new System.Drawing.Size(65, 17);
            this.metroLactate.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLactate.TabIndex = 18;
            this.metroLactate.Text = "Lactate";
            this.metroLactate.UseSelectable = true;
            // 
            // AdaugaAliment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupTipProdus);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroGrasimi);
            this.Controls.Add(this.metroCarbohidratii);
            this.Controls.Add(this.metroProteine);
            this.Controls.Add(this.metroCalorii);
            this.Controls.Add(this.metroDenumire);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AdaugaAliment";
            this.Size = new System.Drawing.Size(658, 464);
            this.Load += new System.EventHandler(this.AdaugaAliment_Load);
            this.groupTipProdus.ResumeLayout(false);
            this.groupTipProdus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroDenumire;
        private MetroFramework.Controls.MetroTextBox metroCalorii;
        private MetroFramework.Controls.MetroTextBox metroProteine;
        private MetroFramework.Controls.MetroTextBox metroCarbohidratii;
        private MetroFramework.Controls.MetroTextBox metroGrasimi;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.GroupBox groupTipProdus;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroRadioButton metroFructe;
        private MetroFramework.Controls.MetroRadioButton metroLegume;
        private MetroFramework.Controls.MetroRadioButton metroCarne;
        private MetroFramework.Controls.MetroRadioButton metroLactate;
        private MetroFramework.Controls.MetroRadioButton metroCereale;
        private MetroFramework.Controls.MetroRadioButton metroDulciuri;
        private MetroFramework.Controls.MetroRadioButton metroBauturi;
        private MetroFramework.Controls.MetroRadioButton metroAltele;
    }
}
