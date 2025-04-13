namespace track_ui
{
    partial class CautaPersoana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CautaPersoana));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTitlu = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroNume = new MetroFramework.Controls.MetroTextBox();
            this.metroCauta = new MetroFramework.Controls.MetroTile();
            this.metroGridPersoana = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPersoana)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTitlu
            // 
            this.metroTitlu.AutoSize = true;
            this.metroTitlu.Location = new System.Drawing.Point(3, 0);
            this.metroTitlu.Name = "metroTitlu";
            this.metroTitlu.Size = new System.Drawing.Size(44, 20);
            this.metroTitlu.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTitlu.TabIndex = 1;
            this.metroTitlu.Text = "Cauta";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 30);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nume";
            // 
            // metroNume
            // 
            // 
            // 
            // 
            this.metroNume.CustomButton.Image = null;
            this.metroNume.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.metroNume.CustomButton.Name = "";
            this.metroNume.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroNume.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroNume.CustomButton.TabIndex = 1;
            this.metroNume.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroNume.CustomButton.UseSelectable = true;
            this.metroNume.CustomButton.Visible = false;
            this.metroNume.Lines = new string[0];
            this.metroNume.Location = new System.Drawing.Point(3, 64);
            this.metroNume.MaxLength = 32767;
            this.metroNume.Name = "metroNume";
            this.metroNume.PasswordChar = '\0';
            this.metroNume.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroNume.SelectedText = "";
            this.metroNume.SelectionLength = 0;
            this.metroNume.SelectionStart = 0;
            this.metroNume.ShortcutsEnabled = true;
            this.metroNume.Size = new System.Drawing.Size(120, 23);
            this.metroNume.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroNume.TabIndex = 3;
            this.metroNume.UseSelectable = true;
            this.metroNume.UseStyleColors = true;
            this.metroNume.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroNume.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroCauta
            // 
            this.metroCauta.ActiveControl = null;
            this.metroCauta.Location = new System.Drawing.Point(140, 15);
            this.metroCauta.Name = "metroCauta";
            this.metroCauta.Size = new System.Drawing.Size(163, 72);
            this.metroCauta.TabIndex = 4;
            this.metroCauta.Text = "Caută";
            this.metroCauta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCauta.TileImage = ((System.Drawing.Image)(resources.GetObject("metroCauta.TileImage")));
            this.metroCauta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCauta.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroCauta.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroCauta.UseSelectable = true;
            this.metroCauta.UseTileImage = true;
            this.metroCauta.Click += new System.EventHandler(this.metroCauta_Click);
            // 
            // metroGridPersoana
            // 
            this.metroGridPersoana.AllowUserToResizeRows = false;
            this.metroGridPersoana.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPersoana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridPersoana.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridPersoana.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPersoana.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridPersoana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridPersoana.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridPersoana.EnableHeadersVisualStyles = false;
            this.metroGridPersoana.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridPersoana.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridPersoana.Location = new System.Drawing.Point(4, 94);
            this.metroGridPersoana.Name = "metroGridPersoana";
            this.metroGridPersoana.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridPersoana.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridPersoana.RowHeadersWidth = 51;
            this.metroGridPersoana.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridPersoana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridPersoana.Size = new System.Drawing.Size(863, 464);
            this.metroGridPersoana.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroGridPersoana.TabIndex = 5;
            // 
            // CautaPersoana
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroGridPersoana);
            this.Controls.Add(this.metroCauta);
            this.Controls.Add(this.metroNume);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTitlu);
            this.Name = "CautaPersoana";
            this.Size = new System.Drawing.Size(875, 568);
            this.Load += new System.EventHandler(this.CautaPersoana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridPersoana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroTitlu;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroNume;
        private MetroFramework.Controls.MetroTile metroCauta;
        private MetroFramework.Controls.MetroGrid metroGridPersoana;
    }
}
