namespace track_ui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Aliment = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // Aliment
            // 
            this.Aliment.ActiveControl = null;
            this.Aliment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Aliment.ForeColor = System.Drawing.SystemColors.Control;
            this.Aliment.Location = new System.Drawing.Point(60, 100);
            this.Aliment.Name = "Aliment";
            this.Aliment.Size = new System.Drawing.Size(250, 250);
            this.Aliment.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Aliment.TabIndex = 2;
            this.Aliment.Text = "Aliment";
            this.Aliment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Aliment.TileImage = ((System.Drawing.Image)(resources.GetObject("Aliment.TileImage")));
            this.Aliment.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Aliment.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Aliment.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.Aliment.UseSelectable = true;
            this.Aliment.UseTileImage = true;
            this.Aliment.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(375, 100);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(250, 250);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTile1.TabIndex = 3;
            this.metroTile1.Text = "Persoană";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.Aliment);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile Aliment;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

