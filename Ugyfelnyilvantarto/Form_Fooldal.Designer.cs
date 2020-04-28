namespace Ugyfelnyilvantarto
{
    partial class Form_Fooldal
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
            this.DG_Fooldal = new System.Windows.Forms.DataGridView();
            this.button_ujmunka = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_ugyfel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_kollega = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_kilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.button_modositas = new System.Windows.Forms.Button();
            this.button_mentes = new System.Windows.Forms.Button();
            this.DG_fooldal_kivalasztott = new System.Windows.Forms.DataGridView();
            this.checkBox_aktiv = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Fooldal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_fooldal_kivalasztott)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_Fooldal
            // 
            this.DG_Fooldal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Fooldal.Location = new System.Drawing.Point(12, 183);
            this.DG_Fooldal.Name = "DG_Fooldal";
            this.DG_Fooldal.Size = new System.Drawing.Size(1230, 555);
            this.DG_Fooldal.TabIndex = 0;
            this.DG_Fooldal.SelectionChanged += new System.EventHandler(this.DG_Fooldal_SelectionChanged);
            // 
            // button_ujmunka
            // 
            this.button_ujmunka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ujmunka.Location = new System.Drawing.Point(327, 31);
            this.button_ujmunka.Name = "button_ujmunka";
            this.button_ujmunka.Size = new System.Drawing.Size(116, 40);
            this.button_ujmunka.TabIndex = 1;
            this.button_ujmunka.Text = "Új munka";
            this.button_ujmunka.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ugyfel,
            this.ToolStripMenuItem_kollega,
            this.ToolStripMenuItem_kilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_ugyfel
            // 
            this.ToolStripMenuItem_ugyfel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_ugyfel.Name = "ToolStripMenuItem_ugyfel";
            this.ToolStripMenuItem_ugyfel.Size = new System.Drawing.Size(115, 24);
            this.ToolStripMenuItem_ugyfel.Text = "Ügyfél oldalra";
            this.ToolStripMenuItem_ugyfel.Click += new System.EventHandler(this.ToolStripMenuItem_ugyfel_Click);
            // 
            // ToolStripMenuItem_kollega
            // 
            this.ToolStripMenuItem_kollega.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_kollega.Name = "ToolStripMenuItem_kollega";
            this.ToolStripMenuItem_kollega.Size = new System.Drawing.Size(123, 24);
            this.ToolStripMenuItem_kollega.Text = "Kolléga oldalra";
            this.ToolStripMenuItem_kollega.Click += new System.EventHandler(this.ToolStripMenuItem_kollega_Click);
            // 
            // ToolStripMenuItem_kilepes
            // 
            this.ToolStripMenuItem_kilepes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_kilepes.Name = "ToolStripMenuItem_kilepes";
            this.ToolStripMenuItem_kilepes.Size = new System.Drawing.Size(165, 24);
            this.ToolStripMenuItem_kilepes.Text = "Kilépés a programból";
            this.ToolStripMenuItem_kilepes.Click += new System.EventHandler(this.ToolStripMenuItem_kilepes_Click);
            // 
            // button_modositas
            // 
            this.button_modositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modositas.Location = new System.Drawing.Point(567, 31);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(116, 40);
            this.button_modositas.TabIndex = 1;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = true;
            // 
            // button_mentes
            // 
            this.button_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_mentes.Location = new System.Drawing.Point(809, 31);
            this.button_mentes.Name = "button_mentes";
            this.button_mentes.Size = new System.Drawing.Size(116, 40);
            this.button_mentes.TabIndex = 1;
            this.button_mentes.Text = "Mentés";
            this.button_mentes.UseVisualStyleBackColor = true;
            // 
            // DG_fooldal_kivalasztott
            // 
            this.DG_fooldal_kivalasztott.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_fooldal_kivalasztott.Location = new System.Drawing.Point(12, 77);
            this.DG_fooldal_kivalasztott.Name = "DG_fooldal_kivalasztott";
            this.DG_fooldal_kivalasztott.Size = new System.Drawing.Size(1230, 72);
            this.DG_fooldal_kivalasztott.TabIndex = 3;
            // 
            // checkBox_aktiv
            // 
            this.checkBox_aktiv.AutoSize = true;
            this.checkBox_aktiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_aktiv.Location = new System.Drawing.Point(599, 155);
            this.checkBox_aktiv.Name = "checkBox_aktiv";
            this.checkBox_aktiv.Size = new System.Drawing.Size(63, 22);
            this.checkBox_aktiv.TabIndex = 4;
            this.checkBox_aktiv.Text = "Aktív";
            this.checkBox_aktiv.UseVisualStyleBackColor = true;
            this.checkBox_aktiv.CheckedChanged += new System.EventHandler(this.checkBox_aktiv_CheckedChanged);
            // 
            // Form_Fooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 450);
            this.Controls.Add(this.checkBox_aktiv);
            this.Controls.Add(this.DG_fooldal_kivalasztott);
            this.Controls.Add(this.button_mentes);
            this.Controls.Add(this.button_modositas);
            this.Controls.Add(this.button_ujmunka);
            this.Controls.Add(this.DG_Fooldal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Fooldal";
            this.Text = "Főoldal";
            this.Load += new System.EventHandler(this.Form_Fooldal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Fooldal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_fooldal_kivalasztott)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Fooldal;
        private System.Windows.Forms.Button button_ujmunka;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ugyfel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_kollega;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_kilepes;
        private System.Windows.Forms.Button button_modositas;
        private System.Windows.Forms.Button button_mentes;
        private System.Windows.Forms.DataGridView DG_fooldal_kivalasztott;
        private System.Windows.Forms.CheckBox checkBox_aktiv;
    }
}

