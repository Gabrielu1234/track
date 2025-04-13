namespace track_ui
{
    partial class FormAliment
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAliment));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGridAliment = new MetroFramework.Controls.MetroGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipProdusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administrareAlimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroAfiseaza = new MetroFramework.Controls.MetroTile();
            this.metroAdauga = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.formAlimentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAliment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProdusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareAlimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAlimentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(943, 497);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(123, 30);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.Text = "Înapoi";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGridAliment
            // 
            this.metroGridAliment.AllowUserToResizeRows = false;
            this.metroGridAliment.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAliment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridAliment.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridAliment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAliment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridAliment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridAliment.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridAliment.EnableHeadersVisualStyles = false;
            this.metroGridAliment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridAliment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridAliment.Location = new System.Drawing.Point(279, 63);
            this.metroGridAliment.Name = "metroGridAliment";
            this.metroGridAliment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridAliment.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridAliment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridAliment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridAliment.Size = new System.Drawing.Size(658, 464);
            this.metroGridAliment.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGridAliment.TabIndex = 6;
            this.metroGridAliment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridAliment_CellContentClick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 464);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tipProdusBindingSource
            // 
            this.tipProdusBindingSource.DataSource = typeof(LibrarieClase.Aliment.TipProdus);
            // 
            // alimentBindingSource
            // 
            this.alimentBindingSource.DataSource = typeof(LibrarieClase.Aliment);
            // 
            // administrareAlimentBindingSource
            // 
            this.administrareAlimentBindingSource.DataSource = typeof(LibrarieDate.AdministrareAliment);
            // 
            // metroAfiseaza
            // 
            this.metroAfiseaza.ActiveControl = null;
            this.metroAfiseaza.ForeColor = System.Drawing.Color.Gold;
            this.metroAfiseaza.Location = new System.Drawing.Point(37, 76);
            this.metroAfiseaza.Name = "metroAfiseaza";
            this.metroAfiseaza.Size = new System.Drawing.Size(225, 50);
            this.metroAfiseaza.Style = MetroFramework.MetroColorStyle.White;
            this.metroAfiseaza.TabIndex = 7;
            this.metroAfiseaza.Text = "Afisează Alimente";
            this.metroAfiseaza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroAfiseaza.TileImage = ((System.Drawing.Image)(resources.GetObject("metroAfiseaza.TileImage")));
            this.metroAfiseaza.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroAfiseaza.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroAfiseaza.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroAfiseaza.UseCustomForeColor = true;
            this.metroAfiseaza.UseSelectable = true;
            this.metroAfiseaza.UseStyleColors = true;
            this.metroAfiseaza.UseTileImage = true;
            this.metroAfiseaza.Click += new System.EventHandler(this.metroAfiseaza_Click_1);
            // 
            // metroAdauga
            // 
            this.metroAdauga.ActiveControl = null;
            this.metroAdauga.ForeColor = System.Drawing.Color.Gold;
            this.metroAdauga.Location = new System.Drawing.Point(37, 133);
            this.metroAdauga.Name = "metroAdauga";
            this.metroAdauga.Size = new System.Drawing.Size(225, 50);
            this.metroAdauga.Style = MetroFramework.MetroColorStyle.White;
            this.metroAdauga.TabIndex = 8;
            this.metroAdauga.Text = "Adaugă Aliment";
            this.metroAdauga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroAdauga.TileImage = ((System.Drawing.Image)(resources.GetObject("metroAdauga.TileImage")));
            this.metroAdauga.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroAdauga.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroAdauga.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroAdauga.UseCustomForeColor = true;
            this.metroAdauga.UseSelectable = true;
            this.metroAdauga.UseStyleColors = true;
            this.metroAdauga.UseTileImage = true;
            this.metroAdauga.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.ForeColor = System.Drawing.Color.Gold;
            this.metroTile1.Location = new System.Drawing.Point(37, 190);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(225, 50);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTile1.TabIndex = 9;
            this.metroTile1.Text = "Caută Aliment";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseCustomForeColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseStyleColors = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_2);
            // 
            // formAlimentBindingSource
            // 
            this.formAlimentBindingSource.DataSource = typeof(track_ui.FormAliment);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(943, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 107);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // FormAliment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1088, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroAdauga);
            this.Controls.Add(this.metroAfiseaza);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroGridAliment);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Name = "FormAliment";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Administrare Alimente";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.FormAliment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridAliment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipProdusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrareAlimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formAlimentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.BindingSource alimentBindingSource;
        private System.Windows.Forms.BindingSource formAlimentBindingSource;
        private System.Windows.Forms.BindingSource administrareAlimentBindingSource;
        private System.Windows.Forms.BindingSource tipProdusBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid metroGridAliment;
        private MetroFramework.Controls.MetroTile metroAfiseaza;
        private MetroFramework.Controls.MetroTile metroAdauga;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}