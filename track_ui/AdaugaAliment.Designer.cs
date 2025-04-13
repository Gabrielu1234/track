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
            this.metroTitlu = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroDenumire = new MetroFramework.Controls.MetroTextBox();
            this.metroCalorii = new MetroFramework.Controls.MetroTextBox();
            this.metroProteine = new MetroFramework.Controls.MetroTextBox();
            this.metroCarbohidratii = new MetroFramework.Controls.MetroTextBox();
            this.metroGrasimi = new MetroFramework.Controls.MetroTextBox();
            this.metroTipProdus = new MetroFramework.Controls.MetroComboBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTitlu
            // 
            this.metroTitlu.AutoSize = true;
            this.metroTitlu.Location = new System.Drawing.Point(4, 0);
            this.metroTitlu.Name = "metroTitlu";
            this.metroTitlu.Size = new System.Drawing.Size(55, 19);
            this.metroTitlu.TabIndex = 0;
            this.metroTitlu.Text = "Adauga";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Denumire";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(76, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Calorii";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(129, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Proteine";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(193, 35);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Carbohidratii";
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(285, 35);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(53, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Grasimi";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(344, 35);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Tip Produs";
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
            this.metroDenumire.Lines = new string[0];
            this.metroDenumire.Location = new System.Drawing.Point(4, 72);
            this.metroDenumire.MaxLength = 32767;
            this.metroDenumire.Name = "metroDenumire";
            this.metroDenumire.PasswordChar = '\0';
            this.metroDenumire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroDenumire.SelectedText = "";
            this.metroDenumire.SelectionLength = 0;
            this.metroDenumire.SelectionStart = 0;
            this.metroDenumire.ShortcutsEnabled = true;
            this.metroDenumire.Size = new System.Drawing.Size(66, 23);
            this.metroDenumire.TabIndex = 7;
            this.metroDenumire.UseSelectable = true;
            this.metroDenumire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroDenumire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroCalorii.Location = new System.Drawing.Point(76, 72);
            this.metroCalorii.MaxLength = 32767;
            this.metroCalorii.Name = "metroCalorii";
            this.metroCalorii.PasswordChar = '\0';
            this.metroCalorii.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroCalorii.SelectedText = "";
            this.metroCalorii.SelectionLength = 0;
            this.metroCalorii.SelectionStart = 0;
            this.metroCalorii.ShortcutsEnabled = true;
            this.metroCalorii.Size = new System.Drawing.Size(47, 23);
            this.metroCalorii.TabIndex = 8;
            this.metroCalorii.UseSelectable = true;
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
            this.metroProteine.Location = new System.Drawing.Point(129, 72);
            this.metroProteine.MaxLength = 32767;
            this.metroProteine.Name = "metroProteine";
            this.metroProteine.PasswordChar = '\0';
            this.metroProteine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroProteine.SelectedText = "";
            this.metroProteine.SelectionLength = 0;
            this.metroProteine.SelectionStart = 0;
            this.metroProteine.ShortcutsEnabled = true;
            this.metroProteine.Size = new System.Drawing.Size(58, 23);
            this.metroProteine.TabIndex = 9;
            this.metroProteine.UseSelectable = true;
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
            this.metroCarbohidratii.Location = new System.Drawing.Point(193, 72);
            this.metroCarbohidratii.MaxLength = 32767;
            this.metroCarbohidratii.Name = "metroCarbohidratii";
            this.metroCarbohidratii.PasswordChar = '\0';
            this.metroCarbohidratii.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroCarbohidratii.SelectedText = "";
            this.metroCarbohidratii.SelectionLength = 0;
            this.metroCarbohidratii.SelectionStart = 0;
            this.metroCarbohidratii.ShortcutsEnabled = true;
            this.metroCarbohidratii.Size = new System.Drawing.Size(86, 23);
            this.metroCarbohidratii.TabIndex = 10;
            this.metroCarbohidratii.UseSelectable = true;
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
            this.metroGrasimi.Location = new System.Drawing.Point(285, 72);
            this.metroGrasimi.MaxLength = 32767;
            this.metroGrasimi.Name = "metroGrasimi";
            this.metroGrasimi.PasswordChar = '\0';
            this.metroGrasimi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroGrasimi.SelectedText = "";
            this.metroGrasimi.SelectionLength = 0;
            this.metroGrasimi.SelectionStart = 0;
            this.metroGrasimi.ShortcutsEnabled = true;
            this.metroGrasimi.Size = new System.Drawing.Size(53, 23);
            this.metroGrasimi.TabIndex = 11;
            this.metroGrasimi.UseSelectable = true;
            this.metroGrasimi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroGrasimi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTipProdus
            // 
            this.metroTipProdus.FormattingEnabled = true;
            this.metroTipProdus.ItemHeight = 23;
            this.metroTipProdus.Location = new System.Drawing.Point(344, 72);
            this.metroTipProdus.Name = "metroTipProdus";
            this.metroTipProdus.Size = new System.Drawing.Size(121, 29);
            this.metroTipProdus.TabIndex = 12;
            this.metroTipProdus.UseSelectable = true;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroTile1.ForeColor = System.Drawing.Color.White;
            this.metroTile1.Location = new System.Drawing.Point(129, 168);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(209, 68);
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
            // AdaugaAliment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTipProdus);
            this.Controls.Add(this.metroGrasimi);
            this.Controls.Add(this.metroCarbohidratii);
            this.Controls.Add(this.metroProteine);
            this.Controls.Add(this.metroCalorii);
            this.Controls.Add(this.metroDenumire);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTitlu);
            this.Name = "AdaugaAliment";
            this.Size = new System.Drawing.Size(473, 249);
            this.Load += new System.EventHandler(this.AdaugaAliment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroTitlu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroDenumire;
        private MetroFramework.Controls.MetroTextBox metroCalorii;
        private MetroFramework.Controls.MetroTextBox metroProteine;
        private MetroFramework.Controls.MetroTextBox metroCarbohidratii;
        private MetroFramework.Controls.MetroTextBox metroGrasimi;
        private MetroFramework.Controls.MetroComboBox metroTipProdus;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}
